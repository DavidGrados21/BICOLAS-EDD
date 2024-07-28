using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7.EJERCICIO_4
{
    internal class Bicola4
    {
        private NodoS vprimero;
        private NodoS vultimo;

        public NodoS primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public NodoS ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolarDetras(string x)
        {
            NodoS nuevo = new NodoS(x);

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
        public void encolarAdelante(string x)
        {
            NodoS nuevo = new NodoS(x);

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
        public string desencolarDelante()
        {
            string x;
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

        public string desencolarAtras()
        {
            string x;
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
            NodoS p = primero;
            while (p != null)
            {
                lst.Items.Add(p.info);
                p = p.sgte;
            }
        }

        public int contador()
        {
            Bicola4 aux = new Bicola4();
            int c = 0;
            while (!esVacia())
            {
                aux.encolarDetras(desencolarDelante());
                c++;
            }
            while (!aux.esVacia())
            {
                encolarDetras(aux.desencolarDelante());
            }
            return c;
        }
        public void A_Steal(Bicola4 bicola2, ListBox lstBicola1, ListBox lstBicola2, int c)
        {
            while (esVacia() || bicola2.esVacia())
            {
                if (bicola2.contador() > 2)
                {
                    string T1 = bicola2.desencolarAtras();
                    string T2 = bicola2.desencolarAtras();

                    encolarDetras(T1);
                    encolarDetras(T2);
                    break;
                }
                if (contador() > 2)
                {
                    string T1 = desencolarAtras();
                    string T2 = desencolarAtras();

                    bicola2.encolarDetras(T1);
                    bicola2.encolarDetras(T2);
                    break;
                }
            }
        }
        public void MostrarAlgor(Bicola4 bicola2, ListBox lstBicola1, ListBox lstBicola2)
        {
            if (!esVacia())
            {
                desencolarDelante();
            }
            if (!bicola2.esVacia())
            {
                bicola2.desencolarDelante();
            }
            mostrar(lstBicola1);
            bicola2.mostrar(lstBicola2);
        }
    }
}
