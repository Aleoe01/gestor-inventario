namespace gestorDeInventario
{
    partial class FrmDetalle
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
            this.pbxDetalle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetalleDesc = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDetalle
            // 
            this.pbxDetalle.Location = new System.Drawing.Point(199, 7);
            this.pbxDetalle.Name = "pbxDetalle";
            this.pbxDetalle.Size = new System.Drawing.Size(384, 376);
            this.pbxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalle.TabIndex = 0;
            this.pbxDetalle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(14, 49);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(87, 13);
            this.lblDetalleNombre.TabIndex = 2;
            this.lblDetalleNombre.Text = "lblDetalleNombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo:";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(14, 111);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(83, 13);
            this.lblDetalleCodigo.TabIndex = 4;
            this.lblDetalleCodigo.Text = "lblDetalleCodigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion:";
            // 
            // lblDetalleDesc
            // 
            this.lblDetalleDesc.AutoSize = true;
            this.lblDetalleDesc.Location = new System.Drawing.Point(14, 176);
            this.lblDetalleDesc.Name = "lblDetalleDesc";
            this.lblDetalleDesc.Size = new System.Drawing.Size(75, 13);
            this.lblDetalleDesc.TabIndex = 6;
            this.lblDetalleDesc.Text = "lblDetalleDesc";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(14, 284);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(35, 13);
            this.lblDetallePrecio.TabIndex = 8;
            this.lblDetallePrecio.Text = "label2";
            // 
            // Precio
            // 
            this.Precio.AutoEllipsis = true;
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(12, 263);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(47, 13);
            this.Precio.TabIndex = 7;
            this.Precio.Text = "Precio:";
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 395);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.lblDetalleDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDetalleCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de articulo";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetalleDesc;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label Precio;
    }
}