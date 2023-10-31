using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class SumAndAvg
    {
        static void Main()
        {
            int i= 0;
            string ch = "y";
            int sum = 0;
            while(ch=="y")
            {
                Console.WriteLine("Enter Num");
                i = Int16.Parse(Console.ReadLine());
                if (i < 0) continue;
                if (i == 0) break;
                sum += i;
                Console.WriteLine("ENter more num");
                ch=Console.ReadLine();
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
