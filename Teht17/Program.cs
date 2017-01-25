using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int[] arr1 = { 5, 15, 25, 35, 45 };
            int[] arrCombined = arr.Concat(arr1).ToArray(); //yhdistetään taulukot
            Array.Sort(arrCombined); //Järjerstetään luvut
            foreach (int value in arrCombined)
            {
                Console.Write(value);
                // muuttuja on vuorossa oleva alkio kokoelmasta
                Console.Write(","); // Erotetaan pilkulla
            }
        }
    }
}
