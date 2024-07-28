using Laboratorio_7.EJERCICIO_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_5
{
    internal class bicola5
    {
        private Nodo vprimero;
        private Nodo vultimo;

        public Nodo primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public Nodo ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolarDetras(int x)
        {
            Nodo nuevo = new Nodo(x);

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                ultimo.sgte = nuevo;
                nuevo.ant = ultimo;
            }
            ultimo = nuevo;
        }
        public void encolarAdelante(int x)
        {
            Nodo nuevo = new Nodo(x);

            if (primero == null)
            {
                ultimo = nuevo;
            }
            else
            {
                primero.ant = nuevo;
                nuevo.sgte = primero;
            }
            primero = nuevo;
        }
        public int desencolarDelante()
        {
            int x;
            x = primero.info;
            primero = primero.sgte;
            if (primero == null)
            {
                ultimo = null;
            }
            else
            {
                primero.ant = null;
            }
            return x;
        }

        public int desencolarAtras()
        {
            int x;
            x = ultimo.info;
            ultimo = ultimo.ant;
            ultimo.sgte = null;
            if (primero == null)
                ultimo = null;
            return x;
        }
        public bool esVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
                return false;
        }
        public void mostrar(ListBox lst)
        {
            lst.Items.Clear();
            Nodo p = primero;
            while (p != null)
            {
                lst.Items.Add(p.info);
                p = p.sgte;
            }
        }
        
        public int Contar()
        {
            bicola5 aux = new bicola5();
            int G = 0;
            while (esVacia())
            {
                aux.encolarDetras(desencolarDelante());
            }
            while (aux.esVacia())
            {
                encolarDetras(aux.desencolarDelante());
                G++;
            }
            return G;
        }

        public void insertarBicolaPosicion(int valor, int posicion)
        {
            bicola5 bicola2 = new bicola5();
            int cont = 0;
            while (ultimo != null)
            {
                if (ultimo.ant == null)
                {
                    int g = ultimo.info;
                    ultimo = ultimo.sgte;
                    bicola2.encolarAdelante(g);
                }
                else
                {
                    if (posicion == cont)
                    {
                        bicola2.encolarAdelante(valor);
                    }
                    bicola2.encolarAdelante(desencolarAtras());
                }
                cont++;
            }
            while (bicola2.ultimo != null)
            {
                if (bicola2.ultimo.ant == null)
                {
                    int r = ultimo.info;
                    ultimo = ultimo.sgte;
                    encolarAdelante(r);
                }
                else
                encolarAdelante(bicola2.desencolarAtras());
            }

        }
    }
}
