using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrograIILaboratorioII.Dominio
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PersonaId { get; set; }
           
        public string NombrePersona { get; set; }
            [Display(Name = "Descripcion")]
            [Required(ErrorMessage = "Este Campo Es Obligatorio")]

        public int EdadPersona { get; set; }
           [Display(Name =  "Descripcion")]
           [Required(ErrorMessage = "Este Campo Es Obligatorio")]

        public string DescripsionPersona { get; set; }
    }
}
