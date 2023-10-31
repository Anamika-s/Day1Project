using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class LoopsDemo
    {
        static void Main()
        {
            // do - while
            // while 
            // for
            // foreach
            //LOOP have 3 statements
            // 1. Ini / STarting 
            // 2. Condtion // Termination
            // 3. Inc / Decr

            // print from 1 to 10
            // do while
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= 10);

            // while
            int y = 1;
            while (y <= 10)
            {
                Console.WriteLine(y);
            }

            // for

            for(int z = 1; z<= 10; z++)
            {
                Console.WriteLine(z);
            }
        }
    }
}
