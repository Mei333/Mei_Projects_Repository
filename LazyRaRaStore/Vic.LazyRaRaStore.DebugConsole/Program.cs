using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.LazyRaRaStore.Domain.Concrete;
using Vic.LazyRaRaStore.Domain.Entities;

namespace Vic.LazyRaRaStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {

                for (int i = 0; i < 20; i++)
                {
                    var product = new Product()
                    {
                        Name = "abc",
                        Description = "efg",
                        Category = "hij",
                        Price = 123,

                    };
                    ctx.Products.Add(product);
                }
                ctx.SaveChanges();
            }
        }
    }
}
