using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_5
{
    public partial class B5 : Form
    {
        bicola5 bicola = new bicola5();
        public B5()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtValor.Text);
                txtValor.Clear();
                txtValor.Focus();
                bicola.encolarAdelante(x);
                bicola.mostrar(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void btnInsertarposicion_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtPosicion.Text);
                int n = int.Parse(txtValor.Text);

                txtPosicion.Clear();
                txtPosicion.Focus();
                bicola.insertarBicolaPosicion(n, x);
                lstDatos.Items.Clear();
                bicola.mostrar(lstDatos);

            }
            catch
            {
                MessageBox.Show("Por favor, insertar un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtPosicion.Clear();
                txtValor.Focus();
            }
        }
    }
}
