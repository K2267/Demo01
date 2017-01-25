using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); 

            int number = random.Next(1, 100); //Valitaan rodomisti luku välillä 1-100
            Console.WriteLine(number);

            int Guess = 0;

            Console.WriteLine("Guess number between 1-100. ");

            for (int i = 1; i != 0; i++)
            {
                Guess = int.Parse(Console.ReadLine());

                if (Guess < number)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
                }
                else if (Guess > number)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
                }
                else
                {
                    Console.WriteLine("Correct! {0} is the correct number. You guessed number in {1} try! ", Guess, i);
                
                }

            }   
            Console.ReadLine();
        }
    }
}

