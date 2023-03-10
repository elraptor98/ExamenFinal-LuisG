using Registro.data;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.negocio
{
    public class CursosBL
    {
        public static List<Cursos> Listar()
        {
            var tipoClienteBD = new CurosDB();
            return tipoClienteBD.Listar();
        }
    }
}
