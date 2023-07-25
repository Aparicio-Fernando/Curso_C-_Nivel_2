using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista=new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE E.Id=D.IdEstilo AND T.Id=D.IdTipoEdicion and D.Activo=1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];

                    if(!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];


                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)lector["IdTipoEdicion"];
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

        public void agregar (Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) VALUES (@Titulo, @FechaLanzamiento, @CantidadCanciones,@IdEstilo, @IdTipoEdicion, @UrlImagenTapa)");
                datos.setearParametro("@Titulo", nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@CantidadCanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Edicion.Id);
                datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagenTapa);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Disco disk)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE DISCOS Set Titulo=@titulo, FechaLanzamiento=@fechaLanza,CantidadCanciones=@cant, UrlImagenTapa=@img,IdEstilo=@IdEstilo, IdTipoEdicion=@IdEdicion WHERE Id = @Id");
                datos.setearParametro("@titulo", disk.Titulo);
                datos.setearParametro("@fechaLanza", disk.FechaLanzamiento);
                datos.setearParametro("@cant", disk.CantidadCanciones);
                datos.setearParametro("@img", disk.UrlImagenTapa);
                datos.setearParametro("@IdEstilo", disk.Estilo.Id);
                datos.setearParametro("@IdEdicion", disk.Edicion.Id);
                datos.setearParametro("@Id", disk.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminarFisico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM DISCOS WHERE Id=@Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("UPDATE DISCOS SET Activo = 0 Where Id=@Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List <Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE E.Id=D.IdEstilo AND T.Id=D.IdTipoEdicion and D.Activo=1 And ";

                if (campo == "Cantidad Canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "D.CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "D.CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "D.CantidadCanciones = " + filtro;
                            break;
                    }
                }

                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "D.Titulo like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "D.Titulo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "D.Titulo like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];


                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
