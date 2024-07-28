using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_1
{
    internal class Bicola1
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

        public Bicola1()
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
        public int desencolarFrente()
        {
            int valor = frente.info;
            frente = frente.sgte;
            if (frente == null)
                fin = null;
            else
                frente.ant = null;
            return valor;
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

        public int desencolarFinal()
        {
            int valor = fin.info;
            fin = fin.ant;
            if (fin != null)
                fin.sgte = null;
            else
                frente = null;
            return valor;

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

        public void clear()
        {
            while (frente != null)
            {
                frente = frente.sgte;
                if (frente != null)
                    frente.ant = null;
            }
            fin = null;
        }

        public Nodo buscar(int valor)
        {
            Nodo actual = frente;
            while (actual != null)
            {
                if (actual.info == valor)
                    return actual;
                actual = actual.sgte;
            }
            return null;
        }
    }
}
