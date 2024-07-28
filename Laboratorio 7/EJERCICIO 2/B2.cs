using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_2
{
    public partial class B2 : Form
    {
        Bicola2 bicola = new Bicola2();
        public B2()
        {
            InitializeComponent();
        }

        private void btnEncolarAlFinal_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
            bicola.encolarFinal(valor);
            bicola.mostrar(lstDatos);
        }

        private void btnEncolarPorElFrente_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
            bicola.encolarFrente(valor);
            bicola.mostrar(lstDatos);


        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (!bicola.esVacia())
            {
                int x = bicola.desencolarFrente();
                bicola.mostrar(lstDatos);
                MessageBox.Show("Valor Desencolado por el frente" + x);
            }
            else
                MessageBox.Show("La bicola esta vacia");
        }
    }
}
