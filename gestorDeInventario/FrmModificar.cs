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
    public partial class FrmModificar : Form
    {
        private Articulo modificable;
        public FrmModificar()
        {
            InitializeComponent();
        }

        public FrmModificar(Articulo modificable)
        {
            InitializeComponent();
            this.modificable = modificable;
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxAddCat.DataSource = categoriaNegocio.listar();
                cbxAddCat.ValueMember = "id";
                cbxAddCat.DisplayMember = "descripcion";   
                cbxAddMarca.DataSource = marcaNegocio.listar();
                cbxAddMarca.ValueMember = "id";
                cbxAddMarca.DisplayMember = "descripcion";
            }
            catch (Exception)
            {

                throw;
            }
                txbAddCodigo.Text = modificable.Codigo;
                txbAddNombre.Text = modificable.Nombre;
                txbAddDescrip.Text = modificable.Descripcion;
                cbxAddMarca.SelectedValue = modificable.Marca.Id;
                cbxAddCat.SelectedValue = modificable.Categoria.Id;
                txbAddImagen.Text = modificable.ImagenUrl;
                Helper.cargarImagen(modificable.ImagenUrl, pbxArticulo);
                txbAddPrecio.Text = modificable.Precio.ToString();
        }

        private void txbAddImagen_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(txbAddImagen.Text, pbxArticulo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                modificable.Codigo = txbAddCodigo.Text;
                modificable.Nombre = txbAddNombre.Text;
                modificable.Descripcion = txbAddDescrip.Text;
                modificable.Marca = (Marca)cbxAddMarca.SelectedItem;
                modificable.Categoria = (Categoria)cbxAddCat.SelectedItem;
                modificable.ImagenUrl = txbAddImagen.Text;
                modificable.Precio = Convert.ToDecimal(txbAddPrecio.Text);

                // Se llama a la capa de negocio para agregar el nuevo disco
                articuloNegocio.modificar(modificable);

                // Se muestra un mensaje de éxito
                MessageBox.Show("Articulo modificado exitosamente");

                // Se cierra el formulario
                Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
