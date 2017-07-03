using System;
using System.Linq;


namespace JediMeditation
{
    class Program
    {
        static void Main()
        {
            // I dont care the number of Jedy
            Console.ReadLine();

            var waitingJedy = Console.ReadLine()
                    .Split(' ')
                    .ToList()
                    .OrderBy(x => Math.Abs(x[0] - 'M'));

            Console.WriteLine(string.Join(" ", waitingJedy));
        }
    }
}
