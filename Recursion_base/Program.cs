using System;

namespace Recursion_base
{
    class Program
    {
        static void Rec(int i) 
        {
            if (i < 1) return;
            Console.WriteLine("***");
            Rec(--i);
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("***");
            //}

            Rec(3);
        }
    }
}
