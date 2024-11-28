using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
	public class ProductoController : Controller
	{
        private ModeloSistema db = new ModeloSistema();
        private producto objProducto = new producto();
        private imagen_producto objImagenProducto = new imagen_producto();

        public ActionResult Index()
		{
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var productos = objProducto.ListarTodos();
            return View(productos);
        }

        public ActionResult Details(int id)
        {
            var imagenes = objImagenProducto.Listar(id);
            return View(imagenes);
        }

        public ActionResult Create()
        {
            var nuevoProducto = new producto();
            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Create(producto producto)
        {
            try
            {
                string accion = "Index";
                if (ModelState.IsValid)
                {
                    if (producto.precio > 0 && producto.stock > 0)
                    {
                        producto.estado = "A";
                        producto.fecha_creacion = DateTime.Now;
                        db.producto.Add(producto);
                        db.SaveChanges();
                        TempData["Message"] = "La información fue guardada correctamente.";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Revise si la información es correcta.";
                        accion = "Create";
                    }
                }
                return RedirectToAction(accion);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Create");
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = db.producto.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(producto producto)
        {
            try
            {
                string accion = "Index";
                if (ModelState.IsValid)
                {
                    if (producto.precio > 0 && producto.stock > 0)
                    {
                        db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        TempData["Message"] = "La información fue guardada correctamente.";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Revise si la información es correcta.";
                        accion = "Edit/" + producto.id_producto;
                    }
                }
                return RedirectToAction(accion);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Edit/" + producto.id_producto);
            }
        }

        public ActionResult Delete(int? id)
        {
            try
            {
                producto producto = db.producto.Find(id);
                producto.estado = "I";
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "La información fue guardada correctamente.";
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
	}
}