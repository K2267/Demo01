using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Give height of tree: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int x = 0; x < a - i - 1; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < a - count - 1; x++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
