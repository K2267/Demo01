using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            //Console.Write("Give a number > ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a number > ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(nums); //Käännetään luvut toisinpäin taulukkoon
            Console.Write(String.Join(", ", nums)); //Tulostetaan taulukko teksti muodossa

            Console.ReadLine();
        }
    }
}
