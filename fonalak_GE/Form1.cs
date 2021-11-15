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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            alap_general();
        }

        private void alap_general()
        {
            alapPANEL.Controls.Clear();
            int szeles = (alapPANEL.Width - 24) / 3;

            int x = 12;
            int y = 12;

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
                    pn.Image = kepekIMAGELIST.Images[0];
                    pn.SizeMode = PictureBoxSizeMode.Zoom;

                    x += szeles;
                }
                x = 12;
                y += szeles;
            }

            //(alapPANEL.Controls[0] as PictureBox).Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }
    }
}
