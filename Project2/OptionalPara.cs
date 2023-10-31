using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class OptionalPara
    {
        static void Main()
        {
            SI(10000, 7, 9);

            SI(principal:1999, 9);
            SI(20000);


        }

        static void SI(int principal, int rateOfInt=2, int time=2) {
            Console.WriteLine((principal * rateOfInt * time)/100);
        }
    }
}
