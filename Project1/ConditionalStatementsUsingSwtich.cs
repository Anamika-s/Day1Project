using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Single Line Comment
/* 
 
 */

class ConditionalStatementsUsingSwtich
{
    static void Main()
    {
        int x;
        int y;
        string ch;
        Console.WriteLine("Enter value of x");
        x = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter value of y");
        y = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter choice");
        ch = Console.ReadLine();

        //Console.WriteLine("Sum of x and y is " + (x+y));
        //Console.WriteLine("Sum of {0} and {1} is {2} " ,x,y, (x + y));
        switch (ch)
        {

            case "1":
            case "+":
                Console.WriteLine($"Sum of {x} and {y} is {x + y}");
                break;
            case "2":
            case "-":

                Console.WriteLine($"Difference of {x} and {y} is {x - y}");
                break;
            case "3":
                Console.WriteLine($"Product of {x} and {y} is {x * y}");
                break;
            case "4":
                Console.WriteLine($"Remainder of {x} and {y} is {x % y}");
                break;
            case "5":
                Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
                break;
           
        }


    }
}

