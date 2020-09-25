using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using ProtoGRPC;

namespace Server
{

    class ScanServerImpl : ScannerServer.ScannerServerBase
    {

        public override Task<SendReply> SendDataToServer(SendRequest request, ServerCallContext context)
        {            
            Console.WriteLine("Recieve data from scanner");

            //Write Data to BD
            string sqlVoid = @"AddArrivedTime";
            string connectionString = @"Data Source=DESKTOP-6TD06A0;Initial Catalog=GoodsControl;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlVoid, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter parameterRFID = new SqlParameter
                {
                    ParameterName = "@rfid",
                    Value = request.GoodsInfo.RFID
                };
                command.Parameters.Add(parameterRFID);
                SqlParameter parameterTime = new SqlParameter
                {
                    ParameterName = "@time",
                    Value = request.GoodsInfo.Time
                };
                command.Parameters.Add(parameterTime);

                var result = command.ExecuteNonQuery();
            }

            return Task.FromResult(new SendReply { IsGet = true });
        }

        public override Task<MessageReplyFromServerDB> SendQueryToServerDB(MessageQueryToServerDB request, ServerCallContext context)
        {
            string sqlVoid = @"GetDataForTimeInterval";
            string connectionString = @"Data Source=DESKTOP-6TD06A0;Initial Catalog=GoodsControl;Integrated Security=True";
            List<GoodsInfo> goodsInfo = new List<GoodsInfo>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlVoid, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter parameterRFID = new SqlParameter
                {
                    ParameterName = "@time_from",
                    Value = request.TimeFrom
                };
                command.Parameters.Add(parameterRFID);
                SqlParameter parameterTime = new SqlParameter
                {
                    ParameterName = "@time_to",
                    Value = request.TimeTo
                };
                command.Parameters.Add(parameterTime);

                SqlDataReader result = command.ExecuteReader();
                if (result.HasRows)
                {
                    while(result.Read())
                    {
                        goodsInfo.Add(new GoodsInfo
                        {
                            RFID = result.GetValue(1).ToString(),
                            Time = result.GetValue(1).ToString()
                        });
                    }
                }
            }
            return Task.FromResult(new MessageReplyFromServerDB { GoodsInfo = { goodsInfo } });
        }
    }

    class Program
    {
        const int Port = 50051;
        static void Main(string[] args)
        {
               
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { ScannerServer.BindService(new ScanServerImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
        }
    }
}
