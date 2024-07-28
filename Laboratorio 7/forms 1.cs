using Laboratorio_7.EJERCICIO_1;
using Laboratorio_7.EJERCICIO_2;
using Laboratorio_7.EJERCICIO_3;
using Laboratorio_7.EJERCICIO_4;
using Laboratorio_7.EJERCICIO_5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGrupo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los integrantes son\n" +
   "\n- ARNOLD EMILIO CHOMBA SUAREZ" +
   "\n- DEYBY MAURICIO GRADOS SHUPINGAHUA" +
   "\n- KATHERINE LISBETH LLACCOLLA GAMBOA" +
   "\n- LAURA THALIA GARCIA LUJAN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            Form ventana = new B1();
            ventana.Show();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            Form ventana = new B2();
            ventana.Show();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            Form ventana = new B3();
            ventana.Show();
        }
        private void btnB4_Click(object sender, EventArgs e)
        {
            Form ventana = new B4();
            ventana.Show();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            Form ventana = new B5();
            ventana.Show();
        }

    }
}
