using ClassWork28._03.Models;

namespace ClassWork28._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AB106");
            Group group2 = new Group("AF103");

            Student student = new Student("Garib","Garibzade",20);
            Student student2 = new Student("Samuray","Katanov",25);

            //Console.WriteLine("1 ci grup:");
            group.AddStudent(student);
            group.AddStudent(student2);
            group.ShowAllStudents();
            group.Remove("Samuray");
            Console.WriteLine("\n\nSildikden sonra\n");
            group.ShowAllStudents();


            //Console.WriteLine("\n 2ci grup:");
            Student student4 = new Student("Inare", "Ehmedova", 25);

            Student student3 = new Student("Nazrin", "Aliyev", 70);
            group2.AddStudent(student3);
            group2.AddStudent(student4);
            //group2.ShowAllStudents();

            //Console.WriteLine(group2.Search("Garib"));
        }
       
    }

}
//Student class:
//Name
//Surname
//Point


//Group class:
//Name
//Student[] Students=new Student[0]

//AddStudent(Student student) qebul etdiyi telebeni
// groupun arrayine elave edir
 
//ShowAllStudent() butun telebelrin ad ve soyad cixarir

//bool Search(string name)

//Remove(string name) method arraydan bu adli telebeni cixarir
