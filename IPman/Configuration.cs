using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IPman
{
    public class Configuration : IipMan
    {
        private NetworkInterface _ni;
        private UnicastIPAddressInformation _ip;
        private NetworkSetting _settings;

        public Configuration(NetworkInterface ni, UnicastIPAddressInformation ip, NetworkSetting settings)
        {
            _ni = ni;
            _ip = ip;
            _settings = settings;
        }
        
        public string GetIP()
        {
           return _ni.GetPhysicalAddress().ToString();            
        }
        
    }
}


        

//        foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
//{
//   if(ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
//   {
//       Console.WriteLine(ni.Name);
//       foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
//       {
//           if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
//           {
//               Console.WriteLine(ip.Address.ToString());
//           }
//}
//   }  
//}