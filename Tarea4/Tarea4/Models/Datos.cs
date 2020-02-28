using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea4.Models
{
    public class Datos
    {

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellido { get; set; }
        [Range(15, 90, ErrorMessage = "Debes ser mayor de 15 años")]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Formato incorrecto")]
        public string Email { get; set; }
        public genero Genero { get; set; }
        public puesto Puesto { get; set; }

    }

    public enum genero
    {
        Masculino, Femenino
    }
    public enum puesto
    {
        Desarrollador, Analista, Diseñador, Secretario
    }
}