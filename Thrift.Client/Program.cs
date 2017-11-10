using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace Thrift.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TTransport transport = new TSocket("localhost",9095);
            transport.Open();

            TProtocol protocal = new TBinaryProtocol(transport);
            MathService.Client client = new MathService.Client(protocal);

            Console.WriteLine(client.add (10,20));
            Console.WriteLine(client.sub (10, 20));
            Console.WriteLine(client.mul(10, 20));
            Console.WriteLine(client.div(10, 20));
            Console.WriteLine(client.mod(10, 20));
        }
    }
}
