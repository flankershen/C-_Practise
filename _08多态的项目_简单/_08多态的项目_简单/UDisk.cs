using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08多态的项目_简单
{
    class UDisk:USBComponent
    {
        public override void Insert()
        {
            Console.WriteLine("USB is connected");
        }
    }
}
