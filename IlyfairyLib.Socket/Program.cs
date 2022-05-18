using System.Net;
using System.Net.Sockets;

namespace IlyfairyLib.Sockets
{
    public class SocketServer : SocketBase
    {
        public SocketServer(string ip, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new DnsEndPoint("1.1.1.1", 80));
        }
    }

    public class SocketClient : SocketBase
    {
        
    }

    public class SocketBase
    {
        public Socket socket;
    }

}