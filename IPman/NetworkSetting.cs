using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPman
{
    public class NetworkSetting
    {
        public IPAddress ipaddress { get; set; }
        public string SubnetMask { get; set; }
        public string Gateway { get; set; }
    }
}
