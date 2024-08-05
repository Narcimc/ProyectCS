namespace SIEleccionReina
{
    partial class FormRegistroCandidata
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
            this.DateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnGuardarRegistro = new System.Windows.Forms.Button();
            this.PBoxFotografia = new System.Windows.Forms.PictureBox();
            this.OpenFilaFoto = new System.Windows.Forms.OpenFileDialog();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblEdadCantidad = new System.Windows.Forms.Label();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.NUDSemestre = new System.Windows.Forms.NumericUpDown();
            this.CmbCarrera = new System.Windows.Forms.ComboBox();
            this.MTxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.TxtIntereses = new System.Windows.Forms.TextBox();
            this.LblIntereses = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.TxtHabilidades = new System.Windows.Forms.TextBox();
            this.LblHabilidades = new System.Windows.Forms.Label();
            this.TxtAspiraciones = new System.Windows.Forms.TextBox();
            this.LblAspiraciones = new System.Windows.Forms.Label();
            this.TxtDescriptionImage = new System.Windows.Forms.TextBox();
            this.EPRegistroCandidata = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxFotografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSemestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRegistroCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // DateFechaNacimiento
            // 
            this.DateFechaNacimiento.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaNacimiento.Location = new System.Drawing.Point(181, 192);
            this.DateFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.DateFechaNacimiento.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.DateFechaNacimiento.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.DateFechaNacimiento.Name = "DateFechaNacimiento";
            this.DateFechaNacimiento.Size = new System.Drawing.Size(221, 27);
            this.DateFechaNacimiento.TabIndex = 4;
            this.DateFechaNacimiento.TabStop = false;
            this.DateFechaNacimiento.Value = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.DateFechaNacimiento.ValueChanged += new System.EventHandler(this.DateFechaNacimiento_ValueChanged);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCargarFoto.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnCargarFoto.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargarFoto.Location = new System.Drawing.Point(500, 242);
            this.BtnCargarFoto.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(154, 40);
            this.BtnCargarFoto.TabIndex = 9;
            this.BtnCargarFoto.Text = "Cargar Foto...";
            this.BtnCargarFoto.UseVisualStyleBackColor = false;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(12, 19);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(805, 57);
            this.LblTitulo.TabIndex = 17;
            this.LblTitulo.Text = "Registro Ficha de Candidata";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGuardarRegistro
            // 
            this.BtnGuardarRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardarRegistro.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnGuardarRegistro.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarRegistro.Location = new System.Drawing.Point(125, 627);
            this.BtnGuardarRegistro.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BtnGuardarRegistro.Name = "BtnGuardarRegistro";
            this.BtnGuardarRegistro.Size = new System.Drawing.Size(576, 40);
            this.BtnGuardarRegistro.TabIndex = 10;
            this.BtnGuardarRegistro.Text = "Guardar";
            this.BtnGuardarRegistro.UseVisualStyleBackColor = false;
            this.BtnGuardarRegistro.Click += new System.EventHandler(this.BtnGuardarRegistro_Click);
            // 
            // PBoxFotografia
            // 
            this.PBoxFotografia.Location = new System.Drawing.Point(500, 325);
            this.PBoxFotografia.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.PBoxFotografia.Name = "PBoxFotografia";
            this.PBoxFotografia.Size = new System.Drawing.Size(300, 269);
            this.PBoxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxFotografia.TabIndex = 22;
            this.PBoxFotografia.TabStop = false;
            // 
            // OpenFilaFoto
            // 
            this.OpenFilaFoto.FileName = "Cargar Foto";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.LblApellidos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(415, 96);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(79, 20);
            this.LblApellidos.TabIndex = 33;
            this.LblApellidos.Text = "Apellidos: ";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.BackColor = System.Drawing.Color.Transparent;
            this.LblNombres.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(19, 96);
            this.LblNombres.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(77, 20);
            this.LblNombres.TabIndex = 32;
            this.LblNombres.Text = "Nombres: ";
            // 
            // LblEdadCantidad
            // 
            this.LblEdadCantidad.AutoSize = true;
            this.LblEdadCantidad.BackColor = System.Drawing.Color.Transparent;
            this.LblEdadCantidad.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdadCantidad.Location = new System.Drawing.Point(496, 197);
            this.LblEdadCantidad.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblEdadCantidad.Name = "LblEdadCantidad";
            this.LblEdadCantidad.Size = new System.Drawing.Size(13, 20);
            this.LblEdadCantidad.TabIndex = 31;
            this.LblEdadCantidad.Text = " ";
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.BackColor = System.Drawing.Color.Transparent;
            this.LblSemestre.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemestre.Location = new System.Drawing.Point(614, 197);
            this.LblSemestre.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(77, 20);
            this.LblSemestre.TabIndex = 30;
            this.LblSemestre.Text = "Semestre: ";
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.BackColor = System.Drawing.Color.Transparent;
            this.LblCarrera.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(415, 146);
            this.LblCarrera.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(64, 20);
            this.LblCarrera.TabIndex = 29;
            this.LblCarrera.Text = "Carrera: ";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.BackColor = System.Drawing.Color.Transparent;
            this.LblCedula.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(19, 145);
            this.LblCedula.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(151, 20);
            this.LblCedula.TabIndex = 28;
            this.LblCedula.Text = "Cédula de Identidad: ";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(500, 93);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtApellidos.MaxLength = 50;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(300, 27);
            this.TxtApellidos.TabIndex = 1;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(102, 93);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtNombres.MaxLength = 50;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(300, 27);
            this.TxtNombres.TabIndex = 0;
            // 
            // NUDSemestre
            // 
            this.NUDSemestre.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDSemestre.Location = new System.Drawing.Point(697, 195);
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
            this.NUDSemestre.Size = new System.Drawing.Size(103, 27);
            this.NUDSemestre.TabIndex = 5;
            this.NUDSemestre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbCarrera
            // 
            this.CmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCarrera.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCarrera.FormattingEnabled = true;
            this.CmbCarrera.Items.AddRange(new object[] {
            "Ciencia de Datos e Inteligencia Artificial"});
            this.CmbCarrera.Location = new System.Drawing.Point(500, 143);
            this.CmbCarrera.Margin = new System.Windows.Forms.Padding(3, 20, 30, 3);
            this.CmbCarrera.Name = "CmbCarrera";
            this.CmbCarrera.Size = new System.Drawing.Size(300, 28);
            this.CmbCarrera.TabIndex = 3;
            // 
            // MTxtCedula
            // 
            this.MTxtCedula.AllowPromptAsInput = false;
            this.MTxtCedula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MTxtCedula.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtCedula.HidePromptOnLeave = true;
            this.MTxtCedula.Location = new System.Drawing.Point(181, 142);
            this.MTxtCedula.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.MTxtCedula.Mask = "0000000000";
            this.MTxtCedula.Name = "MTxtCedula";
            this.MTxtCedula.Size = new System.Drawing.Size(221, 27);
            this.MTxtCedula.TabIndex = 2;
            this.MTxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(19, 197);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(156, 20);
            this.LblFechaNacimiento.TabIndex = 39;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento: ";
            // 
            // TxtIntereses
            // 
            this.TxtIntereses.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntereses.Location = new System.Drawing.Point(125, 242);
            this.TxtIntereses.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtIntereses.MaxLength = 255;
            this.TxtIntereses.Multiline = true;
            this.TxtIntereses.Name = "TxtIntereses";
            this.TxtIntereses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtIntereses.Size = new System.Drawing.Size(277, 100);
            this.TxtIntereses.TabIndex = 6;
            // 
            // LblIntereses
            // 
            this.LblIntereses.AutoSize = true;
            this.LblIntereses.BackColor = System.Drawing.Color.Transparent;
            this.LblIntereses.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntereses.Location = new System.Drawing.Point(19, 245);
            this.LblIntereses.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblIntereses.Name = "LblIntereses";
            this.LblIntereses.Size = new System.Drawing.Size(74, 20);
            this.LblIntereses.TabIndex = 40;
            this.LblIntereses.Text = "Intereses: ";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.BackColor = System.Drawing.Color.Transparent;
            this.LblEdad.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdad.Location = new System.Drawing.Point(415, 197);
            this.LblEdad.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(50, 20);
            this.LblEdad.TabIndex = 42;
            this.LblEdad.Text = "Edad: ";
            // 
            // TxtHabilidades
            // 
            this.TxtHabilidades.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHabilidades.Location = new System.Drawing.Point(125, 488);
            this.TxtHabilidades.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtHabilidades.MaxLength = 255;
            this.TxtHabilidades.Multiline = true;
            this.TxtHabilidades.Name = "TxtHabilidades";
            this.TxtHabilidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHabilidades.Size = new System.Drawing.Size(277, 100);
            this.TxtHabilidades.TabIndex = 8;
            // 
            // LblHabilidades
            // 
            this.LblHabilidades.AutoSize = true;
            this.LblHabilidades.BackColor = System.Drawing.Color.Transparent;
            this.LblHabilidades.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHabilidades.Location = new System.Drawing.Point(19, 491);
            this.LblHabilidades.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblHabilidades.Name = "LblHabilidades";
            this.LblHabilidades.Size = new System.Drawing.Size(96, 20);
            this.LblHabilidades.TabIndex = 44;
            this.LblHabilidades.Text = "Habilidades: ";
            // 
            // TxtAspiraciones
            // 
            this.TxtAspiraciones.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAspiraciones.Location = new System.Drawing.Point(125, 365);
            this.TxtAspiraciones.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.TxtAspiraciones.MaxLength = 255;
            this.TxtAspiraciones.Multiline = true;
            this.TxtAspiraciones.Name = "TxtAspiraciones";
            this.TxtAspiraciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAspiraciones.Size = new System.Drawing.Size(277, 100);
            this.TxtAspiraciones.TabIndex = 7;
            // 
            // LblAspiraciones
            // 
            this.LblAspiraciones.AutoSize = true;
            this.LblAspiraciones.BackColor = System.Drawing.Color.Transparent;
            this.LblAspiraciones.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAspiraciones.Location = new System.Drawing.Point(19, 368);
            this.LblAspiraciones.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.LblAspiraciones.Name = "LblAspiraciones";
            this.LblAspiraciones.Size = new System.Drawing.Size(100, 20);
            this.LblAspiraciones.TabIndex = 46;
            this.LblAspiraciones.Text = "Aspiraciones: ";
            // 
            // TxtDescriptionImage
            // 
            this.TxtDescriptionImage.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescriptionImage.Location = new System.Drawing.Point(500, 290);
            this.TxtDescriptionImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TxtDescriptionImage.MaxLength = 50;
            this.TxtDescriptionImage.Name = "TxtDescriptionImage";
            this.TxtDescriptionImage.ReadOnly = true;
            this.TxtDescriptionImage.Size = new System.Drawing.Size(300, 27);
            this.TxtDescriptionImage.TabIndex = 48;
            this.TxtDescriptionImage.TabStop = false;
            // 
            // EPRegistroCandidata
            // 
            this.EPRegistroCandidata.ContainerControl = this;
            // 
            // FormRegistroCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoazul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 684);
            this.Controls.Add(this.TxtDescriptionImage);
            this.Controls.Add(this.TxtAspiraciones);
            this.Controls.Add(this.LblAspiraciones);
            this.Controls.Add(this.TxtHabilidades);
            this.Controls.Add(this.LblHabilidades);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.TxtIntereses);
            this.Controls.Add(this.LblIntereses);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.NUDSemestre);
            this.Controls.Add(this.CmbCarrera);
            this.Controls.Add(this.MTxtCedula);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblEdadCantidad);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.LblCedula);
            this.Controls.Add(this.PBoxFotografia);
            this.Controls.Add(this.BtnGuardarRegistro);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.DateFechaNacimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistroCandidata";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Candidatas";
            this.Load += new System.EventHandler(this.RegistroDeCandidatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxFotografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSemestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRegistroCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateFechaNacimiento;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnGuardarRegistro;
        private System.Windows.Forms.PictureBox PBoxFotografia;
        private System.Windows.Forms.OpenFileDialog OpenFilaFoto;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblEdadCantidad;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.NumericUpDown NUDSemestre;
        private System.Windows.Forms.ComboBox CmbCarrera;
        private System.Windows.Forms.MaskedTextBox MTxtCedula;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.TextBox TxtIntereses;
        private System.Windows.Forms.Label LblIntereses;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.TextBox TxtHabilidades;
        private System.Windows.Forms.Label LblHabilidades;
        private System.Windows.Forms.TextBox TxtAspiraciones;
        private System.Windows.Forms.Label LblAspiraciones;
        private System.Windows.Forms.TextBox TxtDescriptionImage;
        private System.Windows.Forms.ErrorProvider EPRegistroCandidata;
    }
}