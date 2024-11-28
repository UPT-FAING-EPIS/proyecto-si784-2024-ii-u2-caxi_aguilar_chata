using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models.Compra;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class pruebaController : Controller
    {
        // GET: prueba
        private usuario obj = new usuario();
        private producto objp = new producto();
        private Compra objCompra = new Compra();
        public ActionResult Index()
        {
            //--------------------------------------------------------------------------------------------
            List<usuario> listu = obj.Listar().OrderBy(u => u.saldo).Take(5).OrderBy(u => u.id_usuario)
                      .ToList();
            ViewBag.usuario = listu;
            //--------------------------------------------------------------------------------------------
            List<producto.ProductoMasVendido> listp = objp.ListarProductosMasVendidos();
            ViewBag.s = listp;         
            //--------------------------------------------------------------------------------------------          
            List<Compra.VentasPorMes> ventasPorMes = objCompra.ListarVentasPorMes();
            var ventasPorMesData = ventasPorMes.Select(v => new { Año = v.Año, Mes = v.Mes, TotalVentas = v.TotalVentas }).ToList();
            ViewBag.ventasPorMesData = Newtonsoft.Json.JsonConvert.SerializeObject(ventasPorMesData);
            //-------------------------------------------------------------------------------------------------
            decimal totalSaldo = obj.TotalSaldo();
            ViewBag.totalSaldo = totalSaldo;
            //-------------------------------------------------------------------------------------------------

            return View();
        }
        
    }
}