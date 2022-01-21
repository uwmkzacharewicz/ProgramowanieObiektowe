using System;
using System.Threading;

namespace Watki
{
    class Program
    {
        public static void Licz()
        {
            for (int i = 1; i <= 10000; i++)
            {
                Console.WriteLine($"watek: {i}");
            }
        }
        static void Main(string[] args)
        {
            Thread thr = new Thread(Licz);
            thr.Start();

            for(int i = 1; i <= 10000; i++)
            {
                Console.WriteLine($"program1: {i}");
            }            
        }
    }
}
