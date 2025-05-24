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
    public partial class frmAgregar : Form
    {
        Articulo modificable = null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxAddCat.DataSource = categoriaNegocio.listar();
                cbxAddMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Articulo articuloNuevo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            articuloNuevo.Codigo = txbAddCodigo.Text;
            articuloNuevo.Nombre = txbAddNombre.Text;
            articuloNuevo.Descripcion = txbAddDescrip.Text;
            articuloNuevo.Marca = (Marca)cbxAddMarca.SelectedItem;
            articuloNuevo.Categoria = (Categoria)cbxAddCat.SelectedItem;
            articuloNuevo.ImagenUrl = txbAddImagen.Text;
            articuloNuevo.Precio = Convert.ToDecimal(txbAddPrecio.Text);

            try
            {
                articuloNegocio.agregar(articuloNuevo);
                MessageBox.Show("Articulo agregado exitosamente");
                this.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void txbAddImagen_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(txbAddImagen.Text, pbxArticulo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
