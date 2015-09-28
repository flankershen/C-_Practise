using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_重写基类方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
            USB风扇 u1 = new USB风扇();
            u1._插入();
            USB设备 u = u1;
            u._插入();

            Console.WriteLine("OK");
            Console.ReadKey();
           */
            USB设备 u = null;
            //u = new USB风扇();
            u = new USB鼠标();

            u._插入();

            Console.ReadKey();
            
        }
    }
}
