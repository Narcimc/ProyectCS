namespace SIEleccionReina
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PBLogoUG = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnRegistrarme = new System.Windows.Forms.Button();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.PBVerContrasenia = new System.Windows.Forms.PictureBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.LblFacultad = new System.Windows.Forms.Label();
            this.PBLogoFacultad = new System.Windows.Forms.PictureBox();
            this.EPLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.TmrErrorClear = new System.Windows.Forms.Timer(this.components);
            this.MTxtUsuarioCI = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoUG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoFacultad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitulo.Location = new System.Drawing.Point(11, 98);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 34, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(392, 44);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Elección de Reina";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBLogoUG
            // 
            this.PBLogoUG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBLogoUG.BackColor = System.Drawing.Color.Transparent;
            this.PBLogoUG.Image = global::SIEleccionReina.Properties.Resources.Logo_UG_Imagotipo_horizontal_941x206;
            this.PBLogoUG.Location = new System.Drawing.Point(11, 24);
            this.PBLogoUG.Margin = new System.Windows.Forms.Padding(2);
            this.PBLogoUG.Name = "PBLogoUG";
            this.PBLogoUG.Size = new System.Drawing.Size(392, 38);
            this.PBLogoUG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogoUG.TabIndex = 1;
            this.PBLogoUG.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(39, 263);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(30, 17, 3, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(62, 20);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario:";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.LblContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(39, 307);
            this.LblContrasenia.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(86, 20);
            this.LblContrasenia.TabIndex = 4;
            this.LblContrasenia.Text = "Contraseña:";
            this.LblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.Location = new System.Drawing.Point(137, 304);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(3, 15, 2, 2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(238, 27);
            this.TxtContrasenia.TabIndex = 1;
            this.TxtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasenia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtContrasenia_KeyUp);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.Violet;
            this.BtnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(43, 369);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 34, 2, 2);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(332, 40);
            this.BtnIniciarSesion.TabIndex = 2;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnRegistrarme
            // 
            this.BtnRegistrarme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRegistrarme.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnRegistrarme.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarme.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnRegistrarme.Location = new System.Drawing.Point(134, 421);
            this.BtnRegistrarme.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.BtnRegistrarme.Name = "BtnRegistrarme";
            this.BtnRegistrarme.Size = new System.Drawing.Size(150, 38);
            this.BtnRegistrarme.TabIndex = 3;
            this.BtnRegistrarme.Text = "Registrarme";
            this.BtnRegistrarme.UseVisualStyleBackColor = false;
            this.BtnRegistrarme.Click += new System.EventHandler(this.BtnRegistrarme_Click);
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(167, 214);
            this.CmbTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(208, 28);
            this.CmbTipoUsuario.TabIndex = 4;
            // 
            // PBVerContrasenia
            // 
            this.PBVerContrasenia.BackColor = System.Drawing.Color.White;
            this.PBVerContrasenia.Image = global::SIEleccionReina.Properties.Resources.ver;
            this.PBVerContrasenia.Location = new System.Drawing.Point(350, 307);
            this.PBVerContrasenia.Name = "PBVerContrasenia";
            this.PBVerContrasenia.Size = new System.Drawing.Size(20, 20);
            this.PBVerContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVerContrasenia.TabIndex = 10;
            this.PBVerContrasenia.TabStop = false;
            this.PBVerContrasenia.Click += new System.EventHandler(this.PBVerContrasenia_Click);
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoUsuario.Location = new System.Drawing.Point(39, 217);
            this.LblTipoUsuario.Margin = new System.Windows.Forms.Padding(30, 34, 3, 0);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(117, 20);
            this.LblTipoUsuario.TabIndex = 11;
            this.LblTipoUsuario.Text = "Tipo de Usuario:";
            this.LblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFacultad
            // 
            this.LblFacultad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFacultad.BackColor = System.Drawing.Color.Transparent;
            this.LblFacultad.Font = new System.Drawing.Font("Alata", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFacultad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblFacultad.Location = new System.Drawing.Point(11, 142);
            this.LblFacultad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFacultad.Name = "LblFacultad";
            this.LblFacultad.Size = new System.Drawing.Size(392, 44);
            this.LblFacultad.TabIndex = 12;
            this.LblFacultad.Text = "Facultad de Ciencias Matemáticas y Físicas";
            this.LblFacultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBLogoFacultad
            // 
            this.PBLogoFacultad.BackColor = System.Drawing.Color.Transparent;
            this.PBLogoFacultad.Image = global::SIEleccionReina.Properties.Resources.Logo_Facultad_CMF;
            this.PBLogoFacultad.Location = new System.Drawing.Point(11, 11);
            this.PBLogoFacultad.Margin = new System.Windows.Forms.Padding(2);
            this.PBLogoFacultad.Name = "PBLogoFacultad";
            this.PBLogoFacultad.Size = new System.Drawing.Size(72, 60);
            this.PBLogoFacultad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogoFacultad.TabIndex = 13;
            this.PBLogoFacultad.TabStop = false;
            // 
            // EPLogin
            // 
            this.EPLogin.ContainerControl = this;
            // 
            // TmrErrorClear
            // 
            this.TmrErrorClear.Interval = 20000;
            this.TmrErrorClear.Tick += new System.EventHandler(this.TmrErrorClear_Tick);
            // 
            // MTxtUsuarioCI
            // 
            this.MTxtUsuarioCI.AllowPromptAsInput = false;
            this.MTxtUsuarioCI.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MTxtUsuarioCI.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtUsuarioCI.HidePromptOnLeave = true;
            this.MTxtUsuarioCI.Location = new System.Drawing.Point(137, 259);
            this.MTxtUsuarioCI.Mask = "0000000000";
            this.MTxtUsuarioCI.Name = "MTxtUsuarioCI";
            this.MTxtUsuarioCI.Size = new System.Drawing.Size(238, 27);
            this.MTxtUsuarioCI.TabIndex = 0;
            this.MTxtUsuarioCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxtUsuarioCI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MTxtUsuarioCI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MTxtUsuarioCI_KeyUp);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(414, 481);
            this.Controls.Add(this.MTxtUsuarioCI);
            this.Controls.Add(this.PBLogoFacultad);
            this.Controls.Add(this.LblFacultad);
            this.Controls.Add(this.PBVerContrasenia);
            this.Controls.Add(this.LblTipoUsuario);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.BtnRegistrarme);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.PBLogoUG);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Integral de Reinado de Facultad";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoUG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoFacultad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PBLogoUG;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnRegistrarme;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.PictureBox PBVerContrasenia;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.Label LblFacultad;
        private System.Windows.Forms.PictureBox PBLogoFacultad;
        private System.Windows.Forms.ErrorProvider EPLogin;
        private System.Windows.Forms.Timer TmrErrorClear;
        private System.Windows.Forms.MaskedTextBox MTxtUsuarioCI;
    }
}

