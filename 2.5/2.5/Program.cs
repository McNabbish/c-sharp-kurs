using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var StudentList = new List<Student>();
            StudentList.Add(new Student("Johan", 27));
            StudentList.Add(new Student("Erik", 25));
            StudentList.Add(new Student("Erik", 26));
            StudentList.Add(new Student("Amanda", 23));
            StudentList.Add(new Student("Amanda", 23));

            foreach (Student T in StudentList)
            {
                Console.WriteLine(T.GetName());
                Console.WriteLine(T.GetAge());
                Console.WriteLine(T.GetInstance());
            }

            StudentList.Sort();

            Console.WriteLine("List sorted with IComparable: ");

            foreach (Student T in StudentList)
            {
                Console.WriteLine(T.GetName());
                Console.WriteLine(T.GetAge());
                Console.WriteLine(T.GetInstance());
            }

            StudentList.Sort(new StudentComparer());

            Console.WriteLine("List sorted with IComparer: ");

            foreach (Student T in StudentList)
            {
                Console.WriteLine(T.GetName());
                Console.WriteLine(T.GetAge());
                Console.WriteLine(T.GetInstance());
            }
            Console.ReadLine();
        }
    }
}
