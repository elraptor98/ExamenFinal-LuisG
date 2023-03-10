using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.data
{
    public class NotasDB
    {
        public List<Nota> Listar() //en este se hara lo de eliminar clientes, buscar clientes,etc.(video clase 8)
        {
            var listado = new List<Nota>();

            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Notas", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Nota nota;
                            while (lector.Read())
                            {
                                // CREAR UN NUEVO OBJETO CLIENTE
                                nota = new Nota();
                                nota.IdAulmno = (int)lector["IdAulmno"];
                                nota.IdCurso = (int)lector["IdCurso"];
                                nota.Eva1 = (double)lector["Eva1"];
                                nota.Parcial = (double)lector["Parcial"];
                                nota.Eva2 = (double)lector["Eva2"];
                                nota.Final = (double)lector["Final"];



                               
                                listado.Add(nota);
                            }
                        }
                    }
                }
            }
            return listado;
        }
        public int Insertar(Nota nota)
        {
            int filas = 0;
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                var query = "INSERT INTO [dbo].[Notas] " +
                    "([IdAulmno],[IdCurso],[Eva1],[Parcial],[Eva2]," +
                    "[Final]" +
                    "VALUES(@idalumno,@idcurso,@eva1,@parcial,@eva2,@final";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idalumno", nota.IdAulmno);
                    comando.Parameters.AddWithValue("@idcurso", nota.IdCurso);
                    comando.Parameters.AddWithValue("@eva1", nota.Eva1);
                    comando.Parameters.AddWithValue("@parcial", nota.Parcial);
                    comando.Parameters.AddWithValue("@eva2", nota.Eva2);
                    comando.Parameters.AddWithValue("@final", nota.Final);
                    
                    filas = comando.ExecuteNonQuery();
                }
            }
            return filas;
        }

    }
}
