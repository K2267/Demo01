using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 }; //Taulukko
            

            for (int i = 0; i < numbers.Length; i++) //Console.Write(numbers[i]); //Tulostaa taulukon
            
            if (numbers[i] % 2 == 0)
                {
                    Console.Write(" HEP ");
                }
               
            else Console.Write(numbers[i]);

        }
    }
}
