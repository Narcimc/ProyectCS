namespace SIEleccionReina.Formularios
{
    partial class FRMCarreras
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
            this.LblCarrera = new System.Windows.Forms.Label();
            this.TxtCarrera = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblRegistroCarrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrera.Location = new System.Drawing.Point(21, 54);
            this.LblCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(58, 18);
            this.LblCarrera.TabIndex = 0;
            this.LblCarrera.Text = "CarreraOld:";
            this.LblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarrera.Location = new System.Drawing.Point(83, 53);
            this.TxtCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.Size = new System.Drawing.Size(199, 20);
            this.TxtCarrera.TabIndex = 1;
            this.TxtCarrera.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnLimpiar.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(40, 98);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(93, 25);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnGuardar.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(166, 98);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(93, 25);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblRegistroCarrera
            // 
            this.LblRegistroCarrera.AutoSize = true;
            this.LblRegistroCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblRegistroCarrera.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistroCarrera.Location = new System.Drawing.Point(71, 20);
            this.LblRegistroCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRegistroCarrera.Name = "LblRegistroCarrera";
            this.LblRegistroCarrera.Size = new System.Drawing.Size(157, 16);
            this.LblRegistroCarrera.TabIndex = 4;
            this.LblRegistroCarrera.Text = "Registro de Carreras";
            this.LblRegistroCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRMCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 179);
            this.Controls.Add(this.LblRegistroCarrera);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.LblCarrera);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCarreras";
            this.Load += new System.EventHandler(this.FRMCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.TextBox TxtCarrera;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblRegistroCarrera;
    }
}