namespace WindowsFormsApp1
{
    partial class formInicial
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbSaludar = new System.Windows.Forms.TextBox();
            this.lblSaludar = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 38);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(240, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // txbSaludar
            // 
            this.txbSaludar.Location = new System.Drawing.Point(63, 12);
            this.txbSaludar.Name = "txbSaludar";
            this.txbSaludar.Size = new System.Drawing.Size(193, 20);
            this.txbSaludar.TabIndex = 1;
            // 
            // lblSaludar
            // 
            this.lblSaludar.AutoSize = true;
            this.lblSaludar.Location = new System.Drawing.Point(13, 13);
            this.lblSaludar.Name = "lblSaludar";
            this.lblSaludar.Size = new System.Drawing.Size(44, 13);
            this.lblSaludar.TabIndex = 2;
            this.lblSaludar.Text = "Nombre";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(16, 67);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(240, 23);
            this.btnSaludar.TabIndex = 3;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // formInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 97);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lblSaludar);
            this.Controls.Add(this.txbSaludar);
            this.Controls.Add(this.btnSalir);
            this.Name = "formInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formInicial_FormClosing);
            this.Load += new System.EventHandler(this.formInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbSaludar;
        private System.Windows.Forms.Label lblSaludar;
        private System.Windows.Forms.Button btnSaludar;
    }
}

