﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vic.LazyRaRaStore.Domain.Abstract;
using Vic.LazyRaRaStore.Domain.Entities;
using Vic.LazyRaRaStore.WebApp.Controllers;

namespace Vic.LazyRaRaStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            // Arrange
            /*
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
                });
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            // Act
            var result = (IEnumerable<Product>)controller.List(2).Model;
            // Assert
            Product[] prodArray = result.ToArray();
            Assert.IsTrue(prodArray.Length == 2);
            Assert.AreEqual(prodArray[0].Name, "P4");
            Assert.AreEqual(prodArray[1].Name, "P5");
            */
        }
    }
}
