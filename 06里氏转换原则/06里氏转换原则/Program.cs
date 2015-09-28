using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换原则
{
    class MyBase
    { }

    class MyClass1 : MyBase
    { }

    class MyClass2 : MyBase
    { }






    class Program
    {
        static void Main(string[] args)
        {
            //里氏转换原则第一条
            MyBase m1 = new MyClass1();
            //里氏转换原则第二条
            MyClass1 m2 = (MyClass1)m1;
            // MyClass2 m2 = (MyClass2)m2;


            // is与as的用法
            MyClass1 m3;
            if (m1 is MyClass1)
            {
                m3 = (MyClass1)m1;
            }
            else
            {
                m3 = null;
            }

            MyClass1 m4 = m1 as MyClass1;  //m3 == m4


            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
