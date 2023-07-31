using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using System.Globalization;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        } 
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)   //Método para "Agregar" o "Modificar" el Art al apretar "btnAceptar"
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarAgregar())
                {
                    if (articulo == null)
                        articulo = new Articulo();

                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.ImagenUrl = txtImagen.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.Marca = (Marca)cboMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                    if (articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {

                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");
                    }
                }
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }   // Método para cerrar en caso de "Cancelar"

        private void frmAltaArticulo_Load(object sender, EventArgs e)   //Método para que cague los items en "cbx" o los datos del Art. seleccionado en caso de modif.
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl; 
                    txtPrecio.Text = articulo.Precio.ToString("N2");
                    cargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;                    
                }            

                // Alinear el TextBox del precio a la derecha
                txtPrecio.TextAlign = HorizontalAlignment.Right;

                // Cambiar la configuración regional para que use punto (".") como separador de decimales y sin separador de miles
                CultureInfo culture = new CultureInfo("en-US");
                culture.NumberFormat.NumberDecimalSeparator = ".";
                culture.NumberFormat.NumberGroupSeparator = string.Empty; // Sin separador de miles
                culture.NumberFormat.CurrencyDecimalSeparator = ".";
                culture.NumberFormat.CurrencyGroupSeparator = string.Empty; // Sin separador de miles
                System.Threading.Thread.CurrentThread.CurrentCulture = culture;
                System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

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
                pbxArticuloAlta.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticuloAlta.Load("https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)    //Método para que se cargue imagen al salir del cuadro de texto "txtImagen"
        {
            cargarImagen(txtImagen.Text);
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool validarAgregar()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código por favor");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese Nombre por favor");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un valor a Precio por favor");
                return false;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Ingrese número por favor");
                return false;
            }
            return true;
        }
    }
}
