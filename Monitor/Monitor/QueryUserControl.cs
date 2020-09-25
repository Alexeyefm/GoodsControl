using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Grpc.Core;
using ProtoGRPC;

namespace Monitor
{
    public partial class QueryUserControl : UserControl
    {
        public QueryUserControl()
        {
            InitializeComponent();
        }

        private void buttonSendQuery_Click(object sender, EventArgs e)
        {
            try
            {
                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                var client = new ScannerServer.ScannerServerClient(channel);
                var reply = client.SendQueryToServerDB(new MessageQueryToServerDB
                {
                    TimeFrom = dateTimePickerFrom.Value.ToString(),
                    TimeTo = dateTimePickerTo.Value.ToString()
                });
                int i = 1;
                foreach(GoodsInfo goods in reply.GoodsInfo)
                {
                    richTextBoxLog.AppendText($"{i++}. {goods.Time} {goods.RFID}" + Environment.NewLine);
                }

            }
            catch(Exception ex)
            {
                richTextBoxLog.AppendText("Send query error!" + $"Exception {ex.Message}" + Environment.NewLine);
            }
        }
    }
}
