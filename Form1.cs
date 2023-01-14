using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorResponsi
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "0";
            }
        }

        private void btn_clear_entry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay2.Text = " ";
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "+";
            txtDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "-";
            txtDisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "x";
            txtDisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "÷";
            txtDisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay.Text);
            {
                switch(opr)
                {
                    case 1:
                        txtDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                    case 2:
                        txtDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 3:
                        txtDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 4:
                        txtDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                }
                opr_selesai = false;
            }
        }

        private void btn_rootsquare_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Sqrt(Double.Parse(txtDisplay.Text))).ToString();
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Double.Parse(txtDisplay.Text) * 0.01).ToString();
        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (1 / Double.Parse(txtDisplay.Text)).ToString();
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Double.Parse(txtDisplay.Text) * Double.Parse(txtDisplay.Text)).ToString();
        }

        private void btn_clear_char_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
        }
    }
}
