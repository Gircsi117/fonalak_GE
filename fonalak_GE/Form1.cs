using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fonalak_GE
{
    public partial class Form1 : Form
    {
        static List<Elem> adatok = new List<Elem>() { };
        static PictureBox[,] tabla = new PictureBox[3,3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            elemgeneral();
            alap_general();
        }

        //piros-1, kék-2, zöld-3, sárga-4
        private void elemgeneral()
        {
            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 4, 2, 0},
                {3, 0, 0, 1 },
                {1, 0, 0, 2 },
                {0, 4, 3, 0 }
            }, 0, 0));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 3, 1, 0},
                {1, 0, 0, 4 },
                {2, 0, 0, 2 },
                {0, 4, 3, 0 }
            }, 0, 1));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 1, 3, 0},
                {4, 0, 0, 2 },
                {2, 0, 0, 1 },
                {0, 4, 3, 0 }
            }, 0, 2));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 4, 3, 0 },
                {2, 0, 0, 2 },
                {3, 0, 0, 1 },
                {0, 1, 4, 0 }
            }, 0, 3));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 4, 3, 0 },
                {2, 0, 0, 1 },
                {1, 0, 0, 3 },
                {0, 4, 2, 0 }
            }, 0, 4));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 4, 3, 0 },
                {1, 0, 0, 1 },
                {3, 0, 0, 2 },
                {0, 2, 4, 0 }
            }, 0, 5));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 1, 4, 0 },
                {4, 0, 0, 2 },
                {3, 0, 0, 3 },
                {0, 2, 1, 0 }
            }, 0, 6));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 4, 2, 0 },
                {2, 0, 0, 1 },
                {3, 0, 0, 3 },
                {0, 1, 4, 0 }
            }, 0, 7));

            adatok.Add(new Elem(new int[4, 4]
            {
                {0, 2, 4, 0 },
                {1, 0, 0, 3 },
                {3, 0, 0, 2 },
                {0, 1, 4, 0 }
            }, 0, 8));
        }

        private void alap_general()
        {
            alapPANEL.Controls.Clear();
            int szeles = (alapPANEL.Width - 24) / 3;

            int x = 12;
            int y = 12;

            int kepszam = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pn = new PictureBox();
                    pn.Size = new Size(szeles, szeles);
                    pn.BackColor = Color.White;
                    pn.BorderStyle = BorderStyle.FixedSingle;
                    alapPANEL.Controls.Add(pn);
                    pn.Location = new Point(x, y);
                    //pn.Image = kepekIMAGELIST.Images[kepszam];
                    pn.SizeMode = PictureBoxSizeMode.Zoom;

                    tabla[i, j] = pn;

                    kepszam++;
                    x += szeles;
                }
                x = 12;
                y += szeles;
            }
            kepekberak();
        }

        private void kepekberak()
        {
            int sorszam = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabla[i, j].Image = kepekIMAGELIST.Images[adatok[sorszam].Kepszam];

                    sorszam++;        
                }
            }
        }
    }
}
