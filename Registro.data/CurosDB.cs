using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.data
{
    public class CurosDB
    {
        public List<Cursos> Listar()
        {
            var listado = new List<Cursos>();
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Cursos", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Cursos tipo;
                            while (lector.Read())
                            {
                                tipo = new Cursos()
                                {
                                    Id = int.Parse(lector["ID"].ToString()),
                                    Nombre = lector["Nombre"].ToString()
                                };
                                listado.Add(tipo);
                            }
                        }
                    }
                }
            }

            return listado;
        }
    }
}
