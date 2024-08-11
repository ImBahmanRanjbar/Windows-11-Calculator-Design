using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_10_Calculator
{
    public partial class Form1 : Form
    {
        double result;
        string op = "";
        bool entervalue=false
            ;
        string fstNum, secNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 345 : 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bahmanButtonControl7_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            txtDisplay2.Text = "";
            result = 0;
        }

        private void BtnMathOp_Click(object sender, EventArgs e)
        {
            if (result!=0)
            {
                btnEquals.PerformClick();
            }
            else
            {
                result = double.Parse(txtDisplay1.Text);

            }


            op = ((Button)sender).Text;
            entervalue = true;
            if (txtDisplay1.Text!="0")
            {
                txtDisplay2.Text = fstNum = $"{result} {op}";
                txtDisplay1.Text = "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secNum = txtDisplay1.Text;
            txtDisplay2.Text = $"{txtDisplay2.Text}{txtDisplay1.Text}=";
            if (txtDisplay1.Text!="")
            {
                if (txtDisplay1.Text=="0")
                {
                    txtDisplay2.Text = "";
                }
                switch (op)
                {
                    case "+":
                        txtDisplay1.Text=(result + double.Parse(txtDisplay1.Text).ToString());
                        richTextBox1.AppendText($"{fstNum}{secNum}={txtDisplay1.Text}\n");

                        break;
                    case "-":
                        txtDisplay1.Text = (result - double.Parse(txtDisplay1.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum}{secNum}={txtDisplay1.Text}\n");
                        break;
                    case "x":
                        txtDisplay1.Text = (result * double.Parse(txtDisplay1.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum}{secNum}={txtDisplay1.Text}\n");
                        break;
                    case "÷":
                        txtDisplay1.Text = (result / double.Parse(txtDisplay1.Text)).ToString();
                        richTextBox1.AppendText($"{fstNum}{secNum}={txtDisplay1.Text}\n");
                        break;
                    default:txtDisplay2.Text = $"{txtDisplay1.Text}=";
                        break;

                }
                result = double.Parse(txtDisplay1.Text);
                op = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclearhistory_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 345 : 5;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length>0)
            {
                txtDisplay1.Text = txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1, 1);
            }
            if (txtDisplay1.Text=="")
            {
                txtDisplay1.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }

        private void BtnOps_Click(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            switch (op)
            {
                case "√x":
                    txtDisplay2.Text = $"√({txtDisplay1.Text})";
                    txtDisplay1.Text = (Math.Sqrt(double.Parse(txtDisplay1.Text))).ToString();
                    break;
                case "^2":
                    txtDisplay2.Text = $"({txtDisplay1.Text})^2";
                    txtDisplay1.Text = ((double.Parse(txtDisplay1.Text)* double.Parse(txtDisplay1.Text))).ToString();
                    break;
                case "1⁄x":
                    txtDisplay2.Text = $"1⁄({txtDisplay1.Text})";
                    txtDisplay1.Text = (1.0/ double.Parse(txtDisplay1.Text)).ToString();
                    break;
                case "%":
                    txtDisplay2.Text = $"%({txtDisplay1.Text})";
                    txtDisplay1.Text = ( double.Parse(txtDisplay1.Text)/100.0).ToString();
                    break;
                case "±":
                    txtDisplay1.Text = (-1 * double.Parse(txtDisplay1.Text)).ToString();
                    break;
            }
            richTextBox1.AppendText($"{txtDisplay2.Text}={txtDisplay1.Text}\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Demo", "ImBahmanRanjbar");
        }

        private void BtnNum_click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0" || entervalue)
                txtDisplay1.Text = "";
            entervalue = false;
            if (((Button)sender).Text==".")
            {
                if (!txtDisplay1.Text.Contains("."))
                {
                    txtDisplay1.Text += ((Button)sender).Text;
                }
              
            }
            else
            {
                txtDisplay1.Text += ((Button)sender).Text;
            }
            
        }
    }
}
