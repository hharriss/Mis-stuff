using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime Future = today.AddDays(26);
            Console.WriteLine(today);
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(Future);


            var difference = Future - today;
            Console.WriteLine(difference.Days);
            Console.ReadKey();

        }
    }
}
