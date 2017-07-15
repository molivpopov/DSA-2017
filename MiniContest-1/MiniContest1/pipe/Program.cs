using System;
using System.Diagnostics;
using System.Linq;

namespace pipe
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var pipes = new long[n]
                    .Select(x => long.Parse(Console.ReadLine()))
                    .ToList();

            var allPipeLength = pipes.Sum();
            var piecesOfPipe = new long[n]
                    .Select((x, i) => m * pipes[i] / allPipeLength)
                    .ToList();

            long max;
            int index;
            int counter = 0;
            var sum = piecesOfPipe.Sum();
            var stopw = new Stopwatch();
            stopw.Start();

            while (sum < m)
            {
                max = 0;
                index = 0;

                for (int i = 0; i < piecesOfPipe.Count; i++)
                {
                    counter++;
                    var l = pipes[i] / (piecesOfPipe[i] + 1);
                    if (l > max)
                    {
                        max = l;
                        index = i;
                    }
                }

                piecesOfPipe[index]++;
                sum++;
            }

            var min = long.MaxValue;

            for (int i = 0; i < piecesOfPipe.Count; i++)
            {
                if (piecesOfPipe[i] > 0)
                {
                    var l = pipes[i] / piecesOfPipe[i];
                    min = min < l ? min : l;
                }
            }
            stopw.Stop();
            Console.WriteLine($"stopwatch millseconds:{stopw.Elapsed}");
            Console.WriteLine(min);
            Console.WriteLine(counter);
        }
    }
}
