namespace gestorDeInventario
{
    partial class FrmFiltroAvanzado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecioMin = new System.Windows.Forms.Label();
            this.lblPrecioMax = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.txtFiltroMarca = new System.Windows.Forms.TextBox();
            this.txtFiltroCat = new System.Windows.Forms.TextBox();
            this.txtFiltroPrecMin = new System.Windows.Forms.TextBox();
            this.txtPrecMax = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 84);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 130);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecioMin
            // 
            this.lblPrecioMin.AutoSize = true;
            this.lblPrecioMin.Location = new System.Drawing.Point(33, 179);
            this.lblPrecioMin.Name = "lblPrecioMin";
            this.lblPrecioMin.Size = new System.Drawing.Size(59, 13);
            this.lblPrecioMin.TabIndex = 3;
            this.lblPrecioMin.Text = "Precio min.";
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.Location = new System.Drawing.Point(33, 228);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(62, 13);
            this.lblPrecioMax.TabIndex = 4;
            this.lblPrecioMax.Text = "Precio max.";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(119, 40);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(164, 20);
            this.txtFiltroNombre.TabIndex = 0;
            // 
            // txtFiltroMarca
            // 
            this.txtFiltroMarca.Location = new System.Drawing.Point(119, 81);
            this.txtFiltroMarca.Name = "txtFiltroMarca";
            this.txtFiltroMarca.Size = new System.Drawing.Size(164, 20);
            this.txtFiltroMarca.TabIndex = 1;
            // 
            // txtFiltroCat
            // 
            this.txtFiltroCat.Location = new System.Drawing.Point(119, 127);
            this.txtFiltroCat.Name = "txtFiltroCat";
            this.txtFiltroCat.Size = new System.Drawing.Size(164, 20);
            this.txtFiltroCat.TabIndex = 2;
            // 
            // txtFiltroPrecMin
            // 
            this.txtFiltroPrecMin.Location = new System.Drawing.Point(141, 176);
            this.txtFiltroPrecMin.Name = "txtFiltroPrecMin";
            this.txtFiltroPrecMin.Size = new System.Drawing.Size(142, 20);
            this.txtFiltroPrecMin.TabIndex = 3;
            this.txtFiltroPrecMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPrecMin_KeyPress);
            // 
            // txtPrecMax
            // 
            this.txtPrecMax.Location = new System.Drawing.Point(141, 225);
            this.txtPrecMax.Name = "txtPrecMax";
            this.txtPrecMax.Size = new System.Drawing.Size(142, 20);
            this.txtPrecMax.TabIndex = 4;
            this.txtPrecMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecMax_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(67, 281);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "$";
            // 
            // FrmFiltroAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPrecMax);
            this.Controls.Add(this.txtFiltroPrecMin);
            this.Controls.Add(this.txtFiltroCat);
            this.Controls.Add(this.txtFiltroMarca);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.lblPrecioMax);
            this.Controls.Add(this.lblPrecioMin);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFiltroAvanzado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFiltroAvanzado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecioMin;
        private System.Windows.Forms.Label lblPrecioMax;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.TextBox txtFiltroMarca;
        private System.Windows.Forms.TextBox txtFiltroCat;
        private System.Windows.Forms.TextBox txtFiltroPrecMin;
        private System.Windows.Forms.TextBox txtPrecMax;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}