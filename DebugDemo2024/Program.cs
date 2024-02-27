
using System.Runtime.CompilerServices;

namespace DebugDemo2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            int result = GetSum(a, b);

            Console.WriteLine(result);
            //Console.WriteLine("Hello, World!");

            int res2 = 0;

            for (int i = 0; i < 100; i++)
            {
                res2 = i; 
            }
              
        }

        private static int GetSum(int a, int b)
        {
            return a + b; 
        }
    }
}
