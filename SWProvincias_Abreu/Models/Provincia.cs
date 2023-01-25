using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SWProvincias_Abreu.Models
{
    public class Provincia
    {
        [Key]
        public int IdProvincia {get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

      
        public List<Ciudad> Cidudades { get; set; }
    }
}
