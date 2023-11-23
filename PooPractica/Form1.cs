using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooPractica
{
    public partial class Form1 : Form
    {
        //Creacion del objetos
        Empleado empleado = new Empleado();
        Gerente gerente = new Gerente();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Boton que calcula y muestra el salario anual
        private void btnCalcularSalarioAnual_Click(object sender, EventArgs e)
        {
            empleado.CalcularSalarioAnual();
        }
        //Boton que muestra la informacion del gerente
        private void btnMostrarInfoGerente_Click(object sender, EventArgs e)
        {
            gerente.MostrarInfoGerente();
        }

        private void btnMostrarInformacionGeneral_Click(object sender, EventArgs e)
        {
            // Llamar al método MostrarInformacionGeneral de manera polimórfica
            empleado.MostrarInformacionGeneral();
            gerente.MostrarInformacionGeneral();
        }
    }
}
