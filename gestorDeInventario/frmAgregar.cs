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
using System.Configuration;
using System.IO;


namespace gestorDeInventario
{
    public partial class frmAgregar : Form
    {

        private OpenFileDialog archivo = null; // se crea esta variable para indicar si se debe o no gaurdar imagen de manera local

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
                cbxAddCat.DataSource = categoriaNegocio.listar(); // Llena ComboBox de categorías
                cbxAddMarca.DataSource = marcaNegocio.listar(); // Llena ComboBox de marcas
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Validaciones
            if (string.IsNullOrWhiteSpace(txbAddCodigo.Text))
            {
                MessageBox.Show("El campo Código es obligatorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAddCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbAddNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAddNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbAddPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio válido (mayor a 0).", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAddPrecio.Focus();
                return;
            }

            // Sí pasa todas las validaciones se crea el nuevo articulo
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
                // Llama al método agregar() para guardar el artículo en la base de datos
                articuloNegocio.agregar(articuloNuevo);
                MessageBox.Show("Articulo agregado exitosamente");

                // Si se seleccionó un archivo de imagen local (no un link http), lo copia a la carpeta del sistema
                if (archivo != null && !(txbAddImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["inventarioImages"] + archivo.SafeFileName);

                this.Close();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
        private void txbAddPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) // permite solo ingresar numeros
                e.Handled = true;
        }

        private void txbAddImagen_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(txbAddImagen.Text, pbxArticulo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImagen_Click(object sender, EventArgs e)
        {
            // Abre un cuadro de diálogo para elegir una imagen local
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbAddImagen.Text = archivo.FileName;
                Helper.cargarImagen(archivo.FileName, pbxArticulo);
            }
        }

    }
}
