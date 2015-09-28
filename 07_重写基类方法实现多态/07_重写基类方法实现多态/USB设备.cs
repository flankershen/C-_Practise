using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_重写基类方法实现多态
{
    class USB设备
    {
        public virtual void _插入()
        {
            Console.WriteLine("USB设备中的代码正在执行！");
        }
    }
}
