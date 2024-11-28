namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("carrito")]
    public partial class carrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carrito()
        {
            detalle_carrito = new HashSet<detalle_carrito>();
        }

        [Key]
        public int id_carrito { get; set; }

        public int? id_usuario { get; set; }

        public DateTime? fecha_creacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_carrito> detalle_carrito { get; set; }


        public carrito Listar(int id)
        {
            var query = new carrito();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.carrito.Include("detalle_carrito")
                        .Where(x => x.id_usuario == id)
                        .SingleOrDefault();

                    if (query == null)
                    {
                        return new carrito();
                    }
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
