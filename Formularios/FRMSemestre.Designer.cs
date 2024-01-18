namespace SIEleccionReina.Formularios
{
    partial class FRMSemestre
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
            this.LblSemestre = new System.Windows.Forms.Label();
            this.TxtSemestre = new System.Windows.Forms.TextBox();
            this.LblREgistroSemestre = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSemestre
            // 
            this.LblSemestre.AutoSize = true;
            this.LblSemestre.Font = new System.Drawing.Font("Rockwell Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemestre.Location = new System.Drawing.Point(60, 51);
            this.LblSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSemestre.Name = "LblSemestre";
            this.LblSemestre.Size = new System.Drawing.Size(64, 18);
            this.LblSemestre.TabIndex = 0;
            this.LblSemestre.Text = "Semestre:";
            // 
            // TxtSemestre
            // 
            this.TxtSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSemestre.Location = new System.Drawing.Point(138, 49);
            this.TxtSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSemestre.Name = "TxtSemestre";
            this.TxtSemestre.Size = new System.Drawing.Size(68, 23);
            this.TxtSemestre.TabIndex = 1;
            // 
            // LblREgistroSemestre
            // 
            this.LblREgistroSemestre.AutoSize = true;
            this.LblREgistroSemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblREgistroSemestre.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblREgistroSemestre.Location = new System.Drawing.Point(73, 17);
            this.LblREgistroSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblREgistroSemestre.Name = "LblREgistroSemestre";
            this.LblREgistroSemestre.Size = new System.Drawing.Size(156, 16);
            this.LblREgistroSemestre.TabIndex = 2;
            this.LblREgistroSemestre.Text = "Registro de Semestre";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Plum;
            this.BtnGuardar.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(90, 91);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(103, 31);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNSalir.BackColor = System.Drawing.Color.HotPink;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSalir.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(266, 138);
            this.BTNSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(38, 23);
            this.BTNSalir.TabIndex = 41;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // FRMSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(305, 162);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblREgistroSemestre);
            this.Controls.Add(this.TxtSemestre);
            this.Controls.Add(this.LblSemestre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMSemestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMSemestre";
            this.Load += new System.EventHandler(this.FRMSemestre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.TextBox TxtSemestre;
        private System.Windows.Forms.Label LblREgistroSemestre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BTNSalir;
    }
}