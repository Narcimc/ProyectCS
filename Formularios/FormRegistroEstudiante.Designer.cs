namespace SIEleccionReina.Formularios
{
    partial class FormRegistroEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.MTxtUsuarioCI = new System.Windows.Forms.MaskedTextBox();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.PBVerContrasenia = new System.Windows.Forms.PictureBox();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblUsuarioIndicacion = new System.Windows.Forms.Label();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.NUDSemestre = new System.Windows.Forms.NumericUpDown();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.PBVerConfirmContrasenia = new System.Windows.Forms.PictureBox();
            this.TxtConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.LblConfirmarContrasenia = new System.Windows.Forms.Label();
            this.EPRegistroEstudiante = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSemestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerConfirmContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRegistroEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Estudiantil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(241, 527);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(205, 40);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(19, 96);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(95, 20);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Usuario(C.I.): ";
            // 
            // MTxtUsuarioCI
            // 
            this.MTxtUsuarioCI.AllowPromptAsInput = false;
            this.MTxtUsuarioCI.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MTxtUsuarioCI.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtUsuarioCI.HidePromptOnLeave = true;
            this.MTxtUsuarioCI.Location = new System.Drawing.Point(146, 93);
            this.MTxtUsuarioCI.Mask = "000 000 0000";
            this.MTxtUsuarioCI.Name = "MTxtUsuarioCI";
            this.MTxtUsuarioCI.PromptChar = ' ';
            this.MTxtUsuarioCI.Size = new System.Drawing.Size(300, 27);
            this.MTxtUsuarioCI.TabIndex = 0;
            this.MTxtUsuarioCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxtUsuarioCI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.BackColor = System.Drawing.Color.Transparent;
            this.LblCarrera.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(19, 313);
            this.LblCarrera.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(64, 20);
            this.LblCarrera.TabIndex = 5;
            this.LblCarrera.Text = "Carrera: ";
            // 
            // PBVerContrasenia
            // 
            this.PBVerContrasenia.BackColor = System.Drawing.Color.White;
            this.PBVerContrasenia.Image = global::SIEleccionReina.Properties.Resources.ver;
            this.PBVerContrasenia.Location = new System.Drawing.Point(421, 409);
            this.PBVerContrasenia.Name = "PBVerContrasenia";
            this.PBVerContrasenia.Size = new System.Drawing.Size(20, 20);
            this.PBVerContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVerContrasenia.TabIndex = 15;
            this.PBVerContrasenia.TabStop = false;
            this.PBVerContrasenia.Click += new System.EventHandler(this.PBVerContrasenia_Click);
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarrera.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Items.AddRange(new object[] {
            "Ciencia de Datos e Inteligencia Artificial"});
            this.CmbCarrera.Location = new System.Drawing.Point(146, 310);
            this.CmbCarrera.Margin = new System.Windows.Forms.Padding(3, 20, 30, 3);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(300, 28);
            this.CmbCarrera.TabIndex = 2;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.Violet;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(20, 527);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2, 34, 2, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(205, 40);
            this.BtnRegistrar.TabIndex = 6;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenia.Location = new System.Drawing.Point(146, 406);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(3, 15, 2, 2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.Size = new System.Drawing.Size(300, 27);
            this.TxtContrasenia.TabIndex = 4;
            this.TxtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.LblContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(19, 409);
            this.LblContrasenia.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(86, 20);
            this.LblContrasenia.TabIndex = 11;
            this.LblContrasenia.Text = "Contraseña:";
            this.LblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUsuarioIndicacion
            // 
            this.LblUsuarioIndicacion.AutoSize = true;
            this.LblUsuarioIndicacion.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuarioIndicacion.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioIndicacion.Location = new System.Drawing.Point(20, 126);
            this.LblUsuarioIndicacion.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblUsuarioIndicacion.Name = "LblUsuarioIndicacion";
            this.LblUsuarioIndicacion.Size = new System.Drawing.Size(303, 13);
            this.LblUsuarioIndicacion.TabIndex = 16;
            this.LblUsuarioIndicacion.Text = "El Usuario debe ser la Cédula de Identidad del Estudiante";
            this.LblUsuarioIndicacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.BackColor = System.Drawing.Color.Transparent;
            this.LblSemestre.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemestre.Location = new System.Drawing.Point(19, 363);
            this.LblSemestre.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(77, 20);
            this.LblSemestre.TabIndex = 17;
            this.LblSemestre.Text = "Semestre: ";
            // 
            // NUDSemestre
            // 
            this.NUDSemestre.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSemestre.Location = new System.Drawing.Point(146, 361);
            this.NUDSemestre.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.NUDSemestre.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDSemestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDSemestre.Name = "NUDSemestre";
            this.NUDSemestre.Size = new System.Drawing.Size(300, 27);
            this.NUDSemestre.TabIndex = 3;
            this.NUDSemestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(146, 159);
            this.CmbTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 20, 30, 3);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(300, 28);
            this.CmbTipoUsuario.TabIndex = 1;
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoUsuario.Location = new System.Drawing.Point(19, 162);
            this.LblTipoUsuario.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(121, 20);
            this.LblTipoUsuario.TabIndex = 19;
            this.LblTipoUsuario.Text = "Tipo de Usuario: ";
            // 
            // PBVerConfirmContrasenia
            // 
            this.PBVerConfirmContrasenia.BackColor = System.Drawing.Color.White;
            this.PBVerConfirmContrasenia.Image = global::SIEleccionReina.Properties.Resources.ver;
            this.PBVerConfirmContrasenia.Location = new System.Drawing.Point(421, 467);
            this.PBVerConfirmContrasenia.Name = "PBVerConfirmContrasenia";
            this.PBVerConfirmContrasenia.Size = new System.Drawing.Size(20, 20);
            this.PBVerConfirmContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVerConfirmContrasenia.TabIndex = 23;
            this.PBVerConfirmContrasenia.TabStop = false;
            this.PBVerConfirmContrasenia.Click += new System.EventHandler(this.PBVerConfirmContrasenia_Click);
            // 
            // TxtConfirmarContrasenia
            // 
            this.TxtConfirmarContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmarContrasenia.Location = new System.Drawing.Point(146, 464);
            this.TxtConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(3, 15, 2, 2);
            this.TxtConfirmarContrasenia.Name = "TxtConfirmarContrasenia";
            this.TxtConfirmarContrasenia.PasswordChar = '*';
            this.TxtConfirmarContrasenia.Size = new System.Drawing.Size(300, 27);
            this.TxtConfirmarContrasenia.TabIndex = 5;
            this.TxtConfirmarContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblConfirmarContrasenia
            // 
            this.LblConfirmarContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.LblConfirmarContrasenia.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmarContrasenia.Location = new System.Drawing.Point(19, 453);
            this.LblConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.LblConfirmarContrasenia.Name = "LblConfirmarContrasenia";
            this.LblConfirmarContrasenia.Size = new System.Drawing.Size(86, 48);
            this.LblConfirmarContrasenia.TabIndex = 21;
            this.LblConfirmarContrasenia.Text = "Confirmar Contraseña:";
            this.LblConfirmarContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EPRegistroEstudiante
            // 
            this.EPRegistroEstudiante.ContainerControl = this;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.BackColor = System.Drawing.Color.Transparent;
            this.LblNombres.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(19, 213);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(77, 20);
            this.LblNombres.TabIndex = 25;
            this.LblNombres.Text = "Nombres: ";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.LblApellidos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(19, 263);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(79, 20);
            this.LblApellidos.TabIndex = 27;
            this.LblApellidos.Text = "Apellidos: ";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(146, 210);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtNombres.MaxLength = 50;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(300, 27);
            this.TxtNombres.TabIndex = 28;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(146, 260);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtApellidos.MaxLength = 50;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(300, 27);
            this.TxtApellidos.TabIndex = 29;
            // 
            // FormRegistroEstudiante
            // 
            this.AcceptButton = this.BtnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoazul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(474, 591);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.PBVerConfirmContrasenia);
            this.Controls.Add(this.TxtConfirmarContrasenia);
            this.Controls.Add(this.LblConfirmarContrasenia);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.LblTipoUsuario);
            this.Controls.Add(this.NUDSemestre);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.LblUsuarioIndicacion);
            this.Controls.Add(this.PBVerContrasenia);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.MTxtUsuarioCI);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRegistroEstudiante";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Estudiante";
            this.Load += new System.EventHandler(this.FormRegistroEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBVerContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSemestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVerConfirmContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRegistroEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.MaskedTextBox MTxtUsuarioCI;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.PictureBox PBVerContrasenia;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblUsuarioIndicacion;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.NumericUpDown NUDSemestre;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.PictureBox PBVerConfirmContrasenia;
        private System.Windows.Forms.TextBox TxtConfirmarContrasenia;
        private System.Windows.Forms.Label LblConfirmarContrasenia;
        private System.Windows.Forms.ErrorProvider EPRegistroEstudiante;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
    }
}