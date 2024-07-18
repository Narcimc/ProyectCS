namespace SIEleccionReina.Formularios
{
    partial class FrmEstudiante
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
            this.BtnVerCandidatas = new System.Windows.Forms.Button();
            this.BtnVotarPorFotogenica = new System.Windows.Forms.Button();
            this.BtnVotoReina = new System.Windows.Forms.Button();
            this.PBoxResultados = new System.Windows.Forms.PictureBox();
            this.PBoxGaleria = new System.Windows.Forms.PictureBox();
            this.PBoxRegistroCandidata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerCandidatas
            // 
            this.BtnVerCandidatas.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnVerCandidatas.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCandidatas.Location = new System.Drawing.Point(41, 26);
            this.BtnVerCandidatas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerCandidatas.Name = "BtnVerCandidatas";
            this.BtnVerCandidatas.Size = new System.Drawing.Size(188, 41);
            this.BtnVerCandidatas.TabIndex = 11;
            this.BtnVerCandidatas.Text = "Ver Candidatas ";
            this.BtnVerCandidatas.UseVisualStyleBackColor = false;
            this.BtnVerCandidatas.Click += new System.EventHandler(this.BtnVerCandidatas_Click);
            // 
            // BtnVotarPorFotogenica
            // 
            this.BtnVotarPorFotogenica.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnVotarPorFotogenica.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVotarPorFotogenica.Location = new System.Drawing.Point(36, 170);
            this.BtnVotarPorFotogenica.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVotarPorFotogenica.Name = "BtnVotarPorFotogenica";
            this.BtnVotarPorFotogenica.Size = new System.Drawing.Size(188, 41);
            this.BtnVotarPorFotogenica.TabIndex = 7;
            this.BtnVotarPorFotogenica.Text = "Votar por fotogenica";
            this.BtnVotarPorFotogenica.UseVisualStyleBackColor = false;
            this.BtnVotarPorFotogenica.Click += new System.EventHandler(this.BtnVotarPorFotogenica_Click);
            // 
            // BtnVotoReina
            // 
            this.BtnVotoReina.BackColor = System.Drawing.Color.Plum;
            this.BtnVotoReina.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnVotoReina.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVotoReina.Location = new System.Drawing.Point(155, 98);
            this.BtnVotoReina.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVotoReina.Name = "BtnVotoReina";
            this.BtnVotoReina.Size = new System.Drawing.Size(206, 41);
            this.BtnVotoReina.TabIndex = 6;
            this.BtnVotoReina.Text = "Votar por Reina ";
            this.BtnVotoReina.UseVisualStyleBackColor = false;
            this.BtnVotoReina.Click += new System.EventHandler(this.BtnVotoReina_Click);
            // 
            // PBoxResultados
            // 
            this.PBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxResultados.Image = global::SIEleccionReina.Properties.Resources.Fotogeica;
            this.PBoxResultados.Location = new System.Drawing.Point(228, 169);
            this.PBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxResultados.Name = "PBoxResultados";
            this.PBoxResultados.Size = new System.Drawing.Size(51, 42);
            this.PBoxResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxResultados.TabIndex = 10;
            this.PBoxResultados.TabStop = false;
            // 
            // PBoxGaleria
            // 
            this.PBoxGaleria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxGaleria.Image = global::SIEleccionReina.Properties.Resources.Candidata1;
            this.PBoxGaleria.Location = new System.Drawing.Point(102, 97);
            this.PBoxGaleria.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxGaleria.Name = "PBoxGaleria";
            this.PBoxGaleria.Size = new System.Drawing.Size(49, 42);
            this.PBoxGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxGaleria.TabIndex = 9;
            this.PBoxGaleria.TabStop = false;
            // 
            // PBoxRegistroCandidata
            // 
            this.PBoxRegistroCandidata.BackColor = System.Drawing.SystemColors.Control;
            this.PBoxRegistroCandidata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxRegistroCandidata.Image = global::SIEleccionReina.Properties.Resources.CandidataLogo;
            this.PBoxRegistroCandidata.Location = new System.Drawing.Point(233, 25);
            this.PBoxRegistroCandidata.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxRegistroCandidata.Name = "PBoxRegistroCandidata";
            this.PBoxRegistroCandidata.Size = new System.Drawing.Size(46, 42);
            this.PBoxRegistroCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxRegistroCandidata.TabIndex = 8;
            this.PBoxRegistroCandidata.TabStop = false;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 236);
            this.Controls.Add(this.BtnVerCandidatas);
            this.Controls.Add(this.PBoxResultados);
            this.Controls.Add(this.PBoxGaleria);
            this.Controls.Add(this.PBoxRegistroCandidata);
            this.Controls.Add(this.BtnVotarPorFotogenica);
            this.Controls.Add(this.BtnVotoReina);
            this.Name = "FrmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerCandidatas;
        private System.Windows.Forms.PictureBox PBoxResultados;
        private System.Windows.Forms.PictureBox PBoxGaleria;
        private System.Windows.Forms.PictureBox PBoxRegistroCandidata;
        private System.Windows.Forms.Button BtnVotarPorFotogenica;
        private System.Windows.Forms.Button BtnVotoReina;
    }
}