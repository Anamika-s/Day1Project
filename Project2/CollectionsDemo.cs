using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class CollectionsDemo
    {
        static void Main()
        {
            // int[] num = new int[20];
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            for(int i = 0;i < list.Count ; i++) {
                Console.WriteLine(list[i]);

            }

            foreach(int x in list)
            {
                Console.WriteLine(x);
            }
            list.Insert(1, 200);

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
            list.Add("C#");
            list.Add(12.9f);
            list.Add(8978978998);

            list.Remove(200);
            list.RemoveAt(0);

            Console.WriteLine("After deletion");
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }

            Stack stack= new Stack();
            stack.Push(100);
            stack.Push(200);

            Console.WriteLine("Stack");
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }


            stack.Pop();
            Console.WriteLine("Stack after deletion");
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }

            Queue queue= new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);

            queue.Dequeue();
            Console.WriteLine("Queue after deletion");
            foreach (int x in queue)
            {
               

                Console.WriteLine(x);
            }

            Hashtable hashtable= new Hashtable();
            hashtable[1] = 90;
            hashtable[2] = 98;
            hashtable["ajay"] = "delhi";

            Console.WriteLine(hashtable[2]);
            hashtable[2] = 990;
            foreach(int x in hashtable.Values)
            {
                //Console.WriteLine ( x + " " +  hashtable[x]);
                Console.WriteLine(x);
            }




        }
    }
}
