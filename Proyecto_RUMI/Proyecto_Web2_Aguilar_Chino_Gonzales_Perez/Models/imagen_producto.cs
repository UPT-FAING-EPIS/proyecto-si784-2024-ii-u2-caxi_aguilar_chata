namespace Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class imagen_producto
    {
        [Key]
        public int id_imagen { get; set; }

        public int? id_producto { get; set; }

        [Required]
        [StringLength(255)]
        public string url_imagen { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

		public bool es_principal { get; set; } = false;

        [StringLength(1)]
        public string estado { get; set; }

        public DateTime? fecha_subida { get; set; }

        public virtual producto producto { get; set; }


        public List<imagen_producto> Listar(int id)
        {
            var query = new List<imagen_producto>();
            try
            {
                using (var db = new ModeloSistema())
                {
                    query = db.imagen_producto.Where(x => x.estado == "A"
                    && x.id_producto == id).ToList();
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
