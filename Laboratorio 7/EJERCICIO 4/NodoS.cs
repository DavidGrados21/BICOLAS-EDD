using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7.EJERCICIO_4
{
    internal class NodoS
    {
        private string vinfo;
        private NodoS vsgte;
        private NodoS vant;

        public string info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public NodoS sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }
        public NodoS ant
        {
            get { return vant; }
            set { vant = value; }
        }

        public NodoS(string vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public NodoS(string vinfo, NodoS vsgte, NodoS vant)
        {
            info = vinfo;
            sgte = vsgte;
            ant = vant;
        }
    }
}
