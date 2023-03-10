using Registro.data;
using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.negocio
{
    public class NotasBL
    {
        public static bool Insertar(Nota nota)
        {
            var notasDB = new NotasDB();
            return notasDB.Insertar(nota) > 0;
        }
    }
}
