using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class MainClass
    {
        static Socket socket = new Socket(  AddressFamily.InterNetwork, 
                                            SocketType.Stream, 
                                            ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.WriteLine("CLIENT V2");
            socket.Connect("192.168.1.3", 904);
            string message = "ahah";
            byte[] buffer = Encoding.ASCII.GetBytes(message.ToCharArray());
            socket.Send(buffer);
        }
    }
}
