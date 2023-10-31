using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class CallingDll
    {
        static void Main()
        {
            //CommonFunctions.NumericFunctions /*numericFunctions*/ = new CommonFunctions.NumericFunctions();
            Console.WriteLine(CommonFunctions.NumericFunctions.Add(10, 20));
            CommonFunctions.StringFunctions stringFunctions = new CommonFunctions.StringFunctions();

            Console.WriteLine(stringFunctions.Table(8));
        }
    }
}
