using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08多态的项目_简单
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请问需要使用设备设备：");
            Console.WriteLine("1.UDisk");
            Console.WriteLine("2.USBMouse");
            string choose = Console.ReadLine();


            //创建子类赋值给父类
            USBComponent usb = Factory.CreateInstance(choose);


            if (usb != null)
            {
                usb.Insert();
            }
            else
            {
                Console.WriteLine("请选择正确设备");
            }

            Console.ReadKey();
        }
    }
}
