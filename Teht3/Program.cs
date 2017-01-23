using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give 3 numbers
            Console.WriteLine("Give me three numbers and I sum them");
            int number1;
            Console.Write("Give number1 > ");
            number1 = int.Parse(Console.ReadLine());

            int number2;
            Console.Write("Give number2 > ");
            number2 = int.Parse(Console.ReadLine());

            int number3;
            Console.Write("Give number3 > ");
            number3 = int.Parse(Console.ReadLine());

            //Calculate sum and calculate keskiarvo
            double sum = number1 + number2 + number3;
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
