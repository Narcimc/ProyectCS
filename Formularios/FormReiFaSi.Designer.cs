namespace SIEleccionReina
{
    partial class FormReiFaSi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReiFaSi));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.BtnRecuperarContraseña = new System.Windows.Forms.Button();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.VerContrasenia = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerContrasenia)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitulo.Location = new System.Drawing.Point(99, 61);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(153, 44);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Elección Reina de la Facultad de Matemáticas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(97, 162);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(40, 15);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario:";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(99, 181);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUsuario.Size = new System.Drawing.Size(150, 24);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(97, 225);
            this.LblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(53, 15);
            this.LblContrasenia.TabIndex = 4;
            this.LblContrasenia.Text = "Contraseña:";
            this.LblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.Location = new System.Drawing.Point(99, 241);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContrasenia.Multiline = true;
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(150, 25);
            this.TxtContrasenia.TabIndex = 5;
            this.TxtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasenia.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.Violet;
            this.BtnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.Location = new System.Drawing.Point(99, 290);
            this.BtnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(149, 29);
            this.BtnAcceder.TabIndex = 6;
            this.BtnAcceder.Text = "Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // BtnRecuperarContraseña
            // 
            this.BtnRecuperarContraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRecuperarContraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRecuperarContraseña.Font = new System.Drawing.Font("Script MT Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecuperarContraseña.Location = new System.Drawing.Point(112, 323);
            this.BtnRecuperarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRecuperarContraseña.Name = "BtnRecuperarContraseña";
            this.BtnRecuperarContraseña.Size = new System.Drawing.Size(127, 27);
            this.BtnRecuperarContraseña.TabIndex = 7;
            this.BtnRecuperarContraseña.Text = "Recuperar Contraseña";
            this.BtnRecuperarContraseña.UseVisualStyleBackColor = false;
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(183, 126);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(69, 21);
            this.CmbTipoUsuario.TabIndex = 8;
            this.CmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VerContrasenia
            // 
            this.VerContrasenia.BackColor = System.Drawing.Color.Thistle;
            this.VerContrasenia.Image = global::SIEleccionReina.Properties.Resources.ver;
            this.VerContrasenia.Location = new System.Drawing.Point(254, 241);
            this.VerContrasenia.Name = "VerContrasenia";
            this.VerContrasenia.Size = new System.Drawing.Size(20, 23);
            this.VerContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VerContrasenia.TabIndex = 10;
            this.VerContrasenia.TabStop = false;
            this.VerContrasenia.Click += new System.EventHandler(this.VerContrasenia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FormReiFaSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(340, 366);
            this.Controls.Add(this.VerContrasenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.BtnRecuperarContraseña);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReiFaSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Integral Reinado Facultad";
            this.Load += new System.EventHandler(this.FormReiFaSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerContrasenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Button BtnRecuperarContraseña;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.PictureBox VerContrasenia;
        private System.Windows.Forms.Label label1;
    }
}

