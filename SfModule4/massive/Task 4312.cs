using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4312
{
    class Program
    {

    public static void Main(string[] args)
    {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)                    
                {
                Console.WriteLine(item);
                }
            }
        }
  }