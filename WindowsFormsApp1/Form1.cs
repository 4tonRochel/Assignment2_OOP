using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool value = false;
        String operation = "";
        String[] n;
        Double result = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")");
            cos = Math.Cos(cos);
            txtDisplay.Text = System.Convert.ToString(cos);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double x;

            x = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void button37_Click(object sender, EventArgs e)
        {
             Double x;

            x = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(x);
        
        }

        private void Numbers(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (value)) txtDisplay.Text = "";
            value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void arithmetic(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lbl.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lbl.Text = "";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double x;

            x = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            else
                txtDisplay.Text = "-" + txtDisplay.Text;
        }

        private void btnNFac_Click(object sender, EventArgs e)
        {
            result = 1;
            n = txtDisplay.Text.Split();
            int num = Convert.ToInt16(n[0]);

            for (int i = 1; i < num + 1; i++)
            {
                result *= (Convert.ToDouble(i));
            }

            txtDisplay.Text = Convert.ToString(result);
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589793238";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double sroot = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("√" + (txtDisplay.Text));
            sroot = Math.Sqrt(sroot);
            txtDisplay.Text = System.Convert.ToString(sroot);
        }

        private void btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            lnx = Math.Log(lnx);
            txtDisplay.Text = System.Convert.ToString(lnx);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x, 2);
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x, 16);
        }

        private void btnOcta_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x, 8);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text);
            result = Math.Exp(result);
            txtDisplay.Text = result.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtDisplay.Text);
            result = (result % double.Parse(txtDisplay.Text));
            txtDisplay.Text = result.ToString();
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            Double x;

            x = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = System.Convert.ToString(sin);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")");
            tan = Math.Tan(tan);
            txtDisplay.Text = System.Convert.ToString(tan);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")");
            sinh = Math.Sinh(sinh);
            txtDisplay.Text = System.Convert.ToString(sinh);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")");
            cosh = Math.Cosh(cosh);
            txtDisplay.Text = System.Convert.ToString(cosh);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")");
            tanh = Math.Tanh(tanh);
            txtDisplay.Text = System.Convert.ToString(tanh);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            log = Math.Log10(log);
            txtDisplay.Text = System.Convert.ToString(log);
        }

        private void btncuberoot_Click(object sender, EventArgs e)
        {
            double croot = Double.Parse(txtDisplay.Text);
            lbl.Text = System.Convert.ToString("3√" + "(" + (txtDisplay.Text) + ")");
            croot = (Math.Pow(croot, (double)1.0 / 3.0));
            txtDisplay.Text = System.Convert.ToString(croot);
        }
    }
}
