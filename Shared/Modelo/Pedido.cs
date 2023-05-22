using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Shared.Modelo
{
    public class Pedido
    {
        [Required(ErrorMessage = "El número de orden no puede ser vacío")]
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre no puede ser vacío"), MaxLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un número de contacto"), MaxLength(10)]
        public string? Teléfono { get; set; }

        [Required(ErrorMessage = "Debe proporcionar la fecha de creación")]
        public string? Fecha { get; set; }
    }
}
