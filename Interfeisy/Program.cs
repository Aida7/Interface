using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfeisy;

namespace Interfeisy
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string name = "Adil";
            string fullName = "Birzanov";
            double grades = 1;
            student.Name = name;
            student.FullName = fullName;
            student.Grades = grades;
            Console.WriteLine("data = {0}\n{1}\n{2}", student.Name, student.FullName, student.Grades);
        }
    }

    
}
