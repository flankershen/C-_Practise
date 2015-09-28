using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08多态的项目_简单
{
    class Factory
    {
        public static USBComponent CreateInstance(string type)
        {
            switch (type)
            {
                case "1": return new UDisk();
                case "2": return new USBMouse();
                default:
                    Console.WriteLine("设备选则错误，请重新选择设备");
                        return null;
            }
        }
    }
}
