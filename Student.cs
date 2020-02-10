using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1___Self_Assessment_Lab
{
    //Student
    public class Student
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static int instances = 0;

        public Student(string _name)
        {
            this.Name = _name;
            instances++;
        }

        public Student(string _name, int age)
        {
            this.Name = _name;
            this.Age = age;
            instances++;
        }
    }
}
