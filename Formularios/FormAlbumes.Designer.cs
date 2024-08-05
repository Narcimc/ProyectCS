namespace SIEleccionReina.Formularios
{
    partial class FormAlbumes
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
            this.LblRegistroAlbum = new System.Windows.Forms.Label();
            this.LblTituloAlbum = new System.Windows.Forms.Label();
            this.LblCandidata = new System.Windows.Forms.Label();
            this.TxtTituloAlbum = new System.Windows.Forms.TextBox();
            this.CmbCandidata = new System.Windows.Forms.ComboBox();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRegistroAlbum
            // 
            this.LblRegistroAlbum.AutoSize = true;
            this.LblRegistroAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblRegistroAlbum.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroAlbum.Location = new System.Drawing.Point(94, 23);
            this.LblRegistroAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRegistroAlbum.Name = "LblRegistroAlbum";
            this.LblRegistroAlbum.Size = new System.Drawing.Size(134, 16);
            this.LblRegistroAlbum.TabIndex = 0;
            this.LblRegistroAlbum.Text = "Registro de Album";
            // 
            // LblTituloAlbum
            // 
            this.LblTituloAlbum.AutoSize = true;
            this.LblTituloAlbum.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAlbum.Location = new System.Drawing.Point(15, 100);
            this.LblTituloAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloAlbum.Name = "LblTituloAlbum";
            this.LblTituloAlbum.Size = new System.Drawing.Size(102, 16);
            this.LblTituloAlbum.TabIndex = 1;
            this.LblTituloAlbum.Text = "Titulo Album:";
            // 
            // LblCandidata
            // 
            this.LblCandidata.AutoSize = true;
            this.LblCandidata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblCandidata.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCandidata.Location = new System.Drawing.Point(19, 61);
            this.LblCandidata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCandidata.Name = "LblCandidata";
            this.LblCandidata.Size = new System.Drawing.Size(81, 16);
            this.LblCandidata.TabIndex = 2;
            this.LblCandidata.Text = "Candidata:";
            // 
            // TxtTituloAlbum
            // 
            this.TxtTituloAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTituloAlbum.Location = new System.Drawing.Point(116, 96);
            this.TxtTituloAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTituloAlbum.Name = "TxtTituloAlbum";
            this.TxtTituloAlbum.Size = new System.Drawing.Size(182, 23);
            this.TxtTituloAlbum.TabIndex = 3;
            // 
            // CmbCandidata
            // 
            this.CmbCandidata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCandidata.FormattingEnabled = true;
            this.CmbCandidata.Location = new System.Drawing.Point(116, 57);
            this.CmbCandidata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCandidata.Name = "CmbCandidata";
            this.CmbCandidata.Size = new System.Drawing.Size(182, 24);
            this.CmbCandidata.TabIndex = 4;
            this.CmbCandidata.SelectedIndexChanged += new System.EventHandler(this.CmbCandidata_SelectedIndexChanged);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.BackColor = System.Drawing.Color.Violet;
            this.BTNGuardar.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Location = new System.Drawing.Point(55, 132);
            this.BTNGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(88, 27);
            this.BTNGuardar.TabIndex = 5;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = false;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.Violet;
            this.BTNLimpiar.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Location = new System.Drawing.Point(179, 132);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(88, 27);
            this.BTNLimpiar.TabIndex = 6;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // FRMAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(335, 174);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.CmbCandidata);
            this.Controls.Add(this.TxtTituloAlbum);
            this.Controls.Add(this.LblCandidata);
            this.Controls.Add(this.LblTituloAlbum);
            this.Controls.Add(this.LblRegistroAlbum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMAlbum";
            this.Text = "FRMAlbum";
            this.Load += new System.EventHandler(this.FRMAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistroAlbum;
        private System.Windows.Forms.Label LblTituloAlbum;
        private System.Windows.Forms.Label LblCandidata;
        private System.Windows.Forms.TextBox TxtTituloAlbum;
        private System.Windows.Forms.ComboBox CmbCandidata;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNLimpiar;
    }
}