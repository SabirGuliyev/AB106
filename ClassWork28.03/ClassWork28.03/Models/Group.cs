using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork28._03.Models
{
    internal class Group
    {
        public string Name;
        public Student[] Students=new Student[0];

        public Group(string name)
        {
            Name = name;

        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1]=student;
        }
        public void Remove(string name)
        {
            Student[] newArr = new Student[Students.Length-1];
            int j = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name!=name)
                {
                    newArr[j]=Students[i];
                        j++;
                }
            }
            Students=newArr;
        }
        public void ShowAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.Name+" "+student.Surname);
            }
        }
        public bool Search(string name)
        {
            foreach (var student in Students)
            {
                if (student.Name==name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
