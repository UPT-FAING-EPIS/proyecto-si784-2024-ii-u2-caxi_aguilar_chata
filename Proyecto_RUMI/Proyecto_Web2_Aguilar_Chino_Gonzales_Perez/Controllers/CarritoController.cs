using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class CarritoController : Controller
    {
        private ModeloSistema db = new ModeloSistema();
        private carrito objCarrito = new carrito();
        private detalle_carrito objDetalleCarrito = new detalle_carrito();

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var carrito = objCarrito.Listar((int)Session["UserID"]);
            var detalleCarrito = objDetalleCarrito.Listar(carrito.id_carrito);
            return View(detalleCarrito);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var userId = (int)Session["UserID"];
                var carrito = objCarrito.Listar(userId);
                var detalleCarrito = db.detalle_carrito.FirstOrDefault(dc => dc.id_carrito == carrito.id_carrito && dc.id_producto == id);

                if (detalleCarrito != null)
                {
                    db.detalle_carrito.Remove(detalleCarrito);
                    db.SaveChanges();
                    TempData["Message"] = "Detalle de carrito eliminado correctamente.";
                }
                else
                {
                    TempData["ErrorMessage"] = "El detalle de carrito no fue encontrado.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error al intentar eliminar el detalle de carrito.";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Pay(decimal total)
        {
            try
            {
                var userId = (int)Session["UserID"];
                using (var db = new ModeloSistema())
                {
                    var carrito = objCarrito.Listar(userId);
                    var detalleCarrito = objDetalleCarrito.Listar(carrito.id_carrito);
                    foreach (var item in detalleCarrito)
                    {
                        var detalle = db.detalle_carrito.FirstOrDefault(dc => dc.id_carrito == carrito.id_carrito && dc.id_producto == item.id_producto);

                        if (detalle != null)
                        {
                            producto producto = db.producto.Find(item.id_producto);
                            if (item.cantidad > producto.stock)
                            {
                                return RedirectToAction("Index");
                            }
                            producto.stock -= item.cantidad;
                            db.Entry(producto).State = EntityState.Modified;
                            db.detalle_carrito.Remove(detalle);
                        }
                    }
                    db.SaveChanges();
                    carrito carro = db.carrito.Find(carrito.id_carrito);
                    db.carrito.Remove(carro);

                    usuario usuario = db.usuarios.Find(userId);
                    usuario.saldo -= total;
                    db.Entry(usuario).State = EntityState.Modified;
                    db.SaveChanges();

                    var compra = new Compra
                    {
                        id_usuario = userId,
                        fecha_compra = DateTime.Now,
                        total = total
                    };
                    db.Compra.Add(compra);
                    db.SaveChanges();

                    foreach (var item  in detalleCarrito)
                    {
                        var detalleCompra = new DetalleCompra
                        {
                            id_compra = compra.id_compra,
                            id_producto = item.id_producto,
                            cantidad = item.cantidad,
                            precio = item.producto.precio,
                        };
                        db.DetalleCompra.Add(detalleCompra);
                    }

                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error al procesar el pago: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}