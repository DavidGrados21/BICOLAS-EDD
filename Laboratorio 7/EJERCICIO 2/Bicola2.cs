using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_2
{
    internal class Bicola2
    {
        private Nodo vfrente;
        private Nodo vfin;

        public Nodo frente
        {
            get { return vfrente; }
            set { vfrente = value; }
        }
        public Nodo fin
        {

            get { return vfin; }
            set { vfin = value; }
        }
        public Bicola2()
        {
            frente = null;
            fin = null;
        }

        public bool esVacia()
        {
            if (frente == null)
                return true;
            else
                return false;
        }

        public void encolarFinal(int valor)
        {

            Nodo nuevo = new Nodo(valor);
            if (frente == null)
            {
                frente = nuevo;
                fin = nuevo;
            }

            else
            {
                nuevo.sgte = null;
                nuevo.ant = fin;
                fin.sgte = nuevo;
                fin = nuevo;

            }

        }


        public void mostrar(ListBox lst)
        {
            Nodo actual = frente;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public void encolarFrente(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (esVacia())
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                nuevo.ant = null;
                nuevo.sgte = frente;
                frente.ant = nuevo;
                frente = nuevo;
            }
        }

        public int desencolarFrente()
        {
            int valor = frente.info;
            frente = frente.sgte;
            if (frente == null)
                fin = null;
            return valor;
        }
    }
}
