using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        public frmDetalleArticulo( Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            cargarImagen(articulo.ImagenUrl);
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                txtId.Text = articulo.Id.ToString(); 
                txtCod.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDes.Text = articulo.Descripcion;
                txtMarca.Text = articulo.Marca.Descripcion;
                txtCategoria.Text = articulo.Categoria.Descripcion;
                txtImagen.Text = articulo.ImagenUrl;
                txtPrecio.Text = articulo.Precio.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)    //Método para cargar imagen ya sea por URL o una por defecto si no tiene nada
        {
            try
            {
                pbxArticuloDetalle.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticuloDetalle.Load("https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
