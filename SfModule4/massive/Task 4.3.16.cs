using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4316
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int count = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
