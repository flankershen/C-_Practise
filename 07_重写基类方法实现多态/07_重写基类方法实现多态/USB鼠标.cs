using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_重写基类方法实现多态
{
    class USB鼠标:USB设备
    {
        public override void _插入()
        {
            Console.WriteLine("鼠标可以使用");
        }
    }
}
