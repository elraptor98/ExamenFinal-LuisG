using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.data
{
    public class UtilDB
    {
        public static string CadenaConexion()
        {
            string cadenaConexion = @"Server = localhost; DataBase = Academia; Integrated Security=true"; //*User = AppData; Password = Data";

            return cadenaConexion;
        }
    }
}
