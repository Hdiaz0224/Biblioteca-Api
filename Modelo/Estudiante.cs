using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
    }
}