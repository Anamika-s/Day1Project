using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class ArraysDemo
    {
        static void Main()
        {
            int[,] arr = new int[3, 3];
            int[,,] arr2 = new int[3, 3, 3];

            Console.WriteLine(arr2.GetLowerBound);

            //            // zagged Array/
            //            // when no of rows are fixed, but no of cols for every row is not fixed
            //            int[][] scores = new int[10][];
            //            scores[0] = new int[5];


            //// /int[] num = new int[10];
            //            int[] num1 = new int[] { 1, 2, 3,4 };
            //            Console.WriteLine("Elements are ");
            //            for(int i = 0;i<num1.Length;i++)
            //            {
            //                num1[i] = 100+i;
            //                Console.WriteLine(num1[i]);
            //            }

            //            foreach (int x in num1)
            //            {
            //                //x = 100;
            //                Console.WriteLine(x);
            //            }


            //}
        }
    }

}