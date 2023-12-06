using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJustino.Models
{
    public class Deportista
    {
        internal object Provincia;

        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public int? LocalidadId  { get; set; }
        public Localidad Localidad { get; set; }

        public int? ProvinciaId { get; set; }
        public Provincia provincia { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
