using System;
using System.Linq;

namespace Swapping
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var separators = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            var numbers = new int[n]
                    .Select((x, i) => i + 1)
                    .ToArray();

            foreach (int s in separators)
            {
                numbers = Change(numbers, s);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static int[] Change(int[] sequence, int separator)
        {

            var len = sequence.Length;
            var index = 0;
            var result = new int[len];

            while (sequence[index] != separator)
            {
                index++;
            }

            for (int i = 0; i < index; i++)
            {
                result[len - index + i] = sequence[i];
            }

            result[len - index - 1] = sequence[index];

            for (int i = index + 1; i < len; i++)
            {
                result[i - index - 1] = sequence[i];
            }

            return result;
        }
    }
}