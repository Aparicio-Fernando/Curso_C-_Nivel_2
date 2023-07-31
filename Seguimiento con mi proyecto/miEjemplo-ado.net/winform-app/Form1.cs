using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmDiscos : Form
    {
        private List<Disco> listaDisco;
        private List<Estilo> listaEstilo;
        public frmDiscos()
        {
            InitializeComponent();
        }

        
        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Cantidad Canciones");
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        private void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                listaDisco = negocio.listar();
                dgvDiscos.DataSource = listaDisco;
                ocultarColumna();
                cargarImagen(listaDisco[0].UrlImagenTapa);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumna()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmAltaDisco modificar = new frmAltaDisco(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
              

        private void btnEliminacionFisica_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminacionLogica_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad quieres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por seleccione el campo para filtrar");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por seleccione el criterio para filtrar");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar numero");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo número por favor");
                    return true;
                }
            }
            return false;
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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.Text.ToString();
                string criterio = cboCriterio.Text.ToString();                
                string filtro = txtFiltroAvanzado.Text.ToString();                
                dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrados;
            string filtro = txtFiltro.Text;

            if (filtro.Length >=3)
                listaFiltrados = listaDisco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrados = listaDisco;

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrados;
            ocultarColumna();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Cantidad Canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
