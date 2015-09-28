using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05继承之构造方法_1
{
    class Student:Person
    {
        public Student(string name,int age,char sex)    //构造方法的定义
            :base(name,age,sex)                         //构造方法的调用
        {
 
        }
    }
}
