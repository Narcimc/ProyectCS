namespace SIEleccionReina
{
    partial class FormModuloAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModuloAdministrador));
            this.BtnInscripcionCandidatas = new System.Windows.Forms.Button();
            this.BtnRegistroFoto = new System.Windows.Forms.Button();
            this.BtnResultados = new System.Windows.Forms.Button();
            this.PBoxResultados = new System.Windows.Forms.PictureBox();
            this.PBoxGaleria = new System.Windows.Forms.PictureBox();
            this.PBoxRegistroCandidata = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCandidataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ÁlbumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearÁlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sIEREnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInscripcionCandidatas
            // 
            this.BtnInscripcionCandidatas.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnInscripcionCandidatas.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnInscripcionCandidatas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInscripcionCandidatas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInscripcionCandidatas.Location = new System.Drawing.Point(58, 54);
            this.BtnInscripcionCandidatas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInscripcionCandidatas.Name = "BtnInscripcionCandidatas";
            this.BtnInscripcionCandidatas.Size = new System.Drawing.Size(210, 40);
            this.BtnInscripcionCandidatas.TabIndex = 0;
            this.BtnInscripcionCandidatas.Text = "Inscripción de Candidatas";
            this.BtnInscripcionCandidatas.UseVisualStyleBackColor = false;
            this.BtnInscripcionCandidatas.Click += new System.EventHandler(this.BtnInscripcionCandidatas_Click);
            // 
            // BtnRegistroFoto
            // 
            this.BtnRegistroFoto.BackColor = System.Drawing.Color.Orchid;
            this.BtnRegistroFoto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRegistroFoto.Location = new System.Drawing.Point(190, 127);
            this.BtnRegistroFoto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistroFoto.Name = "BtnRegistroFoto";
            this.BtnRegistroFoto.Size = new System.Drawing.Size(210, 40);
            this.BtnRegistroFoto.TabIndex = 1;
            this.BtnRegistroFoto.Text = "Galería de Fotos";
            this.BtnRegistroFoto.UseVisualStyleBackColor = false;
            this.BtnRegistroFoto.Click += new System.EventHandler(this.BtnRegistroFoto_Click);
            // 
            // BtnResultados
            // 
            this.BtnResultados.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnResultados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResultados.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnResultados.Location = new System.Drawing.Point(58, 198);
            this.BtnResultados.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResultados.Name = "BtnResultados";
            this.BtnResultados.Size = new System.Drawing.Size(210, 40);
            this.BtnResultados.TabIndex = 5;
            this.BtnResultados.Text = "Resultados";
            this.BtnResultados.UseVisualStyleBackColor = false;
            this.BtnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // PBoxResultados
            // 
            this.PBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxResultados.Image = ((System.Drawing.Image)(resources.GetObject("PBoxResultados.Image")));
            this.PBoxResultados.Location = new System.Drawing.Point(263, 198);
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
            this.PBoxGaleria.Location = new System.Drawing.Point(137, 126);
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
            this.PBoxRegistroCandidata.Location = new System.Drawing.Point(268, 54);
            this.PBoxRegistroCandidata.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxRegistroCandidata.Name = "PBoxRegistroCandidata";
            this.PBoxRegistroCandidata.Size = new System.Drawing.Size(46, 42);
            this.PBoxRegistroCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxRegistroCandidata.TabIndex = 2;
            this.PBoxRegistroCandidata.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.candidataToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "&Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // candidataToolStripMenuItem
            // 
            this.candidataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCandidataToolStripMenuItem,
            this.toolStripSeparator2,
            this.ÁlbumesToolStripMenuItem});
            this.candidataToolStripMenuItem.Name = "candidataToolStripMenuItem";
            this.candidataToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.candidataToolStripMenuItem.Text = "&Candidatas";
            // 
            // registrarCandidataToolStripMenuItem
            // 
            this.registrarCandidataToolStripMenuItem.Name = "registrarCandidataToolStripMenuItem";
            this.registrarCandidataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCandidataToolStripMenuItem.Text = "&Registrar Candidata";
            this.registrarCandidataToolStripMenuItem.Click += new System.EventHandler(this.registrarCandidataToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ÁlbumesToolStripMenuItem
            // 
            this.ÁlbumesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearÁlbumToolStripMenuItem,
            this.agregarFotosToolStripMenuItem});
            this.ÁlbumesToolStripMenuItem.Name = "ÁlbumesToolStripMenuItem";
            this.ÁlbumesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ÁlbumesToolStripMenuItem.Text = "Ál&bumes";
            // 
            // crearÁlbumToolStripMenuItem
            // 
            this.crearÁlbumToolStripMenuItem.Name = "crearÁlbumToolStripMenuItem";
            this.crearÁlbumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearÁlbumToolStripMenuItem.Text = "Crear Álbum";
            this.crearÁlbumToolStripMenuItem.Click += new System.EventHandler(this.crearÁlbumToolStripMenuItem_Click);
            // 
            // agregarFotosToolStripMenuItem
            // 
            this.agregarFotosToolStripMenuItem.Name = "agregarFotosToolStripMenuItem";
            this.agregarFotosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarFotosToolStripMenuItem.Text = "Agregar Fotos";
            this.agregarFotosToolStripMenuItem.Click += new System.EventHandler(this.agregarFotosToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudianteToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "&Estudiante";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarEstudianteToolStripMenuItem.Text = "&Registrar Estudiante";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstudianteToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resultadosToolStripMenuItem.Text = "&Resultados";
            this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeSIERToolStripMenuItem,
            this.toolStripSeparator3,
            this.sIEREnGitHubToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeSIERToolStripMenuItem
            // 
            this.acercaDeSIERToolStripMenuItem.Name = "acercaDeSIERToolStripMenuItem";
            this.acercaDeSIERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeSIERToolStripMenuItem.Text = "&Acerca de SIRF";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // sIEREnGitHubToolStripMenuItem
            // 
            this.sIEREnGitHubToolStripMenuItem.Name = "sIEREnGitHubToolStripMenuItem";
            this.sIEREnGitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sIEREnGitHubToolStripMenuItem.Text = "&SIER en GitHub";
            // 
            // FormModuloAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.BtnResultados);
            this.Controls.Add(this.PBoxResultados);
            this.Controls.Add(this.PBoxGaleria);
            this.Controls.Add(this.PBoxRegistroCandidata);
            this.Controls.Add(this.BtnRegistroFoto);
            this.Controls.Add(this.BtnInscripcionCandidatas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormModuloAdministrador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInscripcionCandidatas;
        private System.Windows.Forms.Button BtnRegistroFoto;
        private System.Windows.Forms.PictureBox PBoxRegistroCandidata;
        private System.Windows.Forms.PictureBox PBoxGaleria;
        private System.Windows.Forms.PictureBox PBoxResultados;
        private System.Windows.Forms.Button BtnResultados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIEREnGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCandidataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÁlbumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearÁlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}