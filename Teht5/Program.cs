using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int seconds;
            Console.Write("Seconds? ");
            seconds = int.Parse(Console.ReadLine());

            int hours = seconds / 3600;
            int min = seconds / 60 - hours * 60;
            int sec = seconds % 60;
            Console.WriteLine("Tunnit " + hours + " minuutit " + min + " sekuntit " + sec);
        }
    }
}
