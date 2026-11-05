using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDFamosos;
using System.IO;
using System.Reflection;

namespace ApWinForms
{
    public partial class ElementoLista : UserControl
    {
        public ElementoLista()
        {
            InitializeComponent();

            // Obtener el enlace con la propiedad Image del control imgFamoso para gestionar su evento Format
            Binding bImagen = this.imgFamoso.DataBindings["Image"];
            if (bImagen != null)
            {
                bImagen.Format += this.StringToBitmap;
            }
        }

        private void StringToBitmap (object sender, ConvertEventArgs e)
        {
            // Format ocurre siempre que haya que mostrar el valor de la propiedad Imagen
            if (e.DesiredType != typeof(Image)) return;

            string nombreImagen = e.Value as string;
            if (string.IsNullOrEmpty(nombreImagen)) return;

            string rutaCompleta = ObtenerRutaImagen(nombreImagen);

            // Verificamos si existe en disco.
            if (File.Exists(rutaCompleta))
            {
                e.Value = Bitmap.FromFile(rutaCompleta);
            }
        }

        public CFamosoBO ObjetoVinculado
        {
            get
            {
                return this.famosoBindingSource.DataSource as CFamosoBO;
            }
            set
            {
                // Vincula el objeto con el BindingSource
                this.famosoBindingSource.DataSource = value;

                // Establece el tooltip en la foto con el ID del famoso
                if (value != null)
                {
                    string msj = "ID famoso: " + value.Id;
                    this.ttElementoLista.SetToolTip(this.imgFamoso, msj);
                }
            }
        }

        private string ObtenerRutaImagen (string nombreImagen)
        {
            // Obtiene el directorio donde se ejecuta el archivo binario
            string carpeta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            carpeta = Path.Combine(carpeta, "Imagenes");
            return Path.Combine(carpeta, nombreImagen);
        }
    }
}
