namespace ApWinForms
{
    partial class Form1
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
            this.etTitulo = new System.Windows.Forms.Label();
            this.flpFamosos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // etTitulo
            // 
            this.etTitulo.AutoSize = true;
            this.etTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTitulo.Location = new System.Drawing.Point(35, 21);
            this.etTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.etTitulo.Name = "etTitulo";
            this.etTitulo.Size = new System.Drawing.Size(95, 24);
            this.etTitulo.TabIndex = 0;
            this.etTitulo.Text = "Famosos";
            // 
            // flpFamosos
            // 
            this.flpFamosos.AutoScroll = true;
            this.flpFamosos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFamosos.Location = new System.Drawing.Point(-4, 47);
            this.flpFamosos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpFamosos.Name = "flpFamosos";
            this.flpFamosos.Size = new System.Drawing.Size(220, 208);
            this.flpFamosos.TabIndex = 1;
            this.flpFamosos.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 233);
            this.Controls.Add(this.flpFamosos);
            this.Controls.Add(this.etTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Windows Forms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpFamosos;
    }
}

