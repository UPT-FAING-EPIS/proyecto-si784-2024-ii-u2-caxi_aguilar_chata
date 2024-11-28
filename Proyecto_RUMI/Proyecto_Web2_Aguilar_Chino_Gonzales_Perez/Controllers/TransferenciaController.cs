using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;

namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers
{
    public class TransferenciaController : Controller
    {
        private transferencia objTransferencia = new transferencia();
        // GET: Transferencia
        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            int userID = Convert.ToInt32(Session["UserID"]);
            string username = Session["Username"] as string;
            string usertype = Session["Usertype"] as string;
            double saldo = Convert.ToDouble(Session["Saldo"]);

            ViewBag.Username = username;
            ViewBag.Saldo = saldo;

            return View();

        }

        public ActionResult ListarTransferencias()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            int userId = Convert.ToInt32(Session["UserID"]);
            List<transferencia.TransferenciaResult> transferenciaResults = objTransferencia.ListaTransferencia(userId);

            return View(transferenciaResults);
        }

        public ActionResult DetalleTransferencia(int id)
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(objTransferencia.Detalle(id));
        }

        [HttpGet]
        public ActionResult Transferir()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.UserId = Session["UserID"];
            return View();
        }

        [HttpPost]
        public ActionResult Transferir(int IdReceptor, decimal Cantidad)
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            try
            {
                using (var db = new ModeloSistema())
                {
                    int idEmisor = (int)Session["UserID"];
                    var emisor = db.usuarios.SingleOrDefault(u => u.id_usuario == idEmisor);
                    int totalTransferencias = 0;
                    var transferencias = objTransferencia.ListaTransferencia(idEmisor);
                    foreach (var item in transferencias)
                    {
                        if(idEmisor == item.IdEmisor)
                        {
                            totalTransferencias++;
                        }
                    }
                    if (totalTransferencias > emisor.limite_transferencias)
                    {
                        TempData["ErrorMessage"] = "Se ha superado el límite de transferencias.";
                        return RedirectToAction("Transferir");
                    }

                    var receptor = db.usuarios.SingleOrDefault(u => u.id_usuario == IdReceptor);

                    if (receptor == null)
                    {
                        TempData["ErrorMessage"] = "Receptor no encontrado.";
                        return RedirectToAction("Transferir");
                    }

                    if (IdReceptor == idEmisor)
                    {
                        TempData["ErrorMessage"] = "El usuario no es válido.";
                        return RedirectToAction("Transferir");
                    }

                    if (emisor.saldo < Cantidad)
                    {
                        TempData["ErrorMessage"] = "Saldo insuficiente.";
                        return RedirectToAction("Transferir");
                    }

                    if (Cantidad < 0)
                    {
                        TempData["ErrorMessage"] = "Monto de transferencia inválido.";
                        return RedirectToAction("Transferir");
                    }

                    var transferencia = new transferencia
                    {
                        id_emisor = emisor.id_usuario,
                        id_receptor = IdReceptor,
                        cantidad = Cantidad,
                        estado = 1,
                        fecha = DateTime.Now
                    };

                    db.transferencias.Add(transferencia);

                    emisor.saldo -= Cantidad;
                    receptor.saldo += Cantidad;

                    db.SaveChanges();
                }

                TempData["SuccessMessage"] = "Transferencia realizada con éxito.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error al realizar la transferencia: " + ex.Message;
            }

            return RedirectToAction("Transferir");
        }

    }
}