using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Libro
    {
        [Key]
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public string autor { get; set; }
        public int pagina { get; set; }
        public string descripcion { get; set; }
    }
}
