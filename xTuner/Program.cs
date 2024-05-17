using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xTuner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int lPort = Convert.ToInt32(args[0]);
                Console.WriteLine("Starting xTuner on Port {0}", lPort);
                myHttpServer.Start(lPort).Wait();
                Console.WriteLine("Exiting!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
