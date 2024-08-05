namespace SIEleccionReina.Formularios
{
    partial class FormVotoFotogenica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotoFotogenica));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BTNVotar = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.LblNmbCandidata = new System.Windows.Forms.Label();
            this.PBOXImagenCandidata = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFotogenica = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBOXImagenCandidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitulo.Location = new System.Drawing.Point(181, 11);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(153, 44);
            this.LblTitulo.TabIndex = 49;
            this.LblTitulo.Text = "Elección Reina de la Facultad de Matemáticas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNVotar
            // 
            this.BTNVotar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNVotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNVotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNVotar.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVotar.Location = new System.Drawing.Point(107, 363);
            this.BTNVotar.Margin = new System.Windows.Forms.Padding(2);
            this.BTNVotar.Name = "BTNVotar";
            this.BTNVotar.Size = new System.Drawing.Size(99, 23);
            this.BTNVotar.TabIndex = 48;
            this.BTNVotar.Text = "Votar";
            this.BTNVotar.UseVisualStyleBackColor = false;
            this.BTNVotar.Click += new System.EventHandler(this.BTNVotar_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(260, 204);
            this.BtnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(18, 25);
            this.BtnSiguiente.TabIndex = 47;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(24, 215);
            this.BtnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(18, 25);
            this.BtnAtras.TabIndex = 45;
            this.BtnAtras.Text = "<";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // LblNmbCandidata
            // 
            this.LblNmbCandidata.AutoSize = true;
            this.LblNmbCandidata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblNmbCandidata.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNmbCandidata.Location = new System.Drawing.Point(68, 96);
            this.LblNmbCandidata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNmbCandidata.Name = "LblNmbCandidata";
            this.LblNmbCandidata.Size = new System.Drawing.Size(156, 14);
            this.LblNmbCandidata.TabIndex = 44;
            this.LblNmbCandidata.Text = "Nombre de la Candidata";
            this.LblNmbCandidata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBOXImagenCandidata
            // 
            this.PBOXImagenCandidata.Image = global::SIEleccionReina.Properties.Resources.descarga__5_;
            this.PBOXImagenCandidata.Location = new System.Drawing.Point(47, 113);
            this.PBOXImagenCandidata.Name = "PBOXImagenCandidata";
            this.PBOXImagenCandidata.Size = new System.Drawing.Size(208, 226);
            this.PBOXImagenCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBOXImagenCandidata.TabIndex = 46;
            this.PBOXImagenCandidata.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lblFotogenica
            // 
            this.lblFotogenica.AutoSize = true;
            this.lblFotogenica.BackColor = System.Drawing.Color.Teal;
            this.lblFotogenica.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotogenica.Location = new System.Drawing.Point(21, 66);
            this.lblFotogenica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFotogenica.Name = "lblFotogenica";
            this.lblFotogenica.Size = new System.Drawing.Size(288, 16);
            this.lblFotogenica.TabIndex = 50;
            this.lblFotogenica.Text = "Candidatas fotogenica de la universidad";
            this.lblFotogenica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNSalir
            // 
            this.BTNSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSalir.Font = new System.Drawing.Font("Script MT Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(295, 384);
            this.BTNSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(48, 26);
            this.BTNSalir.TabIndex = 51;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // FrmVotarFotogenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 412);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.lblFotogenica);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BTNVotar);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.PBOXImagenCandidata);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.LblNmbCandidata);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmVotarFotogenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votación - Miss Fotogénica";
            this.Load += new System.EventHandler(this.FrmVotarFotogenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBOXImagenCandidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BTNVotar;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.PictureBox PBOXImagenCandidata;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label LblNmbCandidata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFotogenica;
        private System.Windows.Forms.Button BTNSalir;
    }
}