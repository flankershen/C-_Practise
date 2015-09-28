using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USBComponentClass;

namespace UMouseClass
{
    public class UMouse:USBComponentClass.USBComponent
    {
        public override void Insert()
        {
            Console.WriteLine("UMouse is connected");
        }
    }
}
