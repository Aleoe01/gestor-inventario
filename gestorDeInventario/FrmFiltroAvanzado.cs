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

namespace gestorDeInventario
{
    public partial class FrmFiltroAvanzado : Form
    {

        public List<Articulo> listaFiltradaAvanzada = null;

        public FrmFiltroAvanzado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {

                string nombre = string.IsNullOrWhiteSpace(txtFiltroNombre.Text) ? null : txtFiltroNombre.Text;
                string marca = string.IsNullOrWhiteSpace(txtFiltroMarca.Text) ? null : txtFiltroMarca.Text;
                string categoria = string.IsNullOrWhiteSpace(txtFiltroCat.Text) ? null : txtFiltroCat.Text;

                decimal? precioMin = string.IsNullOrWhiteSpace(txtFiltroPrecMin.Text)
                    ? (decimal?)null
                    : Convert.ToDecimal(txtFiltroPrecMin.Text);

                decimal? precioMax = string.IsNullOrWhiteSpace(txtPrecMax.Text)
                    ? (decimal?)null
                    : Convert.ToDecimal(txtPrecMax.Text);

                listaFiltradaAvanzada = articuloNegocio.filtrar(nombre, marca, categoria, precioMin, precioMax);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception err)
            {

                throw err;

            }
        }

        private void txtFiltroPrecMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) // permite solo ingresar numeros
                e.Handled = true;
        }

        private void txtPrecMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) // permite solo ingresar numeros
                e.Handled = true;
        }
    }
}
