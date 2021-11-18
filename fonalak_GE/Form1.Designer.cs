
namespace fonalak_GE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.alapPANEL = new System.Windows.Forms.Panel();
            this.keverBTN = new System.Windows.Forms.Button();
            this.kirakBTN = new System.Windows.Forms.Button();
            this.kepekIMAGELIST = new System.Windows.Forms.ImageList(this.components);
            this.szamlaloLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alapPANEL
            // 
            this.alapPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.alapPANEL.Location = new System.Drawing.Point(99, 12);
            this.alapPANEL.Name = "alapPANEL";
            this.alapPANEL.Size = new System.Drawing.Size(500, 500);
            this.alapPANEL.TabIndex = 0;
            // 
            // keverBTN
            // 
            this.keverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keverBTN.Location = new System.Drawing.Point(99, 530);
            this.keverBTN.Name = "keverBTN";
            this.keverBTN.Size = new System.Drawing.Size(238, 40);
            this.keverBTN.TabIndex = 1;
            this.keverBTN.Text = "Kever";
            this.keverBTN.UseVisualStyleBackColor = true;
            this.keverBTN.Click += new System.EventHandler(this.keverBTN_Click);
            // 
            // kirakBTN
            // 
            this.kirakBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kirakBTN.Location = new System.Drawing.Point(361, 530);
            this.kirakBTN.Name = "kirakBTN";
            this.kirakBTN.Size = new System.Drawing.Size(238, 40);
            this.kirakBTN.TabIndex = 2;
            this.kirakBTN.Text = "Kirak";
            this.kirakBTN.UseVisualStyleBackColor = true;
            this.kirakBTN.Click += new System.EventHandler(this.kirakBTN_Click);
            // 
            // kepekIMAGELIST
            // 
            this.kepekIMAGELIST.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kepekIMAGELIST.ImageStream")));
            this.kepekIMAGELIST.TransparentColor = System.Drawing.Color.Transparent;
            this.kepekIMAGELIST.Images.SetKeyName(0, "elem_1.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(1, "elem_2.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(2, "elem_3.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(3, "elem_4.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(4, "elem_5.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(5, "elem_6.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(6, "elem_7.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(7, "elem_8.jpg");
            this.kepekIMAGELIST.Images.SetKeyName(8, "elem_9.jpg");
            // 
            // szamlaloLBL
            // 
            this.szamlaloLBL.AutoSize = true;
            this.szamlaloLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamlaloLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.szamlaloLBL.Location = new System.Drawing.Point(94, 573);
            this.szamlaloLBL.Name = "szamlaloLBL";
            this.szamlaloLBL.Size = new System.Drawing.Size(24, 25);
            this.szamlaloLBL.TabIndex = 3;
            this.szamlaloLBL.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(697, 625);
            this.Controls.Add(this.szamlaloLBL);
            this.Controls.Add(this.kirakBTN);
            this.Controls.Add(this.keverBTN);
            this.Controls.Add(this.alapPANEL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel alapPANEL;
        private System.Windows.Forms.Button keverBTN;
        private System.Windows.Forms.Button kirakBTN;
        private System.Windows.Forms.ImageList kepekIMAGELIST;
        private System.Windows.Forms.Label szamlaloLBL;
    }
}

