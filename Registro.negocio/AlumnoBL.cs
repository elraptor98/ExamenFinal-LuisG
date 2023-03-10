using Registro.data;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.negocio
{
    public class AlumnoBL
    {
        public static List<Alumnos> Listar()
        {
            var AlumnoBD = new AlumnoDB();
            return AlumnoBD.Listar();
        }
    }
}
