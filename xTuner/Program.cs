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


                myHttpServer.Start();

            }
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);

            }
        }
    }
}
