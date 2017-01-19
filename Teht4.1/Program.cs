using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Give me your age >> "); //Asks users age
            age = int.Parse(Console.ReadLine());

            if (age < 18) Console.WriteLine("minor");
            if (age >= 18 && age <= 65) Console.WriteLine("adult");
            else Console.WriteLine("elder");
        }
    }
}
