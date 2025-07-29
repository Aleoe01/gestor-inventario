namespace gestorDeInventario
{
    partial class frmAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddNombre = new System.Windows.Forms.Label();
            this.lblAddDescrip = new System.Windows.Forms.Label();
            this.lblAddCat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbAddCodigo = new System.Windows.Forms.TextBox();
            this.txbAddNombre = new System.Windows.Forms.TextBox();
            this.txbAddImagen = new System.Windows.Forms.TextBox();
            this.txbAddPrecio = new System.Windows.Forms.TextBox();
            this.cbxAddCat = new System.Windows.Forms.ComboBox();
            this.cbxAddMarca = new System.Windows.Forms.ComboBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txbAddDescrip = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // lblAddNombre
            // 
            this.lblAddNombre.AutoSize = true;
            this.lblAddNombre.Location = new System.Drawing.Point(20, 66);
            this.lblAddNombre.Name = "lblAddNombre";
            this.lblAddNombre.Size = new System.Drawing.Size(47, 13);
            this.lblAddNombre.TabIndex = 1;
            this.lblAddNombre.Text = "Nombre:";
            // 
            // lblAddDescrip
            // 
            this.lblAddDescrip.AutoSize = true;
            this.lblAddDescrip.Location = new System.Drawing.Point(20, 101);
            this.lblAddDescrip.Name = "lblAddDescrip";
            this.lblAddDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblAddDescrip.TabIndex = 2;
            this.lblAddDescrip.Text = "Descripcion:";
            // 
            // lblAddCat
            // 
            this.lblAddCat.AutoSize = true;
            this.lblAddCat.Location = new System.Drawing.Point(19, 194);
            this.lblAddCat.Name = "lblAddCat";
            this.lblAddCat.Size = new System.Drawing.Size(55, 13);
            this.lblAddCat.TabIndex = 3;
            this.lblAddCat.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imagen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // txbAddCodigo
            // 
            this.txbAddCodigo.Location = new System.Drawing.Point(95, 30);
            this.txbAddCodigo.Name = "txbAddCodigo";
            this.txbAddCodigo.Size = new System.Drawing.Size(181, 20);
            this.txbAddCodigo.TabIndex = 0;
            // 
            // txbAddNombre
            // 
            this.txbAddNombre.Location = new System.Drawing.Point(95, 62);
            this.txbAddNombre.Name = "txbAddNombre";
            this.txbAddNombre.Size = new System.Drawing.Size(181, 20);
            this.txbAddNombre.TabIndex = 1;
            // 
            // txbAddImagen
            // 
            this.txbAddImagen.Location = new System.Drawing.Point(95, 264);
            this.txbAddImagen.Name = "txbAddImagen";
            this.txbAddImagen.Size = new System.Drawing.Size(181, 20);
            this.txbAddImagen.TabIndex = 5;
            this.txbAddImagen.Leave += new System.EventHandler(this.txbAddImagen_Leave);
            // 
            // txbAddPrecio
            // 
            this.txbAddPrecio.Location = new System.Drawing.Point(95, 302);
            this.txbAddPrecio.Name = "txbAddPrecio";
            this.txbAddPrecio.Size = new System.Drawing.Size(181, 20);
            this.txbAddPrecio.TabIndex = 6;
            this.txbAddPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAddPrecio_KeyPress);
            // 
            // cbxAddCat
            // 
            this.cbxAddCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCat.FormattingEnabled = true;
            this.cbxAddCat.Location = new System.Drawing.Point(95, 191);
            this.cbxAddCat.Name = "cbxAddCat";
            this.cbxAddCat.Size = new System.Drawing.Size(181, 21);
            this.cbxAddCat.TabIndex = 3;
            // 
            // cbxAddMarca
            // 
            this.cbxAddMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddMarca.FormattingEnabled = true;
            this.cbxAddMarca.Location = new System.Drawing.Point(95, 227);
            this.cbxAddMarca.Name = "cbxAddMarca";
            this.cbxAddMarca.Size = new System.Drawing.Size(181, 21);
            this.cbxAddMarca.TabIndex = 4;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(315, 30);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(235, 235);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 16;
            this.pbxArticulo.TabStop = false;
            // 
            // txbAddDescrip
            // 
            this.txbAddDescrip.Location = new System.Drawing.Point(95, 101);
            this.txbAddDescrip.Multiline = true;
            this.txbAddDescrip.Name = "txbAddDescrip";
            this.txbAddDescrip.Size = new System.Drawing.Size(181, 69);
            this.txbAddDescrip.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddImagen
            // 
            this.btnAddImagen.Location = new System.Drawing.Point(282, 264);
            this.btnAddImagen.Name = "btnAddImagen";
            this.btnAddImagen.Size = new System.Drawing.Size(20, 20);
            this.btnAddImagen.TabIndex = 20;
            this.btnAddImagen.Text = "+";
            this.btnAddImagen.UseVisualStyleBackColor = true;
            this.btnAddImagen.Click += new System.EventHandler(this.btnAddImagen_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 352);
            this.Controls.Add(this.btnAddImagen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddNombre;
        private System.Windows.Forms.Label lblAddDescrip;
        private System.Windows.Forms.Label lblAddCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAddCodigo;
        private System.Windows.Forms.TextBox txbAddNombre;
        private System.Windows.Forms.TextBox txbAddImagen;
        private System.Windows.Forms.TextBox txbAddPrecio;
        private System.Windows.Forms.ComboBox cbxAddCat;
        private System.Windows.Forms.ComboBox cbxAddMarca;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txbAddDescrip;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddImagen;
    }
}