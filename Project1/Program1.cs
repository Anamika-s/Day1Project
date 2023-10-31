using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Single Line Comment
/* 
 
 */

    class SequentialProgram
    {
    static void Main()
    {
        int x;
        int y;
        Console.WriteLine("Enter value of x");
        x = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter value of y");
        y = Convert.ToByte(Console.ReadLine());
        //Console.WriteLine("Sum of x and y is " + (x+y));
        //Console.WriteLine("Sum of {0} and {1} is {2} " ,x,y, (x + y));
        Console.WriteLine($"Sum of {x} and {y} is {x + y}");

        Console.WriteLine($"Difference of {x} and {y} is {x - y}");

        Console.WriteLine($"Product of {x} and {y} is {x * y}");

        Console.WriteLine($"Remainder of {x} and {y} is {x % y}");

        Console.WriteLine($"Quotient of {x} and {y} is {x / y}");




    }
}

