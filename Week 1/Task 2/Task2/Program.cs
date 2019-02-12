using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string Name;
        public string Id;
        public int YearofStudy;
        public Student(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetId()
        {
            return Id;
        }
        public int GetYearOfStudy()
        {
            return ++YearofStudy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Info = new Student(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(Info.GetName());
            Console.WriteLine(Info.GetId());
            Console.WriteLine(Info.GetYearOfStudy());
            Console.ReadKey();
        }
    }
}
