using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08多态的项目_简单
{
    class USBComponent
    {
        public virtual void Insert()
        {
            Console.WriteLine("一个USB协议制定结构");
        }
    }
}
