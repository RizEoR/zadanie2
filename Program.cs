using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pol
{
    class Program
    {
        static void Main()
        {
            User user = new User();
            {
                


            };
            Console.WriteLine(" Введите фамилию");
            user.famil = Console.ReadLine();
            Console.WriteLine(" Введите имя");
            user.name = Console.ReadLine();
            Console.WriteLine(" Введите логин");
            user.login = Console.ReadLine();
            Console.WriteLine(" Введите пароль (цифры!)");
            user.password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n " + "\n " + "вы вели");
            Console.WriteLine("\n " + " фамилия =" + user.famil);
            Console.WriteLine("\n " + " имя =" + user.name);
            Console.WriteLine("\n " + " логин=" +  user.login);
            Console.WriteLine("\n " + " пароль =" + user.password);
            Console.WriteLine("войди?");
            Console.WriteLine("\n");
            string  otvet = Console.ReadLine();
            if (otvet=="yes")
            {
                user.AAA(user.login, user.password);

            }
            else {
                Main();
            }

            
        }
    }

    class User
    {
        public string famil;
        public string name;

        public string login;
        public int password;

        public void AAA(string login, int password)
        {
            int pas = 111;
            if (login == "lll" && password == pas)
            {
                Console.WriteLine("\n" +  "\\ успех \\");
            }
            else
            {
                Console.WriteLine("\n"+ " \\Не правильный логин или пароль\\");
            }
        }
      
    }
}