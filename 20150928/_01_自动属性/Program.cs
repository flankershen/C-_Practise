using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_自动属性
{
    public class Person 
    {
        string name;
        public string Name
        {
            //get读取器，set读取器
            get { return name; }
            set { name = value; }
        }

        //自动属性
        public int Age
        {
            get;
            set;        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.Age = 10;
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }
}
