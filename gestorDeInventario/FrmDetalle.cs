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

namespace gestorDeInventario
{
    public partial class FrmDetalle : Form
    {
        private Articulo articulo;
        public FrmDetalle()
        {
            InitializeComponent();
        }
        public FrmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            lblDetalleNombre.Text = articulo.Nombre;
            lblDetalleCodigo.Text = articulo.Codigo;
            lblDetalleDesc.Text = articulo.Descripcion;
            lblDetallePrecio.Text = articulo.Precio.ToString();
            Helper.cargarImagen(articulo.ImagenUrl, pbxDetalle);
        }

    }
}
