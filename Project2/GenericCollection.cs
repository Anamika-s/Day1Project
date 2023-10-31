using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class GenericCollection
    {
        static void Main()
        {
             //ArrayList list = new ArrayList();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            foreach(int  x in list)
            {
                Console.WriteLine(x);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("AA");

            Queue<float> floats= new Queue<float>();

            Dictionary<int, int> scores= new Dictionary<int, int>();
            scores[1] = 90;

        }
    }
}
