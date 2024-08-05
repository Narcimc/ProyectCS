namespace SIEleccionReina.Formularios
{
    partial class FormModuloEstudiante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sIRFEnGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMsjBienvenida = new System.Windows.Forms.Label();
            this.LblSaludoUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVerCandidatas
            // 
            this.BtnVerCandidatas.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnVerCandidatas.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCandidatas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVerCandidatas.Location = new System.Drawing.Point(19, 178);
            this.BtnVerCandidatas.Margin = new System.Windows.Forms.Padding(10, 2, 10, 20);
            this.BtnVerCandidatas.Name = "BtnVerCandidatas";
            this.BtnVerCandidatas.Size = new System.Drawing.Size(332, 40);
            this.BtnVerCandidatas.TabIndex = 11;
            this.BtnVerCandidatas.Text = "Ver Candidatas ";
            this.BtnVerCandidatas.UseVisualStyleBackColor = false;
            this.BtnVerCandidatas.Click += new System.EventHandler(this.BtnVerCandidatas_Click);
            // 
            // BtnVotarPorFotogenica
            // 
            this.BtnVotarPorFotogenica.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnVotarPorFotogenica.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVotarPorFotogenica.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVotarPorFotogenica.Location = new System.Drawing.Point(19, 302);
            this.BtnVotarPorFotogenica.Margin = new System.Windows.Forms.Padding(10, 2, 10, 20);
            this.BtnVotarPorFotogenica.Name = "BtnVotarPorFotogenica";
            this.BtnVotarPorFotogenica.Size = new System.Drawing.Size(332, 40);
            this.BtnVotarPorFotogenica.TabIndex = 7;
            this.BtnVotarPorFotogenica.Text = "Votar por Miss Fotogénica";
            this.BtnVotarPorFotogenica.UseVisualStyleBackColor = false;
            this.BtnVotarPorFotogenica.Click += new System.EventHandler(this.BtnVotarPorFotogenica_Click);
            // 
            // BtnVotoReina
            // 
            this.BtnVotoReina.BackColor = System.Drawing.Color.Orchid;
            this.BtnVotoReina.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnVotoReina.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVotoReina.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVotoReina.Location = new System.Drawing.Point(233, 240);
            this.BtnVotoReina.Margin = new System.Windows.Forms.Padding(10, 2, 10, 20);
            this.BtnVotoReina.Name = "BtnVotoReina";
            this.BtnVotoReina.Size = new System.Drawing.Size(332, 40);
            this.BtnVotoReina.TabIndex = 6;
            this.BtnVotoReina.Text = "Votar por Reina ";
            this.BtnVotoReina.UseVisualStyleBackColor = false;
            this.BtnVotoReina.Click += new System.EventHandler(this.BtnVotoReina_Click);
            // 
            // PBoxResultados
            // 
            this.PBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxResultados.Image = global::SIEleccionReina.Properties.Resources.Fotogeica;
            this.PBoxResultados.Location = new System.Drawing.Point(363, 302);
            this.PBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxResultados.Name = "PBoxResultados";
            this.PBoxResultados.Size = new System.Drawing.Size(48, 40);
            this.PBoxResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxResultados.TabIndex = 10;
            this.PBoxResultados.TabStop = false;
            // 
            // PBoxGaleria
            // 
            this.PBoxGaleria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxGaleria.Image = global::SIEleccionReina.Properties.Resources.Candidata1;
            this.PBoxGaleria.Location = new System.Drawing.Point(173, 240);
            this.PBoxGaleria.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxGaleria.Name = "PBoxGaleria";
            this.PBoxGaleria.Size = new System.Drawing.Size(48, 40);
            this.PBoxGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxGaleria.TabIndex = 9;
            this.PBoxGaleria.TabStop = false;
            // 
            // PBoxRegistroCandidata
            // 
            this.PBoxRegistroCandidata.BackColor = System.Drawing.SystemColors.Control;
            this.PBoxRegistroCandidata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBoxRegistroCandidata.Image = global::SIEleccionReina.Properties.Resources.CandidataLogo;
            this.PBoxRegistroCandidata.Location = new System.Drawing.Point(363, 178);
            this.PBoxRegistroCandidata.Margin = new System.Windows.Forms.Padding(2);
            this.PBoxRegistroCandidata.Name = "PBoxRegistroCandidata";
            this.PBoxRegistroCandidata.Size = new System.Drawing.Size(48, 40);
            this.PBoxRegistroCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxRegistroCandidata.TabIndex = 8;
            this.PBoxRegistroCandidata.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator2,
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "&Estudiante";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.perfilToolStripMenuItem.Text = "&Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.sIRFEnGitHubToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // sIRFEnGitHubToolStripMenuItem
            // 
            this.sIRFEnGitHubToolStripMenuItem.Name = "sIRFEnGitHubToolStripMenuItem";
            this.sIRFEnGitHubToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sIRFEnGitHubToolStripMenuItem.Text = "SIRF en GitHub";
            this.sIRFEnGitHubToolStripMenuItem.Click += new System.EventHandler(this.sIRFEnGitHubToolStripMenuItem_Click);
            // 
            // LblMsjBienvenida
            // 
            this.LblMsjBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMsjBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.LblMsjBienvenida.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsjBienvenida.Location = new System.Drawing.Point(45, 104);
            this.LblMsjBienvenida.Margin = new System.Windows.Forms.Padding(36, 5, 30, 0);
            this.LblMsjBienvenida.Name = "LblMsjBienvenida";
            this.LblMsjBienvenida.Size = new System.Drawing.Size(500, 48);
            this.LblMsjBienvenida.TabIndex = 14;
            this.LblMsjBienvenida.Text = "Recibe una calurosa Bienvenida.";
            // 
            // LblSaludoUser
            // 
            this.LblSaludoUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSaludoUser.BackColor = System.Drawing.Color.Transparent;
            this.LblSaludoUser.Font = new System.Drawing.Font("Leelawadee UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaludoUser.Location = new System.Drawing.Point(39, 54);
            this.LblSaludoUser.Margin = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.LblSaludoUser.Name = "LblSaludoUser";
            this.LblSaludoUser.Size = new System.Drawing.Size(506, 45);
            this.LblSaludoUser.TabIndex = 13;
            this.LblSaludoUser.Text = "Hola ";
            // 
            // FormModuloEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SIEleccionReina.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.LblMsjBienvenida);
            this.Controls.Add(this.LblSaludoUser);
            this.Controls.Add(this.BtnVerCandidatas);
            this.Controls.Add(this.PBoxResultados);
            this.Controls.Add(this.PBoxGaleria);
            this.Controls.Add(this.PBoxRegistroCandidata);
            this.Controls.Add(this.BtnVotarPorFotogenica);
            this.Controls.Add(this.BtnVotoReina);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormModuloEstudiante";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Estudiante";
            this.Load += new System.EventHandler(this.FormModuloEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRegistroCandidata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerCandidatas;
        private System.Windows.Forms.PictureBox PBoxResultados;
        private System.Windows.Forms.PictureBox PBoxGaleria;
        private System.Windows.Forms.PictureBox PBoxRegistroCandidata;
        private System.Windows.Forms.Button BtnVotarPorFotogenica;
        private System.Windows.Forms.Button BtnVotoReina;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIRFEnGitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label LblMsjBienvenida;
        private System.Windows.Forms.Label LblSaludoUser;
    }
}