using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooPractica
{
    //aplico herencia
    public class Gerente : Empleado, IMostrarInformacion
    {
        //atributos
        public string Departamento="Ventas";
        //metodo que muestra la informacion del gerente
        public void MostrarInfoGerente()
        {
            MessageBox.Show($"Gerente: {Nombre}\nDepartamento: {Departamento}\nSalario: {Salario:C}");
        }
        //metodo que muestra la informacion general del gerente
        public new void MostrarInformacionGeneral()  // Utilizando 'new' para ocultar el método de la clase base
        {
            MessageBox.Show($"Gerente: {Nombre}\nDepartamento: {Departamento}\nSalario: {Salario:C}");
        }
    }
}
