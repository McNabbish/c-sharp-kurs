using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Student : IComparable<Student>
    {
        static public int n;
        private string name;
        private int age;
        private int Instance;


        public Student(string a, int b)
        {
            name = a;
            age = b;
            Instance = n++;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }
        public int GetInstance()
        {
            return Instance;
        }

        public int CompareTo(Student a) // default comparison, primarily by name, age and addition to list
        {
            if (this.GetName() != a.GetName())
                return this.GetName().CompareTo(a.GetName());
            else if (this.GetName() == a.GetName())
                return this.GetAge().CompareTo(a.GetAge());
            else
                return this.GetInstance().CompareTo(a.GetInstance());
        }
    }



}
