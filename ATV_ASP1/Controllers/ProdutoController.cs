using ATV_ASP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATV_ASP1.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }
        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", produto);
            }
            return View(produto);
        }
        public ActionResult Resultado()
        {
            return View();
        }
    }
}