using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace xTuner
{
    public static class myHttpServer
    {
        public static async Task Start(int Port)
        {

            try
            {
                List<Route> routes = new List<Route>(); 

                

                Console.WriteLine("Tuner listing on port: {0}", Port);
                var listener = new TcpListener(IPAddress.Any, Port);            // Set your desired port
                listener.Start();
                while (true)
                {
                    //Console.WriteLine("Wating for calls!");
                    var client = await listener.AcceptTcpClientAsync();         // Asynchronously wait for a client connection
                    _ = HandleClientAsync(client);                              // Start handling the client asynchronously
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static async Task HandleClientAsync(TcpClient client)
        {

        }
    }
}
