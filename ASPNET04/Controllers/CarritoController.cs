using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNET04.Models;

namespace ASPNET04.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Compra(string id)
        {
            ProductoModelo prodM = new ProductoModelo();
            if (Session["carrito"] == null)
            {
                List<Item> carro = new List<Item>();
                carro.Add(new Item { Producto = prodM.Get(id), Cantidad = 1 });
                Session["carrito"] = carro;
            }
            else {
                List<Item> carro = (List<Item>)Session["carrito"];
                int indice = Existe(id);
                if (indice != -1) {
                    carro[indice].Cantidad++;
                }
                else
                {
                    carro.Add(new Item { Producto = prodM.Get(id), Cantidad = 1});
                }
                Session["carrito"] = carro;
            }
            return RedirectToAction("Index");
        }
        private int Existe(string id) {
            List<Item> carro = (List<Item>)Session["carrito"];
            for (int i = 0; i < carro.Count; i++) {
                if (carro[i].Producto.Id == id)
                    return i;
            }
            return -1;
        }
        public ActionResult Borrar(string id) {
            List<Item> carro = (List<Item>)Session["carrito"];
            int indice = Existe(id);
            carro.RemoveAt(indice);
            Session["carrito"] = carro;
            return RedirectToAction("Index");
        }
    }
}