using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1___Self_Assessment_Lab
{
    //Teacher
    public class Teacher
    {
        private string _name;
        private bool _PhD;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool PhD
        {
            get { return _PhD; }
            set { _PhD = value; }
        }

        public static int instances = 0;

        public Teacher(string name)
        {
            this.Name = name;
            instances++;
        }

        public Teacher(string name, bool PhD)
        {
            this.Name = name;
            this.PhD = PhD;
            instances++;
        }
    }
}
