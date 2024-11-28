using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class OrdenController : Controller
    {
        private ModeloSistema db = new ModeloSistema();
        private Compra objCompra = new Compra();

        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var compras = objCompra.Listar();
            return View(compras);
        }

        public ActionResult Details(int id)
        {
            var compra = objCompra.Obtener(id);
            return View(compra);
        }
    }
}