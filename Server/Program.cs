using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class MainClass
    {
        static Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 3389));
            socket.Listen(10);
            Socket connecter = socket.Accept();
            byte[] buffer = new byte[1024];
            connecter.Receive(buffer);
            Console.WriteLine(Encoding.ASCII.GetString(buffer));
        }
    }
}
