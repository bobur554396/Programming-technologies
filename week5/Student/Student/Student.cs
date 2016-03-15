using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        private string name;
        private int age;

        public Student() { }

        public Student(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public String Name{
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
