namespace ApWinForms
{
    partial class ElementoLista
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgFamoso = new System.Windows.Forms.PictureBox();
            this.etNomApEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.ttElementoLista = new System.Windows.Forms.ToolTip(this.components);
            this.famosoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFamoso
            // 
            this.imgFamoso.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.famosoBindingSource, "Imagen", true));
            this.imgFamoso.Location = new System.Drawing.Point(0, 0);
            this.imgFamoso.Name = "imgFamoso";
            this.imgFamoso.Size = new System.Drawing.Size(100, 110);
            this.imgFamoso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFamoso.TabIndex = 0;
            this.imgFamoso.TabStop = false;
            // 
            // etNomApEdad
            // 
            this.etNomApEdad.AutoSize = true;
            this.etNomApEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "NombreApellidosEdad", true));
            this.etNomApEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNomApEdad.Location = new System.Drawing.Point(131, 9);
            this.etNomApEdad.Name = "etNomApEdad";
            this.etNomApEdad.Size = new System.Drawing.Size(344, 31);
            this.etNomApEdad.TabIndex = 1;
            this.etNomApEdad.Text = "Apellidos, Nombre (edad)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(394, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Apellidos", true));
            this.txtApellido.Location = new System.Drawing.Point(394, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 31);
            this.txtApellido.TabIndex = 6;
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.famosoBindingSource, "Cumple", true));
            this.txtFechaNaci.Location = new System.Drawing.Point(394, 173);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(100, 31);
            this.txtFechaNaci.TabIndex = 7;
            // 
            // famosoBindingSource
            // 
            this.famosoBindingSource.DataSource = typeof(BDFamosos.CFamosoBO);
            // 
            // ElementoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFechaNaci);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etNomApEdad);
            this.Controls.Add(this.imgFamoso);
            this.Name = "ElementoLista";
            this.Size = new System.Drawing.Size(704, 312);
            ((System.ComponentModel.ISupportInitialize)(this.imgFamoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.famosoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFamoso;
        private System.Windows.Forms.Label etNomApEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFechaNaci;
        private System.Windows.Forms.ToolTip ttElementoLista;
        private System.Windows.Forms.BindingSource famosoBindingSource;
    }
}
