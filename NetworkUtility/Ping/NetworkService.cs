using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string Sending()
        {
            //SearchDNS()
            //BuildPacket();
            return "Success: Ping Sent!";

        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}