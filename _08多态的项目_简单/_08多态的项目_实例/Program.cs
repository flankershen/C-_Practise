using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USBComponentClass;
using FactoryClass;




namespace _09多态的项目_实例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请问需要使用设备设备：");
            Console.WriteLine("1.UDisk");
            Console.WriteLine("2.USBMouse");
            string choose = Console.ReadLine();

            //赋值给父类
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
