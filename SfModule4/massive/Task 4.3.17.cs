using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4317
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int count;
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            count = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = count;
                        }
                    }
                }
            }
        }
    }
}