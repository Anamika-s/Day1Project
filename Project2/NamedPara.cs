using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class NamedPara
    {
        static void Main()
        {
            Display(name: "ajay", id: 900, dept: "HR", salary: 29000, manager: "deepak");


            Display(90000, "seema", "acts", 90909, "deepak");
        }

        static void Display(int id, string name, string dept,
            float salary, string manager)
        {

        }
    }
}
