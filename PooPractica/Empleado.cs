using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooPractica
{
    public class Empleado : IMostrarInformacion
    {
        //atributos
        public string Nombre="Luis";
        public double Salario = 20.50;

        //metodo que calcula y muestra el salario anual
        public void CalcularSalarioAnual()
        {
            double salarioAnual = Salario * 12;
            System.Windows.Forms.MessageBox.Show($"El salario anual de {Nombre} es: {salarioAnual:C}");

        }
        //metodo que muestra la informacion general del empleado y gerente
        public void MostrarInformacionGeneral()
        {
            MessageBox.Show($"Empleado: {Nombre}\nSalario: {Salario:C}");
        }
    }
}
