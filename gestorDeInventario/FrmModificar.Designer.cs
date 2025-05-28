namespace gestorDeInventario
{
    partial class FrmModificar
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbAddDescrip = new System.Windows.Forms.TextBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.cbxAddMarca = new System.Windows.Forms.ComboBox();
            this.cbxAddCat = new System.Windows.Forms.ComboBox();
            this.txbAddPrecio = new System.Windows.Forms.TextBox();
            this.txbAddImagen = new System.Windows.Forms.TextBox();
            this.txbAddNombre = new System.Windows.Forms.TextBox();
            this.txbAddCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddCat = new System.Windows.Forms.Label();
            this.lblAddDescrip = new System.Windows.Forms.Label();
            this.lblAddNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(426, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(318, 289);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 23);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbAddDescrip
            // 
            this.txbAddDescrip.Location = new System.Drawing.Point(95, 101);
            this.txbAddDescrip.Multiline = true;
            this.txbAddDescrip.Name = "txbAddDescrip";
            this.txbAddDescrip.Size = new System.Drawing.Size(181, 69);
            this.txbAddDescrip.TabIndex = 34;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(297, 30);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(235, 235);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 33;
            this.pbxArticulo.TabStop = false;
            // 
            // cbxAddMarca
            // 
            this.cbxAddMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddMarca.FormattingEnabled = true;
            this.cbxAddMarca.Location = new System.Drawing.Point(95, 227);
            this.cbxAddMarca.Name = "cbxAddMarca";
            this.cbxAddMarca.Size = new System.Drawing.Size(181, 21);
            this.cbxAddMarca.TabIndex = 32;
            // 
            // cbxAddCat
            // 
            this.cbxAddCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCat.FormattingEnabled = true;
            this.cbxAddCat.Location = new System.Drawing.Point(95, 191);
            this.cbxAddCat.Name = "cbxAddCat";
            this.cbxAddCat.Size = new System.Drawing.Size(181, 21);
            this.cbxAddCat.TabIndex = 31;
            // 
            // txbAddPrecio
            // 
            this.txbAddPrecio.Location = new System.Drawing.Point(95, 302);
            this.txbAddPrecio.Name = "txbAddPrecio";
            this.txbAddPrecio.Size = new System.Drawing.Size(181, 20);
            this.txbAddPrecio.TabIndex = 30;
            // 
            // txbAddImagen
            // 
            this.txbAddImagen.Location = new System.Drawing.Point(95, 264);
            this.txbAddImagen.Name = "txbAddImagen";
            this.txbAddImagen.Size = new System.Drawing.Size(181, 20);
            this.txbAddImagen.TabIndex = 29;
            this.txbAddImagen.Leave += new System.EventHandler(this.txbAddImagen_Leave);
            // 
            // txbAddNombre
            // 
            this.txbAddNombre.Location = new System.Drawing.Point(95, 62);
            this.txbAddNombre.Name = "txbAddNombre";
            this.txbAddNombre.Size = new System.Drawing.Size(181, 20);
            this.txbAddNombre.TabIndex = 28;
            // 
            // txbAddCodigo
            // 
            this.txbAddCodigo.Location = new System.Drawing.Point(95, 30);
            this.txbAddCodigo.Name = "txbAddCodigo";
            this.txbAddCodigo.Size = new System.Drawing.Size(181, 20);
            this.txbAddCodigo.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Imagen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Marca:";
            // 
            // lblAddCat
            // 
            this.lblAddCat.AutoSize = true;
            this.lblAddCat.Location = new System.Drawing.Point(19, 194);
            this.lblAddCat.Name = "lblAddCat";
            this.lblAddCat.Size = new System.Drawing.Size(55, 13);
            this.lblAddCat.TabIndex = 23;
            this.lblAddCat.Text = "Categoria:";
            // 
            // lblAddDescrip
            // 
            this.lblAddDescrip.AutoSize = true;
            this.lblAddDescrip.Location = new System.Drawing.Point(20, 101);
            this.lblAddDescrip.Name = "lblAddDescrip";
            this.lblAddDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblAddDescrip.TabIndex = 22;
            this.lblAddDescrip.Text = "Descripcion:";
            // 
            // lblAddNombre
            // 
            this.lblAddNombre.AutoSize = true;
            this.lblAddNombre.Location = new System.Drawing.Point(20, 66);
            this.lblAddNombre.Name = "lblAddNombre";
            this.lblAddNombre.Size = new System.Drawing.Size(47, 13);
            this.lblAddNombre.TabIndex = 21;
            this.lblAddNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo:";
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txbAddDescrip);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.cbxAddMarca);
            this.Controls.Add(this.cbxAddCat);
            this.Controls.Add(this.txbAddPrecio);
            this.Controls.Add(this.txbAddImagen);
            this.Controls.Add(this.txbAddNombre);
            this.Controls.Add(this.txbAddCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAddCat);
            this.Controls.Add(this.lblAddDescrip);
            this.Controls.Add(this.lblAddNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar articulo";
            this.Load += new System.EventHandler(this.FrmModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbAddDescrip;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ComboBox cbxAddMarca;
        private System.Windows.Forms.ComboBox cbxAddCat;
        private System.Windows.Forms.TextBox txbAddPrecio;
        private System.Windows.Forms.TextBox txbAddImagen;
        private System.Windows.Forms.TextBox txbAddNombre;
        private System.Windows.Forms.TextBox txbAddCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddCat;
        private System.Windows.Forms.Label lblAddDescrip;
        private System.Windows.Forms.Label lblAddNombre;
        private System.Windows.Forms.Label label1;
    }
}