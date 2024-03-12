using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4315
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { -3, 0, 2, 1, -2, -1, 3, 4 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}