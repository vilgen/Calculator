using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frm_calc : Form
    {
        public frm_calc()
        {
            InitializeComponent();
        }

        private Math calc = new Math();

        private int index = 0;

        private double dbl1 = 0.0d;
        private double dbl2 = 0.0d;
        private double result = 0.0d;

        private char charAt;

        #region number buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_main.Text = txt_main.Text + "0";
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(index == 0))
                {
                    txt_main.Text = txt_main.Text.Substring(0, index);
                }
                txt_main.Text = txt_main.Text + "+";
                index = txt_main.Text.IndexOf("+");

                btn_star.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(index == 0))
                {
                    txt_main.Text = txt_main.Text.Substring(0, index);
                }
                txt_main.Text = txt_main.Text + "-";
                index = txt_main.Text.IndexOf("-");

                btn_star.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(index == 0))
                {
                    txt_main.Text = txt_main.Text.Substring(0, index);
                }
                txt_main.Text = txt_main.Text + "*";
                index = txt_main.Text.IndexOf("*");

                btn_star.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(index == 0))
                {
                    txt_main.Text = txt_main.Text.Substring(0, index);
                }
                txt_main.Text = txt_main.Text + "/";
                index = txt_main.Text.IndexOf("/");

                btn_star.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                

                dbl1 = double.Parse(txt_main.Text.Substring(0, index), CultureInfo.InvariantCulture);
                dbl2 = double.Parse(txt_main.Text.Substring(index + 1), CultureInfo.InvariantCulture);

                charAt = txt_main.Text[index];

                switch (charAt)
                {
                    case '+':
                        result = calc.add(dbl1, dbl2);
                        break;

                    case '-':
                        result = calc.substract(dbl1, dbl2);
                        break;

                    case '*':
                        result = calc.multiply(dbl1, dbl2);
                        break;

                    case '/':
                        result = calc.divide(dbl1, dbl2);
                        break;

                    default:
                        MessageBox.Show("Uygun bir operand'a basınız!");
                        break;
                }
                txt_main.Clear();
                index = 0;
                btn_star.Enabled = true;
                txt_main.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_main.Text = "";
            txt_main.Clear();
            index = 0;
            btn_star.Enabled = true;
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            try
            {
                btn_star.Enabled = false;
             txt_main.Text = txt_main.Text + ".";             
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_main.Text = txt_main.Text.Substring(0, txt_main.Text.Length - 1);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
    }
}
