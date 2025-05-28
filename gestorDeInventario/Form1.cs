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

namespace gestorDeInventario
{
    public partial class Form1 : Form
    {
        private List<Articulo> articuloList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();

        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                articuloList = articuloNegocio.listar();
                dgvArticulos.DataSource = articuloList;
                ocultarColumnas();
                Helper.cargarImagen(articuloList[0].ImagenUrl, pbxArticulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Helper.cargarImagen(seleccion.ImagenUrl, pbxArticulo);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo articuloDetallado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmDetalle frmDetalle = new FrmDetalle(articuloDetallado);
            frmDetalle.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloModificable = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmModificar frmModificar = new FrmModificar(articuloModificable);
            frmModificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar el articulo " + seleccionado.Nombre + " ?", "ATENCION!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (respuesta == DialogResult.Yes)
                {
                    articuloNegocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Articulo eliminado exitosamente");
                    cargar();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            if (txbBuscar.Text != "")
            {
                listaFiltrada = articuloList.FindAll(x => x.Nombre.ToUpper().Contains(txbBuscar.Text.ToUpper()));

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            else 
            {
                cargar();   
            }
               
            
        }

    }

}
