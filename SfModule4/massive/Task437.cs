using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");
            var name = Console.ReadLine();
            var namereverse = "";
            for (int i = name.Length - 1; i >= 0; i--) {
                namereverse += name[i];
            }
            Console.WriteLine("Ваше имя в обратном порядке: {0}", namereverse);
            Console.ReadKey();
        }
    }
}