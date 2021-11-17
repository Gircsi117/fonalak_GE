using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonalak_GE
{
    class Elem
    {
        private int[,] tabla;
        private int irany;
        private int kepszam;

        public int[,] Tabla { get => tabla; set => tabla = value; }
        public int Irany { get => irany; set => irany = value; }
        public int Kepszam { get => kepszam; set => kepszam = value; }

        public Elem(int[,] tabla, int irany, int sorszam)
        {
            this.tabla = tabla;
            this.irany = irany;
            this.kepszam = sorszam;
        }

        private void forgat()
        {

        }
    }
}
