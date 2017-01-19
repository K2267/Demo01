using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            Console.Write("How many km's you have drived? >> ");
            distance = double.Parse(Console.ReadLine());

            double consumption = distance / 100 * 7.02;
            double cost = consumption * 1.595;
            Console.WriteLine("Fuel consumption " + consumption + " liters, " + " costs " + cost + " euros");
        }
    }
}
