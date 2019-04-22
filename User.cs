using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{

    public class User : Entity
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public int Money { get; set; }

        public string Address { get; set; }

        public DateTime Since { get; set; }

        public virtual Subscribe Subscribe { get; set; }

        public void Registrait()
        {
            using (var context = new DataContext())
            {
                Console.WriteLine("Введите логин: ");
                Login = Console.ReadLine().ToString();
                for (int i = 1; i == 0;)
                {
                    Console.WriteLine("Введите пароль: ");
                    Password = Console.ReadLine().ToString();
                    Console.WriteLine("Повторите пароль: ");
                    if (Password == Console.ReadLine().ToString())
                        i = 0;
                    else
                        Console.WriteLine("Пароли не совпадают, повторите опирацию");
                }
                Console.WriteLine("Введите адрес: ");
                Address = Console.ReadLine().ToString();

                for (int i = 1; i == 0;)
                {
                    Console.WriteLine("Введите ваше количество денег: ");
                    string input = Console.ReadLine();
                    int money;
                    if (Int32.TryParse(input, out money))
                        i = 0;
                    else
                        Console.WriteLine("Введино не верное число, повторите попытку");
                }

                Console.WriteLine("Выбирете подписку: ");


                Since = DateTime.Today;
            }
        }

        public void Pay()
        {
            Money = Money - Subscribe.Cost;
        }

        void CancelSubscribe()
        {
            Subscribe = null;
        }
    }
}
