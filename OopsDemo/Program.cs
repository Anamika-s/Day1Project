using System.Collections;

namespace OopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student s1, s2;
            //s1 = new Student();
            //int x, y;
            //Student student1 = new Student();
            //student1.GetDetails();
            //student1.DisplayDetails();

            //Student student2 = new Student();
            //student2.GetDetails();
            //student2.DisplayDetails();


            //Student[] students = new Student[10];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("enter details");
            //    students[i] = new Student();
            //    students[i].GetDetails();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("details are");
            //    students[i].DisplayDetails();
            //}

            //ArrayList list = new ArrayList();
            //Student student= new Student();
            //student.GetDetails();
            //list.Add(student);
            //list.Add(1);

            List<Student> students = new List<Student>();
            students.Add(new Student());

            // Initialize object
            // object initilaizer
            Student student1 = new Student()
            { Id = 10, Name = "deepak", Address = "delhi", Marks = 90 };
            students.Add(student1);
            Student student2= new Student()
            { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 };
            students.Add(student2);

            // List initialzer
            List<Student> list = new List<Student>()
            {
 new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
 new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 },
new Student()  { Id = 11, Name = "deepak", Address = "delhi", Marks = 90 }


        };

            //Console.WriteLine(list[0].Name);
            Console.WriteLine("Stunts are ");
                foreach(Student student in list)
            {
               student.DisplayDetails();
            }
    }
    }
}