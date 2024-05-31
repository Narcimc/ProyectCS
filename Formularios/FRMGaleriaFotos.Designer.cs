namespace SIEleccionReina.Formularios
{
    partial class FRMGaleriaFotos
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
            this.components = new System.ComponentModel.Container();
            this.LblRegistroDeFoto = new System.Windows.Forms.Label();
            this.LblAlbum = new System.Windows.Forms.Label();
            this.CmbFotosGaleria = new System.Windows.Forms.ComboBox();
            this.LblFoto = new System.Windows.Forms.Label();
            this.BtnBuscarFoto = new System.Windows.Forms.Button();
            this.PBoxCargarFotografia = new System.Windows.Forms.PictureBox();
            this.OFDBuscarFoto = new System.Windows.Forms.OpenFileDialog();
            this.LBLDescripcionFoto = new System.Windows.Forms.Label();
            this.LBLTituloFoto = new System.Windows.Forms.Label();
            this.TXTTituloFoto = new System.Windows.Forms.TextBox();
            this.RTBDescripcionFoto = new System.Windows.Forms.RichTextBox();
            this.BTNGuardarFoto = new System.Windows.Forms.Button();
            this.BTNLimpiarFoto = new System.Windows.Forms.Button();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCargarFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistroDeFoto
            // 
            this.LblRegistroDeFoto.AutoSize = true;
            this.LblRegistroDeFoto.BackColor = System.Drawing.Color.Orchid;
            this.LblRegistroDeFoto.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroDeFoto.Location = new System.Drawing.Point(128, 9);
            this.LblRegistroDeFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRegistroDeFoto.Name = "LblRegistroDeFoto";
            this.LblRegistroDeFoto.Size = new System.Drawing.Size(140, 18);
            this.LblRegistroDeFoto.TabIndex = 0;
            this.LblRegistroDeFoto.Text = "Galeria de Fotos";
            // 
            // LblAlbum
            // 
            this.LblAlbum.AutoSize = true;
            this.LblAlbum.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlbum.Location = new System.Drawing.Point(40, 49);
            this.LblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAlbum.Name = "LblAlbum";
            this.LblAlbum.Size = new System.Drawing.Size(56, 15);
            this.LblAlbum.TabIndex = 1;
            this.LblAlbum.Text = "Albumes:";
            this.LblAlbum.Click += new System.EventHandler(this.LblAlbum_Click);
            // 
            // CmbFotosGaleria
            // 
            this.CmbFotosGaleria.FormattingEnabled = true;
            this.CmbFotosGaleria.Location = new System.Drawing.Point(116, 47);
            this.CmbFotosGaleria.Margin = new System.Windows.Forms.Padding(2);
            this.CmbFotosGaleria.Name = "CmbFotosGaleria";
            this.CmbFotosGaleria.Size = new System.Drawing.Size(201, 21);
            this.CmbFotosGaleria.TabIndex = 2;
            this.CmbFotosGaleria.SelectedIndexChanged += new System.EventHandler(this.CmbFotosGaleria_SelectedIndexChanged);
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoto.Location = new System.Drawing.Point(179, 75);
            this.LblFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(38, 17);
            this.LblFoto.TabIndex = 3;
            this.LblFoto.Text = "Foto";
            // 
            // BtnBuscarFoto
            // 
            this.BtnBuscarFoto.BackColor = System.Drawing.Color.Thistle;
            this.BtnBuscarFoto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarFoto.Location = new System.Drawing.Point(116, 105);
            this.BtnBuscarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarFoto.Name = "BtnBuscarFoto";
            this.BtnBuscarFoto.Size = new System.Drawing.Size(165, 23);
            this.BtnBuscarFoto.TabIndex = 4;
            this.BtnBuscarFoto.Text = "Cargar Fotografía";
            this.BtnBuscarFoto.UseVisualStyleBackColor = false;
            this.BtnBuscarFoto.Click += new System.EventHandler(this.BtnBuscarFoto_Click);
            // 
            // PBoxCargarFotografia
            // 
            this.PBoxCargarFotografia.BackColor = System.Drawing.Color.SlateGray;
            this.PBoxCargarFotografia.Location = new System.Drawing.Point(80, 146);
            this.PBoxCargarFotografia.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxCargarFotografia.Name = "PBoxCargarFotografia";
            this.PBoxCargarFotografia.Size = new System.Drawing.Size(237, 138);
            this.PBoxCargarFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxCargarFotografia.TabIndex = 5;
            this.PBoxCargarFotografia.TabStop = false;
            this.PBoxCargarFotografia.Click += new System.EventHandler(this.PBoxCargarFotografia_Click);
            // 
            // OFDBuscarFoto
            // 
            this.OFDBuscarFoto.FileName = "BuscarFoto";
            // 
            // LBLDescripcionFoto
            // 
            this.LBLDescripcionFoto.AutoSize = true;
            this.LBLDescripcionFoto.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDescripcionFoto.Location = new System.Drawing.Point(40, 347);
            this.LBLDescripcionFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDescripcionFoto.Name = "LBLDescripcionFoto";
            this.LBLDescripcionFoto.Size = new System.Drawing.Size(72, 15);
            this.LBLDescripcionFoto.TabIndex = 6;
            this.LBLDescripcionFoto.Text = "Descripción:";
            // 
            // LBLTituloFoto
            // 
            this.LBLTituloFoto.AutoSize = true;
            this.LBLTituloFoto.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTituloFoto.Location = new System.Drawing.Point(40, 305);
            this.LBLTituloFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLTituloFoto.Name = "LBLTituloFoto";
            this.LBLTituloFoto.Size = new System.Drawing.Size(43, 15);
            this.LBLTituloFoto.TabIndex = 7;
            this.LBLTituloFoto.Text = "Titulo:";
            // 
            // TXTTituloFoto
            // 
            this.TXTTituloFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTituloFoto.Location = new System.Drawing.Point(116, 297);
            this.TXTTituloFoto.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTituloFoto.Name = "TXTTituloFoto";
            this.TXTTituloFoto.Size = new System.Drawing.Size(201, 23);
            this.TXTTituloFoto.TabIndex = 8;
            // 
            // RTBDescripcionFoto
            // 
            this.RTBDescripcionFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBDescripcionFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBDescripcionFoto.Location = new System.Drawing.Point(116, 324);
            this.RTBDescripcionFoto.Margin = new System.Windows.Forms.Padding(2);
            this.RTBDescripcionFoto.Name = "RTBDescripcionFoto";
            this.RTBDescripcionFoto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTBDescripcionFoto.Size = new System.Drawing.Size(201, 64);
            this.RTBDescripcionFoto.TabIndex = 9;
            this.RTBDescripcionFoto.Text = "";
            // 
            // BTNGuardarFoto
            // 
            this.BTNGuardarFoto.BackColor = System.Drawing.Color.Orchid;
            this.BTNGuardarFoto.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardarFoto.Location = new System.Drawing.Point(80, 408);
            this.BTNGuardarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGuardarFoto.Name = "BTNGuardarFoto";
            this.BTNGuardarFoto.Size = new System.Drawing.Size(96, 23);
            this.BTNGuardarFoto.TabIndex = 10;
            this.BTNGuardarFoto.Text = "Guardar";
            this.BTNGuardarFoto.UseVisualStyleBackColor = false;
            this.BTNGuardarFoto.Click += new System.EventHandler(this.BTNGuardarFoto_Click);
            // 
            // BTNLimpiarFoto
            // 
            this.BTNLimpiarFoto.BackColor = System.Drawing.Color.Orchid;
            this.BTNLimpiarFoto.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiarFoto.Location = new System.Drawing.Point(221, 408);
            this.BTNLimpiarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BTNLimpiarFoto.Name = "BTNLimpiarFoto";
            this.BTNLimpiarFoto.Size = new System.Drawing.Size(96, 23);
            this.BTNLimpiarFoto.TabIndex = 11;
            this.BTNLimpiarFoto.Text = "Limpiar";
            this.BTNLimpiarFoto.UseVisualStyleBackColor = false;
            this.BTNLimpiarFoto.Click += new System.EventHandler(this.BTNLimpiarFoto_Click);
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // FRMGaleriaFotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(402, 449);
            this.Controls.Add(this.BTNLimpiarFoto);
            this.Controls.Add(this.BTNGuardarFoto);
            this.Controls.Add(this.RTBDescripcionFoto);
            this.Controls.Add(this.TXTTituloFoto);
            this.Controls.Add(this.LBLTituloFoto);
            this.Controls.Add(this.LBLDescripcionFoto);
            this.Controls.Add(this.PBoxCargarFotografia);
            this.Controls.Add(this.BtnBuscarFoto);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.CmbFotosGaleria);
            this.Controls.Add(this.LblAlbum);
            this.Controls.Add(this.LblRegistroDeFoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMGaleriaFotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria de Fotos";
            this.Load += new System.EventHandler(this.FRMGaleriaFotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxCargarFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistroDeFoto;
        private System.Windows.Forms.Label LblAlbum;
        private System.Windows.Forms.ComboBox CmbFotosGaleria;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.Button BtnBuscarFoto;
        private System.Windows.Forms.PictureBox PBoxCargarFotografia;
        private System.Windows.Forms.OpenFileDialog OFDBuscarFoto;
        private System.Windows.Forms.Label LBLDescripcionFoto;
        private System.Windows.Forms.Label LBLTituloFoto;
        private System.Windows.Forms.TextBox TXTTituloFoto;
        private System.Windows.Forms.RichTextBox RTBDescripcionFoto;
        private System.Windows.Forms.Button BTNGuardarFoto;
        private System.Windows.Forms.Button BTNLimpiarFoto;
        private System.Windows.Forms.OpenFileDialog OpenFilaFoto;
        private System.Windows.Forms.ErrorProvider EP;
    }
}