using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Single Line Comment
/* 
 
 */

class ConditionalStatements
{
    static void Main()
    {
        int x;
        int y;
        int ch;
        Console.WriteLine("Enter value of x");
        x = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter value of y");
        y = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Enter choice");
        ch = Byte.Parse(Console.ReadLine());

        //Console.WriteLine("Sum of x and y is " + (x+y));
        //Console.WriteLine("Sum of {0} and {1} is {2} " ,x,y, (x + y));
        if(ch==1)
        Console.WriteLine($"Sum of {x} and {y} is {x + y}");
        else if(ch==2)
        Console.WriteLine($"Difference of {x} and {y} is {x - y}");
        else if (ch==3)
        Console.WriteLine($"Product of {x} and {y} is {x * y}");
        else if(ch==4)
        Console.WriteLine($"Remainder of {x} and {y} is {x % y}");
        else if(ch==5)
        Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
        else
            Console.WriteLine("invalid choice");



    }
}

