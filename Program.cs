using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isProgramOn = true;
            while (isProgramOn)
            {
                Console.WriteLine("Кто вы\n" +
                    "1.Клиент\n" +
                    "2.Издатнель");
                int answer;
                string input = Console.ReadLine();
                bool isInt = int.TryParse(input, out answer);

                if (!isInt)
                {
                    continue;
                }
                answer = int.Parse(input);

                //switch (answer)
                //{
                //    case 1:
                //        var user = new User();
                //        user.Registrait()
                //        break;
                //    case 2:
                //        break;
                //    default:
                //        continue;
                //        break;
                //}
                Console.WriteLine("Введите логин: ");

            }
        }
    }
}
