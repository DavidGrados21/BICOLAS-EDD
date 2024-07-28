using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    internal class Nodo
    {
        private int vinfo;
        private Nodo vsgte;
        private Nodo vant;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public Nodo sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public Nodo ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public Nodo(int vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public Nodo(int vinfo, Nodo vsgte, Nodo vant)
        {
            info = vinfo;
            sgte = vsgte;
            ant = vant;
        }
    }
}
