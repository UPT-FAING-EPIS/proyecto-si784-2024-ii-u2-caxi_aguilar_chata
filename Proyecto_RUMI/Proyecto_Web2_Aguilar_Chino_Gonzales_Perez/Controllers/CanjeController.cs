using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class CanjeController : Controller
    {
        private ModeloSistema db = new ModeloSistema();
        private producto objProducto = new producto();

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var productos = objProducto.Listar();
            return View(productos);
        }

        public ActionResult Details(int? id)
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var producto = objProducto.Obtener(id.Value);
            return View(producto);
        }

        public ActionResult Add(int? id)
        {
            try
            {
                int userId = (int)Session["UserID"];
                var carritoExistente = db.carrito
                    .FirstOrDefault(c => c.id_usuario == userId);

                if (carritoExistente == null)
                {
                    var carritoNuevo = new carrito
                    {
                        id_usuario = userId,
                        fecha_creacion = DateTime.Now
                    };
                    db.carrito.Add(carritoNuevo);
                    db.SaveChanges();
                    carritoExistente = carritoNuevo;
                }

                var detalleExistente = db.detalle_carrito
                    .FirstOrDefault(d => d.id_carrito == carritoExistente.id_carrito && d.id_producto == id);

                if (detalleExistente != null)
                {
                    detalleExistente.cantidad += 1;
                }
                else
                {
                    db.detalle_carrito.Add(new detalle_carrito
                    {
                        id_carrito = carritoExistente.id_carrito,
                        id_producto = id.Value,
                        cantidad = 1
                    });
                }
                db.SaveChanges();
                TempData["Message"] = "Producto agregado al carrito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Create");
            }
        }
    }
}