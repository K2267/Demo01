using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give 3 numbers
            Console.WriteLine("Give me three numbers >> ");
            int num1;
            Console.Write("Give number1 > ");
            num1 = int.Parse(Console.ReadLine());

            int num2;
            Console.Write("Give number2 > ");
            num2 = int.Parse(Console.ReadLine());

            int num3;
            Console.Write("Give number3 > ");
            num3 = int.Parse(Console.ReadLine());

            //Solving biggest number
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Biggest number is: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Biggest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("Biggest number is: {0}", num3);
            }
            //Shorter way is to use array
        }
    }
}
