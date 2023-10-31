using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
     class Student
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        int marks;
        public int Marks
        {
            get { return marks; } set
            {
                marks = value;
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("enter id");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = Byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"id is {id}");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"address is {address}");
            
            Console.WriteLine($"marks are {marks}");

        }
    }
}
