using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_4
{
    public partial class B4 : Form
    {
        Bicola4 bicola1 = new Bicola4();
        Bicola4 bicola2 = new Bicola4();
        int n = 0;
        int c = 0;
        public B4()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string x = txtDato.Text;
                if (x != "")
                {
                    if (rbtB1.Checked == true)
                    {
                        txtDato.Clear();
                        txtDato.Focus();
                        bicola1.encolarDetras(x);
                        bicola1.mostrar(lstBicola1);

                    }
                    else if (rbtB2.Checked == true)
                    {
                        txtDato.Clear();
                        txtDato.Focus();
                        bicola2.encolarDetras(x);
                        bicola2.mostrar(lstBicola2);
                    }
                }
                else
                {
                    MessageBox.Show("No seas pelotudo, y escribe algo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (bicola1.esVacia ()|| bicola2.esVacia() && n == 0)
            {
                if (n == 0)
                {
                    bicola1.A_Steal(bicola2, lstBicola1, lstBicola2, c);
                    n++;
                    bicola1.mostrar(lstBicola1);
                    bicola2.mostrar(lstBicola2);
                }
                else
                    bicola1.MostrarAlgor(bicola2, lstBicola1, lstBicola2);
            }
            else
            {
                bicola1.MostrarAlgor(bicola2, lstBicola1, lstBicola2);
            }
        }
    }
}
