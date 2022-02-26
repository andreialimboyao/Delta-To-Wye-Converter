using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float r1, r2, r3, ra, rb, rc;
        int conv, delta, wye;
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != " ")
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                wye = wye + 1;
            }
            else
            {
                wye = wye - 1;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != " ")
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                wye = wye + 1;
            }
            else
            {
                wye = wye - 1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != " ")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                delta = delta + 1;
            }
            else
            {
                delta = delta - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r1 = 0;
            r2 = 0;
            r3 = 0;
            ra = 0;
            rb = 0;
            rc = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            conv = 0;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != " ")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                delta = delta + 1;
            }
            else
            {
                delta = delta - 1;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != " ")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                delta = delta + 1;
            }
            else
            {
                delta = delta - 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                wye = wye + 1;
            }
            else
            {
                wye = wye - 1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wye == 3)
            {
                conv = 2;
            }
            else if (delta == 3)
            {
                conv = 1;
            }
            else
            {
                MessageBox.Show("Please Enter THREE Inputs");
            }
            switch (conv)
            {
                case 1:
                    ra = float.Parse(textBox4.Text);
                    rb = float.Parse(textBox5.Text);
                    rc = float.Parse(textBox6.Text);
                    r1 = (rb * rc) / (ra + rb + rc);
                    r2 = (rc * ra) / (ra + rb + rc);
                    r3 = (ra * rb) / (ra + rb + rc);
                    textBox1.Text = r1.ToString();
                    textBox2.Text = r2.ToString();
                    textBox3.Text = r3.ToString();
                    break;
                case 2:
                    r1 = float.Parse(textBox1.Text);
                    r2 = float.Parse(textBox2.Text);
                    r3 = float.Parse(textBox3.Text);
                    ra = ((r1 * r2) + (r2 * r3) + (r3 * r1)) / r1;
                    rb = ((r1 * r2) + (r2 * r3) + (r3 * r1)) / r2;
                    rc = ((r1 * r2) + (r2 * r3) + (r3 * r1)) / r3;
                    textBox4.Text = ra.ToString();
                    textBox5.Text = rb.ToString();
                    textBox6.Text = rc.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
