using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.LazyRaRaStore.Domain.Abstract;
using Vic.LazyRaRaStore.Domain.Entities;

namespace Vic.LazyRaRaStore.Domain.Mock
{
    public class  MockProductRepository : IProductsRepository
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product { Name = "Phone Case1", Description ="iPhone X Silicone Case - Black", Price = 15 },
                    new Product { Name = "fashion jewellery", Description ="Swarovski Crystal Fashion Necklace and Earrings set",Price = 125 },
                    new Product { Name = "Facial Masks", Description ="Vichy Aqualia Thermal Sleeping Mask", Price = 28 }
                };
            }
        }

    }
}
