using System;
using System.Collections.Generic;
using Grpc.Core;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UHF;
using Errors;
using Converter;
using ProtoGRPC;
using Google.Protobuf;


namespace Scanner
{
    public partial class Scanner : Form
    {
        private bool fIsInventoryScan;
        private byte scantime = 0;
        private DateTime resultTime;
        private Dictionary<string, DateTime> scanData = new Dictionary<string, DateTime>();
        public Scanner()
        {
            InitializeComponent();
        }

        private void EnabledForm()
        {
            groupBoxReaderAddress.Enabled = true;
            groupBoxPower.Enabled = true;
            groupBoxOperationGPIO.Enabled = true;
            groupBoxReaderSerialNumber.Enabled = true;
            groupBoxPower.Enabled = true;
            groupBoxRegion.Enabled = true;
            groupBoxBufferLength.Enabled = true;
            groupBoxBeep.Enabled = true;
            groupBoxFirmwareVersion.Enabled = true;
            RWDev.readerInit = true;
            buttonStart.Enabled = true;
            comboBoxScanTime.Enabled = true;
            labelMaxScanTime.Enabled = true;
        }

        private void DisabledForm()
        {
            textBoxFirmwareVersion.Text = "";
            textBoxReaderSerialNumber.Text = "";
            groupBoxReaderAddress.Enabled = false;
            groupBoxPower.Enabled = false;
            groupBoxOperationGPIO.Enabled = false;
            groupBoxReaderSerialNumber.Enabled = false;
            groupBoxPower.Enabled = false;
            groupBoxRegion.Enabled = false;
            groupBoxBufferLength.Enabled = false;
            groupBoxBeep.Enabled = false;
            groupBoxFirmwareVersion.Enabled = false;
            RWDev.readerInit = false;
            buttonStart.Enabled = false;
            comboBoxScanTime.Enabled = false;
            labelMaxScanTime.Enabled = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            richTextBoxLogs.Clear();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            ScanTimer.Enabled = !ScanTimer.Enabled;

            if (ScanTimer.Enabled)
            {
                scantime = Convert.ToByte(comboBoxScanTime.SelectedIndex + 3);
                fIsInventoryScan = false;

                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
            }
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            DisabledForm();
            comboBoxBaud.SelectedIndex = 3;
            comboBoxCOM.SelectedIndex = 0;
            radioButtonUEBand.Checked = true;
            comboBoxSetBaudRate.SelectedIndex = 3;
            comboBoxPower.SelectedIndex = 26;
            int i = 0;
            for (i = 0x03; i <= 0xff; i++)
                comboBoxScanTime.Items.Add(Convert.ToString(i) + "*100ms");
            comboBoxScanTime.SelectedIndex = 7;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            int portNum = comboBoxCOM.SelectedIndex + 1;

            byte baudRate = Convert.ToByte(comboBoxBaud.SelectedIndex);
            if (baudRate > 2)
                baudRate = Convert.ToByte(baudRate + 2);
            int portHandle = 0;

            try
            {

                ErrorsCatcher.errorName = RWDev.OpenComPort(portNum, ref RWDev.comAddress, baudRate, ref portHandle);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Connection failed: " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    richTextBoxLogs.ScrollToCaret();
                    return;
                }
                else
                {
                    RWDev.frmComPortIndex = portHandle;
                    string strLog = "Connected  " + comboBoxCOM.Text + "@" + comboBoxBaud.Text + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
                EnabledForm();
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch
            {
                richTextBoxLogs.AppendText("Connected failed!" + Environment.NewLine);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (RWDev.frmComPortIndex > 0)
                RWDev.CloseSpecComPort(RWDev.frmComPortIndex);
            string strLog = "Dissconected" + Environment.NewLine;
            richTextBoxLogs.AppendText(strLog);
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            DisabledForm();
        }

        private void inventory()
        {
            byte Ant = 0;
            int CardNum = 0;
            int Totallen = 0;
            int EPClen, m;
            byte[] EPC = new byte[50000];
            int CardIndex;
            string temps, temp;
            temp = "";
            string sEPC;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            byte MaskFlag = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            DataGridViewRow rows = new DataGridViewRow();


            ErrorsCatcher.errorName = RWDev.Inventory_G2(ref RWDev.comAddress, RWDev.QValue, RWDev.session, MaskMem, MaskAdr, MaskLen, MaskData,
                                            MaskFlag, AdrTID, LenTID, RWDev.TIDFlag, RWDev.target, RWDev.inAnt, scantime, RWDev.fastFlag,
                                            EPC, ref Ant, ref Totallen, ref CardNum, RWDev.frmComPortIndex);

             
            resultTime = DateTime.Now;

            if ((ErrorsCatcher.errorName == 1) | (ErrorsCatcher.errorName == 2) | (ErrorsCatcher.errorName == 3) | (ErrorsCatcher.errorName == 4))
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                temps = ConverterTo.ByteArrayToHexString(daw);
                m = 0;
                if (CardNum == 0) return;

                for (CardIndex = 0; CardIndex < CardNum; CardIndex++)
                {
                    EPClen = daw[m] + 1;
                    temp = temps.Substring(m * 2 + 2, EPClen * 2);
                    sEPC = temp.Substring(0, temp.Length - 2);
                    string RSSI = Convert.ToInt32(temp.Substring(temp.Length - 2, 2), 16).ToString();
                    m = m + EPClen + 1;
                    if (sEPC.Length != (EPClen - 1) * 2)
                    {
                        return;
                    }

                    if (!scanData.ContainsKey(sEPC))
                    {
                        scanData.Add(sEPC, resultTime);
                        richTextBoxLogs.AppendText(resultTime.ToString() + " goods with RFID " + sEPC + " scaned." + Environment.NewLine);
                        Task sendToServer = Task.Run(() => {
                            try {
                                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                                var client = new ScannerServer.ScannerServerClient(channel);
                                var reply = client.SendDataToServer(new SendRequest { GoodsInfo = { RFID = sEPC, Time = resultTime.ToString() } });
                            }
                            catch
                            {
                                richTextBoxLogs.AppendText("Send data to server failed!"+ Environment.NewLine);
                            }
                        });
                    }                    
                }
            }
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (fIsInventoryScan)
                return;
            fIsInventoryScan = true;
            inventory();
            fIsInventoryScan = false;
        }

        private void buttonBeepSet_Click(object sender, EventArgs e)
        {
            byte BeepEn = 0;
            if (radioButtonBeepOpen.Checked)
                BeepEn = 1;
            else
                BeepEn = 0;
            try
            {
                ErrorsCatcher.errorName = RWDev.SetBeepNotification(ref RWDev.comAddress, BeepEn, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set beep failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Set beep success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set beep failed!" + Environment.NewLine);
            }

        }

        private void buttonGetGPIO_Click(object sender, EventArgs e)
        {
            byte OutputPin = 0;
            try
            {

                ErrorsCatcher.errorName = RWDev.GetGPIOStatus(ref RWDev.comAddress, ref OutputPin, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Get GPIO status failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    if ((OutputPin & 0x10) == 0x10)
                        checkBoxOUT1.Checked = true;
                    else
                        checkBoxOUT1.Checked = false;

                    if ((OutputPin & 0x20) == 0x20)
                        checkBoxOUT2.Checked = true;
                    else
                        checkBoxOUT2.Checked = false;

                    if ((OutputPin & 0x01) == 1)
                        checkBoxINT1.Checked = true;
                    else
                        checkBoxINT1.Checked = false;

                    if ((OutputPin & 0x02) == 2)
                        checkBoxINT2.Checked = true;
                    else
                        checkBoxINT2.Checked = false;

                    string strLog = "Get GPIO status success " + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Get GPIO failed!" + Environment.NewLine);
            }
        }

        private void buttonSetGPIO_Click(object sender, EventArgs e)
        {
            byte OutputPin = 0;
            if (checkBoxOUT1.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x01);
            if (checkBoxOUT2.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x02);
            try
            {
                ErrorsCatcher.errorName = RWDev.SetGPIO(ref RWDev.comAddress, OutputPin, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set GPIO failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Set GPIO success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set GPIO failed!" + Environment.NewLine);
            }

        }

        private void buttonSetReaderAddress_Click(object sender, EventArgs e)
        {
            byte aNewComAdr = Convert.ToByte(textBoxReaderAddress.Text, 16);
            try
            {
                ErrorsCatcher.errorName = RWDev.SetAddress(ref RWDev.comAddress, aNewComAdr, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set address failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Address " + textBoxReaderAddress.Text + " set" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set address failed!" + Environment.NewLine);
            }

        }

        private void buttonReadSerial_Click(object sender, EventArgs e)
        {
            byte[] SeriaNo = new byte[4];
            textBoxReaderSerialNumber.Text = "";
            try
            {
                ErrorsCatcher.errorName = RWDev.GetSeriaNo(ref RWDev.comAddress, SeriaNo, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Read serial number failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Read serial number success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Read serial number failed!" + Environment.NewLine);
            }

        }

        private void buttonSetPower_Click(object sender, EventArgs e)
        {
            byte powerDbm = (byte)comboBoxPower.SelectedIndex;
            try
            {
                ErrorsCatcher.errorName = RWDev.SetRfPower(ref RWDev.comAddress, powerDbm, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set power failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Set address success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set power failed!" + Environment.NewLine);
            }

        }

        private void buttonSetBaudRate_Click(object sender, EventArgs e)
        {
            byte fBaud = (byte)comboBoxBaud.SelectedIndex;
            if (fBaud > 2)
                fBaud = (byte)(fBaud + 2);
            try
            {
                ErrorsCatcher.errorName = RWDev.SetBaudRate(ref RWDev.comAddress, fBaud, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set baud rate failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Set baud rate success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set baud rate failed" + Environment.NewLine);
            }

        }

        private void buttonSetRegion_Click(object sender, EventArgs e)
        {
            byte dminfre, dmaxfre;
            int band = 2;
            if (radioButtonChineeseBand2.Checked)
                band = 1;
            if (radioButtonUSBand.Checked)
                band = 2;
            if (radioButtonChineeseBand.Checked)
                band = 3;
            if (radioButtonUEBand.Checked)
                band = 4;
            dminfre = Convert.ToByte(((band & 3) << 6) | (comboBoxDminfre.SelectedIndex & 0x3F));
            dmaxfre = Convert.ToByte(((band & 0x0c) << 4) | (comboBoxDmaxfre.SelectedIndex & 0x3F));
            try
            {
                ErrorsCatcher.errorName = RWDev.SetRegion(ref RWDev.comAddress, dmaxfre, dminfre, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName != 0)
                {
                    string strLog = "Set region failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
                else
                {
                    string strLog = "Set region success" + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set region dailed" + Environment.NewLine);
            }

        }

        private void buttonSetBufferLength_Click(object sender, EventArgs e)
        {
            byte SaveLen = 0;

            if (radioButton128bitBuff.Checked)
            {
                SaveLen = 0;
            }
            else
            {
                SaveLen = 1;
            }
            try
            {
                ErrorsCatcher.errorName = RWDev.SetSaveLen(ref RWDev.comAddress, SaveLen, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName == 0)
                {
                    string strLog = "Set buffer EPC/TID length success " + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
                else
                {
                    string strLog = "Set buffer EPC/TID length failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Set buffer EPC/TID length failed" + Environment.NewLine);
            }

        }

        private void buttonGetBuffLength_Click(object sender, EventArgs e)
        {
            byte SaveLen = 0;
            try
            {
                ErrorsCatcher.errorName = RWDev.GetSaveLen(ref RWDev.comAddress, ref SaveLen, RWDev.frmComPortIndex);
                if (ErrorsCatcher.errorName == 0)
                {

                    if (SaveLen == 0)
                        radioButton128bitBuff.Checked = true;
                    else
                        radioButton496bitBuff.Checked = true;
                    string strLog = "Get buffer EPC/TID length success " + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                }
                else
                {
                    string strLog = "Get buffer EPC/TID length failed " + ErrorsCatcher.GetReturnCodeDesc(ErrorsCatcher.errorName) + Environment.NewLine;
                    richTextBoxLogs.AppendText(strLog);
                    return;
                }
            }
            catch
            {
                richTextBoxLogs.AppendText("Get buffer EPC/TID length failed!" + Environment.NewLine);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
