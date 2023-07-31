using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace winform_app
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;

        public frmAltaDisco()
        {
            InitializeComponent();
        }

        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Disco disco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                if (disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento= dtpFechaLanza.Value;
                disco.CantidadCanciones=int.Parse(txtCantCanciones.Text);
                disco.UrlImagenTapa= txtUrlImagenTapa.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cboEdicion.SelectedItem;

                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }

                //guardo imagen si la levanto localmente:
                if (archivo != null && !(txtUrlImagenTapa.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                    Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";

                if (disco !=null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanza.Value = disco.FechaLanzamiento;
                    txtCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagenTapa.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                }
           

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtUrlImagenTapa_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagenTapa.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {

                pbxDisco.Load("https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagenTapa.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }


    }
}
