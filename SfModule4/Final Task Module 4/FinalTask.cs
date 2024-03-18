using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            (string fName, string lName, string Login, int LoginLength, bool Pet, double Age, string favColors) User;

            Console.WriteLine("Введите имя");
            User.fName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.lName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var meaning = Console.ReadLine();
            if (meaning == "Да");
            {
                User.Pet = true;
            }
            if (meaning != "Да") ;
            {
                User.Pet = false;
            }

        }
    }
}
