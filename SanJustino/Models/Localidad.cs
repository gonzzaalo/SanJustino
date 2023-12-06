using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJustino.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public  string CodigoPostal { get; set; }
        public int? ProvinciaId { get; set; }

        public Provincia Provincia { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
