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
        static bool mehete = true;

        static Elem[,] megoldas = new Elem[3, 3];

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
            adatok[0].forgat();
            adatok[0].forgat();
            adatok[0].forgat();

            adatok[1].forgat();
            adatok[1].forgat();

            adatok[5].forgat();
            adatok[6].forgat();
            kepekberak(false);
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
                    pn.SizeMode = PictureBoxSizeMode.Zoom;

                    tabla[i, j] = pn;

                    kepszam++;
                    x += szeles;
                }
                x = 12;
                y += szeles;
            }
            kepekberak(false);
        }

        private void kepekberak(bool vege)
        {
            int sorszam = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!vege)
                    {
                        tabla[i, j].Image = kepekIMAGELIST.Images[adatok[sorszam].Kepszam];

                        for (int k = 0; k < adatok[sorszam].Irany; k++)
                        {
                            tabla[i, j].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                        sorszam++;
                    }
                    else
                    {
                        tabla[i, j].Image = kepekIMAGELIST.Images[megoldas[i, j].Kepszam];

                        for (int k = 0; k < megoldas[i, j].Irany; k++)
                        {
                            tabla[i, j].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                    }
                }
            }

            mehete = false;
        }

        private void rekurzio(int kezd_hely, List<Elem> elemek)
        {
            int sor = kezd_hely / 3;
            int oszlop = kezd_hely % 3;

            if (mehete)
            {
                elemek = kivalszt(elemek);

                for (int i = 0; i < elemek.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        szamlaloLBL.Text = (Convert.ToInt32(szamlaloLBL.Text) + 1).ToString();
                        megoldas[sor, oszlop] = elemek[i];
                        if (tabla_vizsgal())
                        {
                            if (kezd_hely == 8)
                            {
                                kepekberak(true);
                                MessageBox.Show("Megoldás sikeresen megtalálva!!!!444!!!44!");
                            }
                            else
                            {
                                List<Elem> tovabb = kivalszt(elemek);
                                tovabb.Remove(elemek[i]);
                                rekurzio(kezd_hely + 1, kivalszt(tovabb));
                            }
                        }
                        elemek[i].forgat();
                    }
                    megoldas[sor, oszlop] = null;
                }
                megoldas[sor, oszlop] = null;
            }
        }

        private List<Elem> kivalszt(List<Elem> lista)
        {
            List<Elem> kivalasztott = new List<Elem>() { };

            for (int i = 0; i < lista.Count; i++)
            {
                kivalasztott.Add(lista[i]);
            }

            return kivalasztott;
        }

        private bool tabla_vizsgal()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (megoldas[i, j] != null)
                    {
                        if (i + 1 < 3 && megoldas[i + 1, j] != null)
                        {
                            if (megoldas[i, j].oldal_visszad("also") != megoldas[i + 1, j].oldal_visszad("felso"))
                            {
                                return false;
                            }
                        }

                        if (i - 1 > -1 && megoldas[i - 1, j] != null)
                        {
                            if (megoldas[i, j].oldal_visszad("felso") != megoldas[i - 1, j].oldal_visszad("also"))
                            {
                                return false;
                            }
                        }

                        if (j + 1 < 3 && megoldas[i, j + 1] != null)
                        {
                            if (megoldas[i, j].oldal_visszad("jobb") != megoldas[i, j + 1].oldal_visszad("bal"))
                            {
                                return false;
                            }
                        }

                        if (j - 1 > -1 && megoldas[i, j - 1] != null)
                        {
                            if (megoldas[i, j].oldal_visszad("bal") != megoldas[i, j - 1].oldal_visszad("jobb"))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void kirakBTN_Click(object sender, EventArgs e)
        {
            mehete = true;
            rekurzio(0, adatok);
        }

        private void keverBTN_Click(object sender, EventArgs e)
        {
            List<Elem> uj = new List<Elem>() { };
            Random rand = new Random();

            for (int i = 0; i < 9; i++)
            {
                int sorszam = rand.Next(0, adatok.Count);
                uj.Add(adatok[sorszam]);
                adatok.Remove(adatok[sorszam]);

                int db = rand.Next(0, 4);

                for (int j = 0; j < db; j++)
                {
                    uj[uj.Count - 1].forgat();
                }
            }

            adatok = kivalszt(uj);
            kepekberak(false);
        }
    }
}
