using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesuring
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Stopwatch();
            var list = new List<int>();
            list.Add(23);
            var arr = new int[10000];
            int k;

            st.Start();
            for (int i = 0; i < 10000000; i++)
            {
                k = list[0]++;
            }
            st.Stop();
            Console.WriteLine($"list in ms:{st.ElapsedMilliseconds}");

            st.Start();
            for (int i = 0; i < 10000000; i++)
            {
                k = arr[0]++;
            }
            st.Stop();
            Console.WriteLine($"array in ms:{st.ElapsedMilliseconds}");
        }
    }
}
