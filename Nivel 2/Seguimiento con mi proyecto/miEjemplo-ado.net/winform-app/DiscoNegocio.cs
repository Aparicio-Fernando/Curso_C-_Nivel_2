using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace winform_app
{
    internal class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista=new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Edicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE E.Id=D.IdEstilo AND T.Id=D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Descripcion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
