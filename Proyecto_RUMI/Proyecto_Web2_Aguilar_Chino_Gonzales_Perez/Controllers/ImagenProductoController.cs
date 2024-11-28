using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
	public class ImagenProductoController : Controller
	{
		private ModeloSistema db = new ModeloSistema();
		public ActionResult Index(int idProducto)
		{
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var imagenes = db.imagen_producto.Where(i => i.id_producto == idProducto).ToList();
			ViewBag.idProducto = idProducto;
			return View(imagenes);
		}

		public ActionResult Create(int id)
		{
			var imagen = new imagen_producto();
            ViewBag.Tipo = new SelectList(new[]
			{
				new { Value = "1", Text = "Principal" },
				new { Value = "0", Text = "Secundario" }
			}, "Value", "Text");
            imagen.id_producto = id;
			return View(imagen);
		}

        [HttpPost]
        public ActionResult Create(int id, imagen_producto imagen_Producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    imagen_Producto.estado = "A";
					imagen_Producto.id_producto = id;
					imagen_Producto.fecha_subida = DateTime.Now;
                    db.imagen_producto.Add(imagen_Producto);
                    db.SaveChanges();
                    TempData["Message"] = "La información fue guardada correctamente.";
                }
                return RedirectToAction("Details", "Producto", new { id = imagen_Producto.id_producto });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Details", "Producto", new { id = imagen_Producto.id_producto });
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            imagen_producto imagen = db.imagen_producto.Find(id);
			if (imagen == null)
			{
				return HttpNotFound();
			}
            ViewBag.Tipo = new SelectList(new[]
{
                new { Value = "1", Text = "Principal" },
                new { Value = "0", Text = "Secundario" }
            }, "Value", "Text");
            return View(imagen);
		}

        [HttpPost]
        public ActionResult Edit(imagen_producto imagen_Producto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(imagen_Producto).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    TempData["Message"] = "La información fue guardada correctamente.";
                }
                return RedirectToAction("Details", "Producto", new { id = imagen_Producto.id_producto });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Details", "Producto", new { id = imagen_Producto.id_producto });
            }
        }

        public ActionResult Delete(int? id)
		{
            try
            {
                imagen_producto imagen_producto = db.imagen_producto.Find(id);
                imagen_producto.estado = "I";
                db.Entry(imagen_producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "La información fue guardada correctamente.";
                return RedirectToAction("Details", "Producto", new { id = imagen_producto.id_producto });
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
		}
	}
}