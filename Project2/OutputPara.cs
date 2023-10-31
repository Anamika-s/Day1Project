using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class OutputPara
    {
        static void Main()
        {
            Console.WriteLine("MAin");
            int add, subtract, product;
            float quo, remainder;
            Operations(x:30, y:10, out add, out subtract, out product, out remainder, out quo);
            Console.WriteLine($"Result is {add} {subtract} {product} {remainder} {quo}");

        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Difference(int x, int y)
        {
            return x - y;
        }
        static int Product(int x, int y)
        {
            return x * y;
        }



        // using output para ,  funtion can return more than 1 value

        static void Operations(int x, int y, out int add,
            out int difference ,
            out int product,
            out float remiander,
            out float quotient)
        {
            add = x+y;
            difference = x-y;
            product = x*y;
            remiander = x%y;
            quotient = x/y;

        }
    }
}
