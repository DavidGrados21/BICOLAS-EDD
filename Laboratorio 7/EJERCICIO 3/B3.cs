using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_3
{
    public partial class B3 : Form
    {
        Bicola3 bicola = new Bicola3();
        public B3()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
            bicola.encolarFinal(valor);
            bicola.mostrar(lstDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!bicola.esVacia())
            {
                bicola.eliminarTodo(int.Parse(txtValor.Text));
                bicola.mostrar(lstDatos);
            }
            else
                MessageBox.Show("No hay Elementos");



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
            bicola.encolarFinal(valor);
            bicola.mostrar(lstDatos);
        }
    }
}
