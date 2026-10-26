using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_4POO.Ejemplos;

namespace Unidad_4POO
{
    public partial class frmPersonaPOO : Form
    {
        public frmPersonaPOO()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Persona personaUno = new Persona();

            personaUno.Nombre = "Juan";
            personaUno.Edad = 30;

            personaUno.MostrarAtributos();


            // Instanciamos otra persona
            Persona personaDos = new Persona();

            personaDos.Nombre = "María";
            personaDos.Edad = 25;

            personaDos.MostrarAtributos();


        }
    }

}
    
