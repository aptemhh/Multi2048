using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace lab8
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            try
            {
                
                Thread readTcpClient = new Thread(() =>
                {
                    TcpClient tcpClient = new TcpClient();
                    tcpClient.Connect("192.168.43.164", 9878);

                    BinaryReader binaryReader = new BinaryReader(tcpClient.GetStream());
                    Console.WriteLine(binaryReader.ReadString());

                    BinaryWriter binaryWriter = new BinaryWriter(tcpClient.GetStream());
                    binaryWriter.Write("Я клиент!");
                    
                });
                Thread server=new Thread(() =>
                {
                    TcpListener listener = TcpListener.Create(9878);
                    listener.Start();
                    Socket s = listener.AcceptSocket();

                    BinaryWriter binaryWriter = new BinaryWriter(new NetworkStream(s));
                    binaryWriter.Write("ты подключился!привет!!!");

                    BinaryReader binaryReader = new BinaryReader(new NetworkStream(s));
                    Console.WriteLine(binaryReader.ReadString());
                    listener.Stop();
                });




                readTcpClient.Start();
               // server.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

}
