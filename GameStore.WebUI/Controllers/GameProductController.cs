using GameStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    public class GameProductController : Controller
    {
        private IGameRepository repository;
        public int PageSize = 2;

        public GameProductController(IGameRepository productRepository) 
        {
            this.repository = productRepository;
        }

        public ViewResult List(int page = 1)
        {
            return View(repository.Products.OrderBy(p => p.ProductID).Skip((page-1)*PageSize).Take(PageSize));
        } 
    }
}