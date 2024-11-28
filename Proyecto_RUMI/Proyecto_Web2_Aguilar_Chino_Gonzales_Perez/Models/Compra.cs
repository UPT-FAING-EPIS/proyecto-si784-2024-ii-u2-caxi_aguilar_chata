namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Compra")]
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
        }
        public class VentasPorMes
        {
            public int Año { get; set; }
            public int Mes { get; set; }
            public decimal TotalVentas { get; set; }
        }


        [Key]
        public int id_compra { get; set; }

        public int? id_usuario { get; set; }

        public DateTime? fecha_compra { get; set; }

        public string fecha_formateada => fecha_compra.HasValue? fecha_compra.Value.ToString("dd MMM yyyy, hh:mm tt") : string.Empty;

        public decimal? total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }

        public List<VentasPorMes> ListarVentasPorMes()
        {
            var query = new List<VentasPorMes>();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.Compra
                              .Where(c => c.fecha_compra.HasValue)
                              .GroupBy(c => new { c.fecha_compra.Value.Year, c.fecha_compra.Value.Month })
                              .Select(g => new VentasPorMes
                              {
                                  Año = g.Key.Year,
                                  Mes = g.Key.Month,
                                  TotalVentas = g.Sum(c => c.total ?? 0)
                              })
                              .OrderBy(v => v.Año)
                              .ThenBy(v => v.Mes)
                              .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return query;
        }

        public List<Compra> Listar()
        {
            var query = new List<Compra>();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.Compra.Include("DetalleCompra")
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return query;
        }

        public Compra Obtener(int id)
        {
            var query = new Compra();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.Compra.Include("DetalleCompra")
                        .Include("DetalleCompra.Producto")
                        .Where(x => x.id_compra == id)
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
