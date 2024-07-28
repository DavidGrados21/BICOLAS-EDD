using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_3
{
    internal class Bicola3
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

        public Bicola3()
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

        public bool eliminar(int valor)
        {
            if (frente.info == valor)
            {
                frente = frente.sgte;
                return true;
            }
            else
            {
                Nodo anterior = frente;
                Nodo actual = frente.sgte;
                while (actual != null && actual.info != valor)
                {
                    anterior = actual;
                    actual = actual.sgte;
                }
                if (actual != null)
                {
                    anterior.sgte = actual.sgte;
                    if (actual.sgte != null)
                        actual.sgte.ant = anterior;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void eliminarTodo(int valor)
        {
            Nodo actual = frente;
            while (actual != null)
            {
                if (actual.info == valor)
                {
                    eliminar(valor);
                }
                actual = actual.sgte;
            }

        }

        public string listar()
        {
            string resultado = "";
            Nodo actual = frente;
            while (actual != null)
            {
                Console.WriteLine(actual.info);
                resultado += actual.info + "\n";
                actual = actual.sgte;
            }
            return resultado;
        }
    }
}
