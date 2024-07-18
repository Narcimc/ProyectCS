namespace SIEleccionReina
{
    partial class ModuloAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloAdministrador));
            this.BtnInscripcionCandidatas = new System.Windows.Forms.Button();
            this.BtnRegistroFoto = new System.Windows.Forms.Button();
            this.BtnResultados = new System.Windows.Forms.Button();
            this.PBoxResultados = new System.Windows.Forms.PictureBox();
            this.PBoxGaleria = new System.Windows.Forms.PictureBox();
            this.PBoxRegistroCandidata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInscripcionCandidatas
            // 
            this.BtnInscripcionCandidatas.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnInscripcionCandidatas.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnInscripcionCandidatas.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInscripcionCandidatas.Location = new System.Drawing.Point(11, 41);
            this.BtnInscripcionCandidatas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInscripcionCandidatas.Name = "BtnInscripcionCandidatas";
            this.BtnInscripcionCandidatas.Size = new System.Drawing.Size(206, 41);
            this.BtnInscripcionCandidatas.TabIndex = 0;
            this.BtnInscripcionCandidatas.Text = "Inscripción de Candidatas";
            this.BtnInscripcionCandidatas.UseVisualStyleBackColor = false;
            this.BtnInscripcionCandidatas.Click += new System.EventHandler(this.BtnInscripcionCandidatas_Click);
            // 
            // BtnRegistroFoto
            // 
            this.BtnRegistroFoto.BackColor = System.Drawing.Color.Plum;
            this.BtnRegistroFoto.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroFoto.Location = new System.Drawing.Point(143, 114);
            this.BtnRegistroFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistroFoto.Name = "BtnRegistroFoto";
            this.BtnRegistroFoto.Size = new System.Drawing.Size(188, 41);
            this.BtnRegistroFoto.TabIndex = 1;
            this.BtnRegistroFoto.Text = "Galería de Fotos";
            this.BtnRegistroFoto.UseVisualStyleBackColor = false;
            this.BtnRegistroFoto.Click += new System.EventHandler(this.BtnRegistroFoto_Click);
            // 
            // BtnResultados
            // 
            this.BtnResultados.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnResultados.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResultados.Location = new System.Drawing.Point(11, 185);
            this.BtnResultados.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResultados.Name = "BtnResultados";
            this.BtnResultados.Size = new System.Drawing.Size(188, 41);
            this.BtnResultados.TabIndex = 5;
            this.BtnResultados.Text = "Resultados";
            this.BtnResultados.UseVisualStyleBackColor = false;
            this.BtnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // PBoxResultados
            // 
            this.PBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxResultados.Image = ((System.Drawing.Image)(resources.GetObject("PBoxResultados.Image")));
            this.PBoxResultados.Location = new System.Drawing.Point(216, 185);
            this.PBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxResultados.Name = "PBoxResultados";
            this.PBoxResultados.Size = new System.Drawing.Size(51, 42);
            this.PBoxResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxResultados.TabIndex = 4;
            this.PBoxResultados.TabStop = false;
            // 
            // PBoxGaleria
            // 
            this.PBoxGaleria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxGaleria.Image = ((System.Drawing.Image)(resources.GetObject("PBoxGaleria.Image")));
            this.PBoxGaleria.Location = new System.Drawing.Point(90, 113);
            this.PBoxGaleria.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxGaleria.Name = "PBoxGaleria";
            this.PBoxGaleria.Size = new System.Drawing.Size(49, 42);
            this.PBoxGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxGaleria.TabIndex = 3;
            this.PBoxGaleria.TabStop = false;
            // 
            // PBoxRegistroCandidata
            // 
            this.PBoxRegistroCandidata.BackColor = System.Drawing.SystemColors.Control;
            this.PBoxRegistroCandidata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxRegistroCandidata.Image = ((System.Drawing.Image)(resources.GetObject("PBoxRegistroCandidata.Image")));
            this.PBoxRegistroCandidata.Location = new System.Drawing.Point(221, 41);
            this.PBoxRegistroCandidata.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxRegistroCandidata.Name = "PBoxRegistroCandidata";
            this.PBoxRegistroCandidata.Size = new System.Drawing.Size(46, 42);
            this.PBoxRegistroCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxRegistroCandidata.TabIndex = 2;
            this.PBoxRegistroCandidata.TabStop = false;
            // 
            // ModuloAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(339, 263);
            this.Controls.Add(this.BtnResultados);
            this.Controls.Add(this.PBoxResultados);
            this.Controls.Add(this.PBoxGaleria);
            this.Controls.Add(this.PBoxRegistroCandidata);
            this.Controls.Add(this.BtnRegistroFoto);
            this.Controls.Add(this.BtnInscripcionCandidatas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModuloAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInscripcionCandidatas;
        private System.Windows.Forms.Button BtnRegistroFoto;
        private System.Windows.Forms.PictureBox PBoxRegistroCandidata;
        private System.Windows.Forms.PictureBox PBoxGaleria;
        private System.Windows.Forms.PictureBox PBoxResultados;
        private System.Windows.Forms.Button BtnResultados;
    }
}