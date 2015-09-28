using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承扩展
{
    class MyBase
    {
        public int num1 = 10;
    }

    class MyClass : MyBase
    {
        public int num2 = 11;
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();
            MyClass m3 = new MyClass();
        }
    }
}
