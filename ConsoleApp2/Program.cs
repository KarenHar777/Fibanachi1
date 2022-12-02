using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Fibanachi(int x, int y, int z)
        {
            
            for (int i = 0; i < 10; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine(z);
            }
            return;
            Fibanachi(x, y, z);
        }
        
        static void Main(string[] args)
        {
            Fibanachi(1, 0, 0);
            Console.WriteLine();
            Console.WriteLine("I do It");
            Console.ReadKey();
        }
    }
}
