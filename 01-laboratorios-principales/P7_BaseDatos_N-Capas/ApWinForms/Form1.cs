using BDFamosos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApWinForms
{
    public partial class Form1 : Form
    {

        // Colección en memoria de los famosos recuperados
        private ColCFamosos colFamosos;

        // Referencia a la capa de negocio
        private CFamosoBLL bd;

        public Form1()
        {
            InitializeComponent();

            // 1. Instanciamos la capa BLL y leemos los registros de la base de datos
            bd = new CFamosoBLL();
            colFamosos = bd.ObtenerFilasFamosos();

            // 2. Por cada famoso obtenido, creamos un control ElementoLista y lo añadimos al panel
            foreach (CFamosoBO obj in colFamosos)
            {
                ElementoLista elemento = new ElementoLista();
                elemento.ObjetoVinculado = obj; // Vincula los datos y configura el ToolTip

                // Agregamos el control de usuario a la colección de controles del FlowLayoutPanel
                this.flpFamosos.Controls.Add(elemento);
            }
        }

        // Se ejecuta justo antes de que el formulario se destruya
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Recorremos la colección para persistir los cambios en la base de datos
                for (int i = 0; i < colFamosos.Count; i++)
                {
                    // Comprobamos la propiedad Modificado que creamos en CFamosoBO
                    // De este modo solo ejecutamos UPDATE sobre las filas que el usuario realmente editó
                    if (colFamosos[i].Modificado)
                    {
                        bd.ActualizarFamosos(colFamosos[i]);
                        colFamosos[i].Modificado = false; // Marcamos como sincronizado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al sincronizar con la base de datos: " + ex.Message,
                    "Error de persistencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
