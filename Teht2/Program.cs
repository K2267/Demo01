using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give student points in numbers
            int number;
            Console.Write("Give points > ");
            number = int.Parse(Console.ReadLine());

            //Show students grade
            switch (number)
            {
                case 0:
                case 1:
                    Console.WriteLine("Your grade is 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Your grade is 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Your grade is 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Your grade is 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Your grade is 4");
                    break;
                case 10:
                case 12:
                    Console.WriteLine("Your grade is 5");
                    break;

            }
            Console.ReadLine();
        }
    }
}
