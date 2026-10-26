using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4POO.Ejemplos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void MostrarAtributos()
        {
            MessageBox.Show(
                $"Nombre: {Nombre}\nEdad: {Edad}",
                "Datos de la persona"
            );
        }

    }
}
