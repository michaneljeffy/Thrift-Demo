using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Server;
using Thrift.Transport;
using Thrift.Protocol;

namespace Thrift.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MathServer handler = new MathServer();
                MathService.Processor process = new Server.MathService.Processor(handler);

                TServerTransport serverTransport = new TServerSocket(9095);
                TServer server = new TSimpleServer(process, serverTransport);
                Console.WriteLine("Starting the server....");
                server.Serve();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("done");
        }
    }
}
