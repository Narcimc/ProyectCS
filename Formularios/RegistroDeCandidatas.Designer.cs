namespace SIEleccionReina
{
    partial class RegistroDeCandidatas
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.DateFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblEdad = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LblAspiraciones = new System.Windows.Forms.Label();
            this.TxtAspiraciones = new System.Windows.Forms.TextBox();
            this.TxtIntereses = new System.Windows.Forms.TextBox();
            this.LblIntereses = new System.Windows.Forms.Label();
            this.TxtHabilidades = new System.Windows.Forms.TextBox();
            this.LblHabilidades = new System.Windows.Forms.Label();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardarRegistro = new System.Windows.Forms.Button();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.PBoxFotografia = new System.Windows.Forms.PictureBox();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.CmbSemestre = new System.Windows.Forms.ComboBox();
            this.OpenFilaFoto = new System.Windows.Forms.OpenFileDialog();
            this.TxtDescripcionImage = new System.Windows.Forms.TextBox();
            this.btnCrearAlbum = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxFotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(90, 43);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombre.Size = new System.Drawing.Size(181, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(12, 45);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(68, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre: ";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.SystemColors.Control;
            this.LblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblApellido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(288, 45);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(68, 17);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido:";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblApellido.Click += new System.EventHandler(this.LblApellido_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(365, 43);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(165, 23);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.BackColor = System.Drawing.SystemColors.Control;
            this.LblCedula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCedula.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(12, 73);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(143, 17);
            this.LblCedula.TabIndex = 5;
            this.LblCedula.Text = "Cédula de Identidad:";
            this.LblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(179, 72);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(91, 23);
            this.TxtCedula.TabIndex = 4;
            this.TxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCedula.TextChanged += new System.EventHandler(this.TxtCedula_TextChanged);
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.LblFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(12, 105);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(148, 17);
            this.LblFechaNacimiento.TabIndex = 6;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.LblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFechaNacimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateFechaDeNacimiento
            // 
            this.DateFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaDeNacimiento.Location = new System.Drawing.Point(179, 105);
            this.DateFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DateFechaDeNacimiento.MinDate = new System.DateTime(1848, 1, 1, 0, 0, 0, 0);
            this.DateFechaDeNacimiento.Name = "DateFechaDeNacimiento";
            this.DateFechaDeNacimiento.Size = new System.Drawing.Size(84, 20);
            this.DateFechaDeNacimiento.TabIndex = 7;
            this.DateFechaDeNacimiento.TabStop = false;
            this.DateFechaDeNacimiento.Value = new System.DateTime(2024, 1, 9, 8, 24, 7, 0);
            this.DateFechaDeNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.BackColor = System.Drawing.SystemColors.Control;
            this.LblEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEdad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.Location = new System.Drawing.Point(288, 73);
            this.LblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(47, 17);
            this.LblEdad.TabIndex = 8;
            this.LblEdad.Text = "Edad:";
            this.LblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(347, 73);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(44, 23);
            this.TxtEdad.TabIndex = 9;
            this.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdad_KeyPress);
            // 
            // LblAspiraciones
            // 
            this.LblAspiraciones.AutoSize = true;
            this.LblAspiraciones.BackColor = System.Drawing.SystemColors.Control;
            this.LblAspiraciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAspiraciones.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAspiraciones.Location = new System.Drawing.Point(333, 171);
            this.LblAspiraciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAspiraciones.Name = "LblAspiraciones";
            this.LblAspiraciones.Size = new System.Drawing.Size(98, 17);
            this.LblAspiraciones.TabIndex = 10;
            this.LblAspiraciones.Text = "Aspiraciones:";
            this.LblAspiraciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAspiraciones.Click += new System.EventHandler(this.LblAspiraciones_Click);
            // 
            // TxtAspiraciones
            // 
            this.TxtAspiraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAspiraciones.Location = new System.Drawing.Point(441, 171);
            this.TxtAspiraciones.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAspiraciones.Name = "TxtAspiraciones";
            this.TxtAspiraciones.Size = new System.Drawing.Size(193, 23);
            this.TxtAspiraciones.TabIndex = 11;
            this.TxtAspiraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtAspiraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAspiraciones_KeyPress);
            // 
            // TxtIntereses
            // 
            this.TxtIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntereses.Location = new System.Drawing.Point(97, 138);
            this.TxtIntereses.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIntereses.Name = "TxtIntereses";
            this.TxtIntereses.Size = new System.Drawing.Size(215, 23);
            this.TxtIntereses.TabIndex = 13;
            this.TxtIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtIntereses.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIntereses_KeyPress);
            // 
            // LblIntereses
            // 
            this.LblIntereses.AutoSize = true;
            this.LblIntereses.BackColor = System.Drawing.SystemColors.Control;
            this.LblIntereses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIntereses.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntereses.Location = new System.Drawing.Point(12, 138);
            this.LblIntereses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIntereses.Name = "LblIntereses";
            this.LblIntereses.Size = new System.Drawing.Size(73, 17);
            this.LblIntereses.TabIndex = 12;
            this.LblIntereses.Text = "Intereses:";
            this.LblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtHabilidades
            // 
            this.TxtHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabilidades.Location = new System.Drawing.Point(437, 138);
            this.TxtHabilidades.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabilidades.Name = "TxtHabilidades";
            this.TxtHabilidades.Size = new System.Drawing.Size(197, 23);
            this.TxtHabilidades.TabIndex = 15;
            this.TxtHabilidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtHabilidades.TextChanged += new System.EventHandler(this.TxtHabilidades_TextChanged);
            this.TxtHabilidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHabilidades_KeyPress);
            // 
            // LblHabilidades
            // 
            this.LblHabilidades.AutoSize = true;
            this.LblHabilidades.BackColor = System.Drawing.SystemColors.Control;
            this.LblHabilidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHabilidades.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHabilidades.Location = new System.Drawing.Point(333, 138);
            this.LblHabilidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHabilidades.Name = "LblHabilidades";
            this.LblHabilidades.Size = new System.Drawing.Size(93, 17);
            this.LblHabilidades.TabIndex = 14;
            this.LblHabilidades.Text = "Habilidades:";
            this.LblHabilidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.AutoSize = true;
            this.BtnCargarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCargarFoto.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnCargarFoto.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargarFoto.Location = new System.Drawing.Point(12, 176);
            this.BtnCargarFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(73, 24);
            this.BtnCargarFoto.TabIndex = 16;
            this.BtnCargarFoto.Text = "Cargar Foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = false;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Thistle;
            this.LblTitulo.Font = new System.Drawing.Font("Script MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(175, 9);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(244, 23);
            this.LblTitulo.TabIndex = 17;
            this.LblTitulo.Text = "Registro Fichas de Candidatas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuardarRegistro
            // 
            this.BtnGuardarRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardarRegistro.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnGuardarRegistro.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarRegistro.Location = new System.Drawing.Point(376, 215);
            this.BtnGuardarRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarRegistro.Name = "BtnGuardarRegistro";
            this.BtnGuardarRegistro.Size = new System.Drawing.Size(134, 25);
            this.BtnGuardarRegistro.TabIndex = 18;
            this.BtnGuardarRegistro.Text = "Guardar";
            this.BtnGuardarRegistro.UseVisualStyleBackColor = false;
            this.BtnGuardarRegistro.Click += new System.EventHandler(this.BtnGuardarRegistro_Click);
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Location = new System.Drawing.Point(480, 76);
            this.CmbCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(154, 21);
            this.CmbCarrera.TabIndex = 20;
            this.CmbCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.BackColor = System.Drawing.SystemColors.Control;
            this.LblCarrera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCarrera.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(404, 75);
            this.LblCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(65, 17);
            this.LblCarrera.TabIndex = 21;
            this.LblCarrera.Text = "Carrera:";
            this.LblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBoxFotografia
            // 
            this.PBoxFotografia.Location = new System.Drawing.Point(12, 227);
            this.PBoxFotografia.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxFotografia.Name = "PBoxFotografia";
            this.PBoxFotografia.Size = new System.Drawing.Size(235, 116);
            this.PBoxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxFotografia.TabIndex = 22;
            this.PBoxFotografia.TabStop = false;
            this.PBoxFotografia.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.BackColor = System.Drawing.SystemColors.Control;
            this.LblSemestre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSemestre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemestre.Location = new System.Drawing.Point(288, 111);
            this.LblSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(73, 17);
            this.LblSemestre.TabIndex = 24;
            this.LblSemestre.Text = "Semestre:";
            this.LblSemestre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbSemestre
            // 
            this.CmbSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSemestre.FormattingEnabled = true;
            this.CmbSemestre.Location = new System.Drawing.Point(376, 107);
            this.CmbSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.CmbSemestre.Name = "CmbSemestre";
            this.CmbSemestre.Size = new System.Drawing.Size(83, 21);
            this.CmbSemestre.TabIndex = 23;
            this.CmbSemestre.SelectedIndexChanged += new System.EventHandler(this.CmbSemestre_SelectedIndexChanged);
            // 
            // OpenFilaFoto
            // 
            this.OpenFilaFoto.FileName = "Cargar Foto";
            // 
            // TxtDescripcionImage
            // 
            this.TxtDescripcionImage.Location = new System.Drawing.Point(10, 203);
            this.TxtDescripcionImage.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcionImage.Name = "TxtDescripcionImage";
            this.TxtDescripcionImage.Size = new System.Drawing.Size(237, 20);
            this.TxtDescripcionImage.TabIndex = 25;
            this.TxtDescripcionImage.TextChanged += new System.EventHandler(this.TxtDescripcionImage_TextChanged);
            // 
            // btnCrearAlbum
            // 
            this.btnCrearAlbum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearAlbum.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCrearAlbum.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearAlbum.Location = new System.Drawing.Point(376, 259);
            this.btnCrearAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearAlbum.Name = "btnCrearAlbum";
            this.btnCrearAlbum.Size = new System.Drawing.Size(214, 25);
            this.btnCrearAlbum.TabIndex = 26;
            this.btnCrearAlbum.Text = "Agregar Album para Candidata";
            this.btnCrearAlbum.UseVisualStyleBackColor = false;
            this.btnCrearAlbum.Click += new System.EventHandler(this.btnCrearAlbum_Click);
            // 
            // bntSalir
            // 
            this.bntSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntSalir.BackColor = System.Drawing.Color.Orchid;
            this.bntSalir.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSalir.Location = new System.Drawing.Point(515, 328);
            this.bntSalir.Margin = new System.Windows.Forms.Padding(2);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(134, 25);
            this.bntSalir.TabIndex = 27;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = false;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // RegistroDeCandidatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoazul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 354);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btnCrearAlbum);
            this.Controls.Add(this.TxtDescripcionImage);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.CmbSemestre);
            this.Controls.Add(this.PBoxFotografia);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.BtnGuardarRegistro);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.TxtHabilidades);
            this.Controls.Add(this.LblHabilidades);
            this.Controls.Add(this.TxtIntereses);
            this.Controls.Add(this.LblIntereses);
            this.Controls.Add(this.TxtAspiraciones);
            this.Controls.Add(this.LblAspiraciones);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.DateFechaDeNacimiento);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroDeCandidatas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Candidatas";
            this.Load += new System.EventHandler(this.RegistroDeCandidatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxFotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker DateFechaDeNacimiento;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label LblAspiraciones;
        private System.Windows.Forms.TextBox TxtAspiraciones;
        private System.Windows.Forms.TextBox TxtIntereses;
        private System.Windows.Forms.Label LblIntereses;
        private System.Windows.Forms.TextBox TxtHabilidades;
        private System.Windows.Forms.Label LblHabilidades;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnGuardarRegistro;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.PictureBox PBoxFotografia;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.ComboBox CmbSemestre;
        private System.Windows.Forms.OpenFileDialog OpenFilaFoto;
        private System.Windows.Forms.TextBox TxtDescripcionImage;
        private System.Windows.Forms.Button btnCrearAlbum;
        private System.Windows.Forms.Button bntSalir;
    }
}