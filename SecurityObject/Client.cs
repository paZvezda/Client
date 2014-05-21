using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Sockets;

namespace SecurityObject
{
    class Client
    {
        public Client(TcpClient TcpClient)
        {
            string Html = "<html><body<h1>It works! Awesome!</h1></body></html>";
            string Str = "HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + Html.Length + "\n\n" + Html;
            byte[] Buffer = Encoding.ASCII.GetBytes(Str);
            TcpClient.GetStream().Write(Buffer, 0, Buffer.Length);
            TcpClient.Close();
        }
    }
}
