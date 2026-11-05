using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
    public class CFamosoBO : INotifyPropertyChanged
    {
        // Campos privados que mapean las columnas de la tabla "famoso".
        private int ID;
        private string nombre;
        private string apellidos;
        private DateTime cumple;
        private string imagen;
        private bool modificado;

        // Constructores
        public CFamosoBO() { }

        public CFamosoBO(int id, string nom, string ape, DateTime cumple, string ima = null)
        {
            this.ID = id;
            this.nombre = nom;
            this.apellidos = ape;
            this.cumple = cumple;
            this.imagen = ima;
            this.modificado = false;
        }

        public int Id
        {
            get { return ID; }
            set
            {
                ID = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
                // Si cambia el nombre, también cambia la cabecera completa
                OnPropertyChanged(new PropertyChangedEventArgs("NombreAprellidosEdad"));
            }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Apellidos"));
                // Si cambian los apellidos, también cambia la cabecera completa
                OnPropertyChanged(new PropertyChangedEventArgs("NombreAprellidosEdad"));
            }
        }

        public DateTime Cumple
        {
            get { return cumple; }
            set
            {
                cumple = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Cumple"));
                OnPropertyChanged(new PropertyChangedEventArgs("Edad"));
                OnPropertyChanged(new PropertyChangedEventArgs("NombreAprellidosEdad"));
            }
        }

        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Imagen"));
            }
        }

        public bool Modificado
        {
            get { return modificado; }
            set { modificado = value; }
        }

        // Propiedades calculadas
        public string Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - cumple.Year;

                // Si todavía no ha llegado el cumpleaños este año, le restamos uno
                if (hoy < cumple.AddYears(edad))
                {
                    --edad;
                }

                return String.Format("({0})", edad);
            }
        }

        public string NombreApellidosEdad
        {
            get
            {
                return String.Format("{0}, {1} {2}", Apellidos, Nombre, Edad);
            }
        }

        // Implementación INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e); // Dispara el evento a los controles enlazados
            }
        }
    }
}
