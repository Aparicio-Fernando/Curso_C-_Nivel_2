namespace presentacion
{
    partial class frmDetalleArticulo
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxArticuloDetalle = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(460, 389);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(63, 29);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxArticuloDetalle
            // 
            this.pbxArticuloDetalle.Location = new System.Drawing.Point(609, 24);
            this.pbxArticuloDetalle.Name = "pbxArticuloDetalle";
            this.pbxArticuloDetalle.Size = new System.Drawing.Size(344, 344);
            this.pbxArticuloDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticuloDetalle.TabIndex = 18;
            this.pbxArticuloDetalle.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "URL de Imagen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(185, 258);
            this.txtImagen.Multiline = true;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.ReadOnly = true;
            this.txtImagen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtImagen.Size = new System.Drawing.Size(329, 20);
            this.txtImagen.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtDes);
            this.panel1.Controls.Add(this.txtImagen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(39, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 345);
            this.panel1.TabIndex = 17;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(185, 138);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDes.Size = new System.Drawing.Size(329, 20);
            this.txtDes.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 99);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombre.Size = new System.Drawing.Size(329, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(185, 59);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCod.Size = new System.Drawing.Size(329, 20);
            this.txtCod.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(185, 20);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtId.Size = new System.Drawing.Size(329, 20);
            this.txtId.TabIndex = 21;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(185, 218);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCategoria.Size = new System.Drawing.Size(329, 20);
            this.txtCategoria.TabIndex = 22;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(185, 299);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrecio.Size = new System.Drawing.Size(329, 20);
            this.txtPrecio.TabIndex = 23;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(185, 179);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMarca.Size = new System.Drawing.Size(329, 20);
            this.txtMarca.TabIndex = 24;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.pbxArticuloDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Artículo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxArticuloDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDes;
    }
}