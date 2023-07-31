namespace winform_app
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLanza = new System.Windows.Forms.Label();
            this.lvlCantCanciones = new System.Windows.Forms.Label();
            this.dtpFechaLanza = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoEdit = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.txtUrlImagenTapa = new System.Windows.Forms.TextBox();
            this.lblUrlImagenTapa = new System.Windows.Forms.Label();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(116, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblFechaLanza
            // 
            this.lblFechaLanza.AutoSize = true;
            this.lblFechaLanza.Location = new System.Drawing.Point(49, 60);
            this.lblFechaLanza.Name = "lblFechaLanza";
            this.lblFechaLanza.Size = new System.Drawing.Size(103, 13);
            this.lblFechaLanza.TabIndex = 1;
            this.lblFechaLanza.Text = "Fecha Lanzamiento:";
            // 
            // lvlCantCanciones
            // 
            this.lvlCantCanciones.AutoSize = true;
            this.lvlCantCanciones.Location = new System.Drawing.Point(47, 89);
            this.lvlCantCanciones.Name = "lvlCantCanciones";
            this.lvlCantCanciones.Size = new System.Drawing.Size(105, 13);
            this.lvlCantCanciones.TabIndex = 2;
            this.lvlCantCanciones.Text = "Cantidad Canciones:";
            // 
            // dtpFechaLanza
            // 
            this.dtpFechaLanza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLanza.Location = new System.Drawing.Point(158, 60);
            this.dtpFechaLanza.Name = "dtpFechaLanza";
            this.dtpFechaLanza.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaLanza.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(158, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(200, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(158, 86);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(200, 20);
            this.txtCantCanciones.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(153, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoEdit
            // 
            this.lblTipoEdit.AutoSize = true;
            this.lblTipoEdit.Location = new System.Drawing.Point(84, 173);
            this.lblTipoEdit.Name = "lblTipoEdit";
            this.lblTipoEdit.Size = new System.Drawing.Size(69, 13);
            this.lblTipoEdit.TabIndex = 8;
            this.lblTipoEdit.Text = "Tipo Edicion:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(117, 145);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 9;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(158, 142);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(200, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboEdicion
            // 
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(158, 170);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(200, 21);
            this.cboEdicion.TabIndex = 5;
            // 
            // txtUrlImagenTapa
            // 
            this.txtUrlImagenTapa.Location = new System.Drawing.Point(158, 116);
            this.txtUrlImagenTapa.Name = "txtUrlImagenTapa";
            this.txtUrlImagenTapa.Size = new System.Drawing.Size(200, 20);
            this.txtUrlImagenTapa.TabIndex = 3;
            this.txtUrlImagenTapa.Leave += new System.EventHandler(this.txtUrlImagenTapa_Leave);
            // 
            // lblUrlImagenTapa
            // 
            this.lblUrlImagenTapa.AutoSize = true;
            this.lblUrlImagenTapa.Location = new System.Drawing.Point(70, 119);
            this.lblUrlImagenTapa.Name = "lblUrlImagenTapa";
            this.lblUrlImagenTapa.Size = new System.Drawing.Size(82, 13);
            this.lblUrlImagenTapa.TabIndex = 12;
            this.lblUrlImagenTapa.Text = "Tapa del Disco:";
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(413, 34);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(217, 202);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 14;
            this.pbxDisco.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(364, 116);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(25, 23);
            this.btnAgregarImagen.TabIndex = 15;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 291);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.txtUrlImagenTapa);
            this.Controls.Add(this.lblUrlImagenTapa);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblTipoEdit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dtpFechaLanza);
            this.Controls.Add(this.lvlCantCanciones);
            this.Controls.Add(this.lblFechaLanza);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaDisco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanza;
        private System.Windows.Forms.Label lvlCantCanciones;
        private System.Windows.Forms.DateTimePicker dtpFechaLanza;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEdit;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.TextBox txtUrlImagenTapa;
        private System.Windows.Forms.Label lblUrlImagenTapa;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}