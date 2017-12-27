using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfeisy
{
   public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public double Grades { get; set; }
       public String GetName()
        {
            return Name;
        }
       public String GetFullName()
        {
            return FullName;
        }
       public Double GetAvgGrade()
        {
            return Grades;
        }
    }
}
