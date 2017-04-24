using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using ZLibNet;
using System.Net;

namespace UDPCLIENT
{
    class UDPCLIRNT
    {
        public UDPCLIRNT()
        {

        }
        public void recv()
        {
            int recv;

            byte[] data = new byte[1024];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 6001);//定义一网络端点

            Socket newsock = new Socket(SocketType.Dgram, ProtocolType.Udp);//定义一个Socket

            newsock.Bind(ipep);//Socket与本地的一个终结点相关联

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);//定义要发送的计算机的地址

            EndPoint Remote = sender;//

            while (true)
            {
                data = new byte[1024];

                recv = newsock.ReceiveFrom(data, ref Remote);


            }

        }
    }
}
