using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302220093
{
    public partial class Form1 : Form
    {
        public int tampung1, tampung2, tampung3, hasil;
        public string tampungS1, tampungS2, tampungS3;
        public bool cek = false;
        public bool cektambah = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "1";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "2";
                cek = true;
            } else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "3";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "4";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "5";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "6";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "7";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "8";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "9";
                cek = true;
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cek == false)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            cek = false;
            if (cektambah == false)
            {
                tampung1 = Convert.ToInt32(label1.Text);
                label1.Text = label1.Text + " + ";
                tampungS1 = label1.Text;
                cektambah = true;
            } else
            {
                tampung2 = Convert.ToInt32(label1.Text);
                label1.Text = label1.Text + " + ";
                tampungS2 = tampungS1 + label1.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tampungS3 = label1.Text;
            tampung3 = Convert.ToInt32(label1.Text);
            hasil = tampung1 + tampung2 + tampung3;
            label1.Text = " = " + Convert.ToString(hasil);
        }
    }
}
