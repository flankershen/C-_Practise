using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USBComponentClass;
using UDiskClass;
using UMouseClass;

namespace FactoryClass
{
    public class Factory
    {
        public static USBComponent CreateInstance(string type)
        {
            switch (type)
            {
                case "1": return new UDisk();
                case "2": return new UMouse();
                default: 
                    Console.WriteLine("设备选则错误！");
                   return null;
         
            }
        }
    }
}
