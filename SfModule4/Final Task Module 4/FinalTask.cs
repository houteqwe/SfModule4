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
            (string fName, string lName, string Login, int LoginLength, bool Pet, double Age, string[] favColors) User;
            {
                for (int k = 0; k < 3; k++)
                {

                    //имя фамилия логин
                    Console.WriteLine("Введите имя");
                    User.fName = Console.ReadLine();

                    Console.WriteLine("Введите фамилию");
                    User.lName = Console.ReadLine();

                    Console.WriteLine("Введите логин");
                    User.Login = Console.ReadLine();
                    User.LoginLength = User.Login.Length;

                    //животные истина
                    Console.WriteLine("Есть ли у вас животные? Да или Нет");
                    var meaning = Console.ReadLine();

                    if (meaning == "Да") ;
                    {
                        User.Pet = true;
                    }
                    if (meaning != "Да") ;
                    {
                        User.Pet = false;
                    }

                    //возраст любимые цвета
                    Console.WriteLine("Введите возраст пользователя");
                    User.Age = Convert.ToInt32(Console.ReadLine());

                    User.favColors = new string[3];
                    Console.WriteLine("Введите три любимых цвета пользователя");
                    for (int i = 0; i < User.favColors.Length; i++)
                    {
                        User.favColors[i] = Console.ReadLine();
                    }

                }
            }
        }
    }
}