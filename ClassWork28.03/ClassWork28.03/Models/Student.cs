using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork28._03.Models
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Point;
        public Student(string name,string surname,int point)
        {
            Name = name;
            Surname = surname;
            Point = point;

        }
    }
}
