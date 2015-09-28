using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USBComponentClass;

namespace UDiskClass
{
    public class UDisk:USBComponentClass.USBComponent
    {
        public override void Insert()
        {
            Console.WriteLine("UDisk is connected");
        }
    }
}
