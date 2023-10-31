using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class CallByValueCallByRef
    {
        static void Main()
        {
            int[,] arr = new int[3, 3];
            int[,,] arr2 = new int[3, 13, 3];

            Console.WriteLine(arr2.GetLength(0));
            Console.WriteLine(arr2.GetLength(1));
            int x = 10;
            Console.WriteLine($"Value of x before calling Chaange1 {x}");
            Change1(x);
            Console.WriteLine($"Value of x after calling Chaange1 {x}");

            Change2(ref x);
            Console.WriteLine($"Value of x after calling Chaange2 {x}");


        }
        static void Change1(int x)
        {
            x = 100;
            Console.WriteLine($"Value of x in Chaange1 {x}");

        }
        static void Change2(ref int x)
        {
            x = 200;
            Console.WriteLine($"Value of x in Chaange2 {x}");

        }
    }
}
