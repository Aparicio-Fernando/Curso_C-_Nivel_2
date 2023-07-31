using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> listar ()   //creo un metodo que me devuelve una lista de los estilos
        {
			List<Estilo> lista = new List<Estilo>();
			AccesoDatos datos = new AccesoDatos ();

			try
			{
				datos.setearConsulta("SELECT Id, Descripcion FROM ESTILOS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
                    Estilo aux = new Estilo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (String)datos.Lector["Descripcion"];

					lista.Add(aux);

                }

                return lista;
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
    }
}
