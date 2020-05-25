using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET04.Models
{

    public class ProductoModelo
    {
        private List<Producto> productos;
        public ProductoModelo() {
            productos = new List<Producto>() {
                new Producto {
                    Id = "prod01",
                    Nombre = "Nombre producto 01",
                    Precio = 23.5,
                    Foto = "p1.jpg"
                },
                new Producto {
                    Id = "prod02",
                    Nombre = "Nombre producto 02",
                    Precio = 54.7,
                    Foto = "p2.jpg"
                },
                new Producto {
                    Id = "prod03",
                    Nombre = "Nombre producto 03",
                    Precio = 10,
                    Foto = "p3.jpg"
                }
            };
        }
        public List<Producto> GetTodo() {
            return productos;
        }
        public Producto Get(string id) {
            return productos.Single(x => x.Id == id);
        }
    }
}