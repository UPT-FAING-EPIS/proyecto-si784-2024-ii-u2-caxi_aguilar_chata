namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class detalle_carrito
    {
        [Key]
        public int id_detalle_carrito { get; set; }

        public int? id_carrito { get; set; }

        public int? id_producto { get; set; }

        public int cantidad { get; set; }

        public virtual carrito carrito { get; set; }

        public virtual producto producto { get; set; }


        public List<detalle_carrito> Listar(int id)
        {
            var query = new List<detalle_carrito>();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.detalle_carrito.Include("carrito")
                        .Include("producto").Where(x => x.id_carrito == id)
                        .ToList();

                    foreach (var detalle in query)
                    {
                        db.Entry(detalle.producto)
                            .Collection(p => p.imagen_producto)
                            .Load();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return query;
        }

        public detalle_carrito Obtener(int id_carrito, int idProducto)
        {
            var query = new detalle_carrito();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.detalle_carrito.Include("carrito")
                        .Include("producto").Where(x => x.id_carrito == id_carrito
                            && x.id_producto == idProducto)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return query;
        }
    }
}
