using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _1967955_002_PWEB_Clase.Models
{
    public class Productos
    {
        [StringLength(50)]
        public string Articulo { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        [StringLength(500)]
        public string Imagen { get; set; }
        public int ID { get; set; }
    }
}
