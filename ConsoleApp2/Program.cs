using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Fibanachi(int n,int x, int y, int z)
        {

            for (int i = 0; i < 1; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine($"{n} number - " + z);
            }
            
            n++;
            if (n==11)
            {
                return;
            }
            Fibanachi(n, x, y, z);
        }

        static void Main(string[] args)
        {
            Fibanachi(1,1, 0, 0);
            Console.WriteLine();
            Console.WriteLine("I do It");
            Console.ReadKey();
        }
    }
}
