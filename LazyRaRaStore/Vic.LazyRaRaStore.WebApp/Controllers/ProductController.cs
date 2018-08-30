using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.LazyRaRaStore.Domain.Abstract;

namespace Vic.LazyRaRaStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public int PageSize = 2;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List(int page = 1)
        {
            return View(
                repository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize )
                .Take(PageSize));
        }
    }
}