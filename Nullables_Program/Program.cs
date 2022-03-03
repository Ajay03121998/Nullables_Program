using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = 22;

            double? c = new double?();
            double? d = 24.23;

            bool? e = new bool?();
            bool? f = true;

            Console.WriteLine("Nullable described {0}, {1}, {2}, {3}, boolean value of {4}, {5}", a, b, c, d,e,f);

            double? g = null;
            double? h = 9.434567;
            double? i;

            i = g ?? 2.767;
            Console.WriteLine("Value of i: {0}", i);
            i = h ?? 6.78;
            Console.WriteLine("Value of i: {0}", i);
            Console.ReadLine();
        }
    }
}
