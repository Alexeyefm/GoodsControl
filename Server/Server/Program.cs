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
            return Task.FromResult(new SendReply { IsGet = true });
        }
    }

    class Program
    {
        const int Port = 50051;
        static void Main(string[] args)
        {
            string connectionString = "connection string";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Services = { ScannerServer.BindService(new ScanServerImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
        }
    }
}
