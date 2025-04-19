using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice1
{
    internal class DeviceFactory
    {
        private static DeviceFactory instance = new DeviceFactory();
        private Hashtable ht;

        private DeviceFactory() 
        {
            InternetDevice hub = new Hub();
            ht = new Hashtable();
            ht.Add("hub", hub);
        }

        public static DeviceFactory GetInstance() 
        {
            return instance;
        }

        public InternetDevice GetDevice(string hub) 
        {
            if (ht.ContainsKey(hub))
            {
                return (InternetDevice)ht[hub];
            }
            else 
            {
                var newDevice = new Hub();
                ht.Add(hub, newDevice);
                return newDevice;
            }
        }
    }
}
