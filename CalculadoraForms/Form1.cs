using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
        
    {
        double n1 = 0;
        double n2 = 0;
        string opc = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "1";
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            txbresultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbresultado.Text += "0";
        }

        private void btnadicao_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text == "")
            {
                if (n1 != 0)
                {
                    opc = "+";
                    txbopc.Text = n1.ToString() + " " + opc;
                }
                return;
            }
            n1 = double.Parse(txbresultado.Text);
            opc = "+";
            txbopc.Text = n1.ToString() + " " + opc;
            txbresultado.Clear();
        }




        private void btnsubt_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text == "")
            {
                if (n1 != 0)
                {
                    opc = "-";
                    txbopc.Text = n1.ToString() + " " + opc;
                }
                return;
            }
            n1 = double.Parse(txbresultado.Text);
                opc = "-";
                txbopc.Text = n1.ToString() + " " + opc;
                txbresultado.Clear();
            }
           
       

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text == "")
            {
                if (n1 != 0)
                {
                    opc = "*";
                    txbopc.Text = n1.ToString() + " " + opc;
                }
                return;
            }
            n1 = double.Parse(txbresultado.Text);
            opc = "*";
            txbopc.Text = n1.ToString() + " " + opc;
            txbresultado.Clear();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text == "")
            {
                if (n1 != 0)
                {
                    opc = "/";
                    txbopc.Text = n1.ToString() + " " + opc;
                }
                return;
            }
            n1 = double.Parse(txbresultado.Text);
            opc = "/";
            txbopc.Text = n1.ToString() + " " + opc;
            txbresultado.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text == "" )
            {
                MessageBox.Show("Atribua um valor antes de iniciar!");
                
                    return;
            }
            n2 = double.Parse(txbresultado.Text);
            double resultado = 0;
            if (opc == "+")
            {
                resultado = n1 + n2;
            }
            else if (opc == "-")
            {
                resultado = n1 - n2;
            }
            else if (opc == "*")
            {
                resultado = n1 * n2;
            }
            else if(opc == "/")
            {
                if(n2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!");
                    return;
                }
                resultado = n1 / n2;
            }
            txbopc.Text = n1.ToString() +" " + opc + " " + n2.ToString() + " =";
            txbresultado.Text = resultado.ToString();

            n1 = resultado;
            opc = "";

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txbresultado.Clear();
            txbopc.Clear();
            n1 = 0;
            n2 = 0;
            opc = "";
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (txbresultado.Text.Length > 0)
            {
                txbresultado.Text = txbresultado.Text.Substring(0,txbresultado.Text.Length - 1);
            }
        }
    }
}
