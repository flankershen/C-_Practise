using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05继承之构造方法_1
{
    class Person
    {
        string name;

        public string Name
        {
            get { return name; }
        }

        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        char sex;

        public char Sex
        {
            get { return sex; }
        }
        public Person(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }
    }
}
