using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];
           
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give points > ");
                points[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(points);
            //Console.WriteLine(String.Join(", ", points)); <-- Tarkistin, että luvut menevät järjestykseen

            int sum = 0;
            for (int i = 1; i < 4; i++) //Valitaan taulukon alkiot 1-4
            {
                sum += points[i];
            }
            Console.WriteLine("Points for ski jumper are: {0} ",sum);
        }
    }
}
