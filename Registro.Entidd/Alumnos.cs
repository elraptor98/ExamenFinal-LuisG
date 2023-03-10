using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Entidades
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Apellidos { get; set; }
       
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public string codigo_nombres
        {
            get
            {
                return this.Codigo + " " + this.Apellidos + " " +this.Nombres;
            }
        }

    }
}
