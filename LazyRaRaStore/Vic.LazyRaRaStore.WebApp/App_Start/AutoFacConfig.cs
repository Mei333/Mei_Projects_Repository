using Autofac;
using Autofac.Integration.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.LazyRaRaStore.Domain.Abstract;
using Vic.LazyRaRaStore.Domain.Entities;
using Vic.LazyRaRaStore.Domain.Mock;

namespace Vic.LazyRaRaStore.WebApp
{
    public class AutoFacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            //#region moq library
            //Mock<IProductsRepository> mock = new Mock<IProductsRepository>();

            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //new Product { Name = "Football", Price = 25 },
            //new Product { Name = "Surf board", Price = 179 },
            //new Product { Name = "Running shoes", Price = 95 }
            //});

            //builder.RegisterInstance<IProductsRepository>(mock.Object);
            //#endregion

            #region mock class
            builder.RegisterInstance<IProductsRepository>(new MockProductRepository());
            #endregion

            builder.RegisterControllers(AppDomain.CurrentDomain.GetAssemblies());
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}