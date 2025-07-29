using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
        private OpenFileDialog archivo = null;
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

                if (archivo != null && !(txbAddImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["inventarioImages"] + archivo.SafeFileName);

                // Se cierra el formulario
                Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        // Evita que se escriban letras u otros caracteres no válidos.
        private void txbAddPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) // permite solo ingresar numeros
                e.Handled = true;
        }

        private void btnAddImagen_Click_1(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbAddImagen.Text = archivo.FileName;
                Helper.cargarImagen(archivo.FileName, pbxArticulo);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
