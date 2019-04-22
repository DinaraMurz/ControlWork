using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    public class Edition : Entity
    {
        public string Name { get; set; }
        public string Context { get; set; }

        public void CreateEdition()
        {
            Console.WriteLine("Введите название");
            Name = Console.ReadLine().ToString();


            Console.WriteLine("Введите содержание");
            Context = Console.ReadLine().ToString();
        }
    }
}
