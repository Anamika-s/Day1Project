//namespace Project2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int res = Add1(10, 20);
//            Console.WriteLine("Sum is " + res);
//            Console.WriteLine(Add2(10, 20, 30));
//        }

//        static int Add1(int x, int y)
//        {
//            return x + y;
//        }
//        static int Add2(int x, int y, int z)
//        {
//            return x + y+ z;
//        }
//        static float Add3(float x, float y, int z)
//        {
//            return x + y + z;
//        }
//        static string Add4(string x, string y)
//        {
//            return x + " " + y;
//        }

//        static float Add5(int x, float y)
//        {
//            return x + y;
//        }
//    }
//}

namespace Project2
{
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            int res = Add(1, 2);
            Console.WriteLine("Sum is " + res);
            Console.WriteLine(Add(10, 20, 30)) ;
            Console.WriteLine(Add("Ajay", "Kumar"));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        //static void Add(int x, int y)
        //{
              
        //}
        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static float Add(float x, float y, int z)
        {
            return x + y + z;
        }
        static string Add(string x, string y)
        {
            return x + " " + y;
        }

        static float Add(int x, float y)
        {
            return x + y;
        }
    }
}