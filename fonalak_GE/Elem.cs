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

        public void forgat()
        {
            int[,] uj_tabla = new int[4, 4];

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    uj_tabla[4 - i - 1, j] = tabla[j, i];
                }
            }

            tabla = uj_tabla;
            irany++;
            if (irany == 4)
            {
                irany = 0;
            }
        }

        public string oldal_visszad(string oldal)
        {
            switch (oldal)
            {
                case "bal": return $"{tabla[1, 0]}{tabla[2, 0]}"; break;
                case "jobb": return $"{tabla[1, 3]}{tabla[2, 3]}"; break;
                case "felso": return $"{tabla[0, 1]}{tabla[0, 2]}"; break;
                case "also": return $"{tabla[3, 1]}{tabla[3, 2]}"; break;

                default: return ""; break;
            }
        }
    }
}
