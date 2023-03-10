using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Entidades
{
    public class Nota
    {
        public int IdAulmno { get; set; }
        public int IdCurso { get; set; }
        public double Eva1 { get; set; }
        
        public double Parcial { get; set; }
        public double Eva2 { get; set; }
        public double Final { get; set; }
       
    }
}
