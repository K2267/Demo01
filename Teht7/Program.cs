using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("What year is it? >> ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) //Voit putkittaa ehtoja
            {
                Console.WriteLine("Leap year!");
            }
            else Console.WriteLine("Not a Leap year");

            /*
            int century;
            century = year % 400;
            switch (century)
            {
                case 0:
                    Console.WriteLine("Year is leapyear!");
                    System.Environment.Exit(1);
                    break;

            }

            int cent;
            cent = year % 100;
            switch (cent)
            {
                case 0:
                    Console.WriteLine("Not a leapyear!");
                    System.Environment.Exit(1);
                    break;
            }


            int leap;
            leap = year % 4;
            if (leap == 0)
            {
                Console.WriteLine("Year is leapyear!");
            }   */


        }
    }
}
