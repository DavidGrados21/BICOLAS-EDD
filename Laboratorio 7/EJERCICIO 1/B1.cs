using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_1
{

    public partial class B1 : Form
    {
        Bicola1 bicola = new Bicola1();
        public B1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
            bicola.encolarFinal(valor);
            bicola.mostrar(lstDatos);
        }

        private void btnDesencolarPorElFrente_Click(object sender, EventArgs e)
        {
            if (!bicola.esVacia())
            {
                int x = bicola.desencolarFrente();
                bicola.mostrar(lstDatos);
                MessageBox.Show("Valor desencolado por el frente: " + x);

            }
            else
            {
                MessageBox.Show("La Bicola esta vacia");
            }
        }

        private void btnDesencolarPorElFinal_Click(object sender, EventArgs e)
        {
            if (!bicola.esVacia())
            {
                int x = bicola.desencolarFinal();
                bicola.mostrar(lstDatos);
                MessageBox.Show("Valor desencolado por el final: " + x);

            }
            else
            {
                MessageBox.Show("La Bicola esta vacia");
            }
        }
    }
}
