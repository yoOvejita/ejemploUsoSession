using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNET04.Models;

namespace ASPNET04.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            ProductoModelo prodModelo = new ProductoModelo();
            ViewBag.productos = prodModelo.GetTodo();
            return View();
        }
    }
}