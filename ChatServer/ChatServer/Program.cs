using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using ChatServer.ServerModels;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ep = new IPEndPoint(ip, 1024);
            s.Bind(ep);
            s.Listen(10);
            Console.WriteLine("Server Start");
            try
            {
                while (true)
                {
                    Socket ns = s.Accept();
                    Console.WriteLine(ns.RemoteEndPoint.ToString());

                    var newUser = new ServerUser();
                    
                    //Прием
                    byte[] buffer = new byte[1024];
                    int l; //длина ответа

                    string result = "";

                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    
                    do
                    {
                        Thread.Sleep(10);

                        if (ns.Available > 0)
                        {
                            l = ns.Receive(buffer);
                            result += System.Text.Encoding.ASCII.GetString(buffer, 0, l);
                        }
                        if (result.Length > 0)
                        {
                            Console.WriteLine(result);
                            result = "";
                        }


                    } while (true);


                    ns.Shutdown(SocketShutdown.Both);
                    ns.Close();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}