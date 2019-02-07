using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class StudentComparer : IComparer<Student> // Compares objects by Age only
    {
        public int Compare(Student first, Student second )
        {
            if (first.GetAge() != second.GetAge())
                return second.GetAge() - first.GetAge();
            else
                return 0;
        }
    }
}
