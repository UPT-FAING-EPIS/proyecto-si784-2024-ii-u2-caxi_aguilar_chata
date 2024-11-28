using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class UserController : Controller
    {
        private ModeloSistema db = new ModeloSistema();
        private usuario objUsuario = new usuario();

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var usuarios = objUsuario.Listar();
            return View(usuarios);
        }

        public ActionResult Create()
        {
            ViewBag.TipoUsuarioList = new SelectList(db.tipo_usuario
                .ToList(), "id_tipo_usuario", "tipo");
            return View();
        }

        [HttpPost]
        public ActionResult Create(usuario usuario)
        {
            try
            {
                string accion = "Index";
                if (ModelState.IsValid)
                {
                    if (usuario.saldo > 0)
                    {
                        usuario.estado = "A";
                        db.usuarios.Add(usuario);
                        db.SaveChanges();
                        TempData["Message"] = "La información fue guardada correctamente.";
                    } else
                    {
                        TempData["ErrorMessage"] = "El saldo no puede ser negativo.";
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
            usuario user = db.usuarios.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoUsuarioList = new SelectList(db.tipo_usuario.ToList(), "id_tipo_usuario", "tipo", user.tipo_usuario);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(usuario usuario)
        {
            try
            {
                string accion = "Index";
                if (ModelState.IsValid)
                {
                    if (usuario.saldo > 0)
                    {
                        db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        TempData["Message"] = "La información fue guardada correctamente.";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "El saldo no puede ser negativo.";
                        accion = "Edit/" + usuario.id_usuario;
                    }
                }
                return RedirectToAction(accion);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Revise si la información es correcta.";
                return RedirectToAction("Edit/"+ usuario.id_usuario);
            }
        }

        public ActionResult Delete(int? id)
        {
            try
            {
                usuario user = db.usuarios.Find(id);
                user.estado = "I";
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
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
