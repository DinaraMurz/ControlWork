using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        private List<Subscribe> subscribes;

        public DataInitializer()
        {
            subscribes = new List<Subscribe>
            {
                new Subscribe
                {
                    Name = "No Subscribe",
                    Cost = 0,
                    DurationInMonth = 0
                },
                new Subscribe
                {
                    Name = "12 месяцев",
                    Cost = 1290,
                    DurationInMonth = 12
                },
                new Subscribe
                {
                    Name = "24 месяцев",
                    Cost = 2290,
                    DurationInMonth = 24
                },
                new Subscribe
                {
                    Name = "36 месяцев",
                    Cost = 3690,
                    DurationInMonth = 36
                }
            };
        }
        protected override void Seed(DataContext context)
        {
            context.Subscribes.AddRange(subscribes);
            context.SaveChanges();
        }
    }
}
