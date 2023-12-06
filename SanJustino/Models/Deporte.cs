using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanJustino.Models
{
    public class Deporte
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Horarios { get; set; }
        public int? ProfesorId { get; set; }
        public Profesor Profesor { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
