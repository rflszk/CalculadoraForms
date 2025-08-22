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
        string hist = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void numero_Click(object sender, EventArgs e)
        {
            Button numclick = (Button)sender;   
            txbresultado.Text += numclick.Text;
            

        }

        private void opc_Click(object sender, EventArgs e)
        {
            
            
          
                
            Button opcclick = (Button)sender;

            if (txbresultado.Text == "")
            {
               if(hist.Length > 0)
                {
                    hist = hist.Substring(0, hist.Length - 1) + opcclick.Text.Replace("X", "*");
                    txbopc.Text = hist;
                    opc = opcclick.Text.Replace("X","*");
                }
               return;
            }
            if (n1 == 0)
            {
                n1 = double.Parse(txbresultado.Text);
                hist = n1.ToString() + " " + opcclick.Text.Replace("X", "*");
            }
            else
            {
                n2 = double.Parse(txbresultado.Text);
                if (opc == "+")
                {
                    n1 = n1 + n2;
                }
                else if (opc == "-")
                {
                    n1 = n1 - n2;
                }
                else if (opc == "*")
                {
                   n1 = n1 * n2;
                }
                else if (opc == "/")
                {
                    if (n2 == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!");
                        return;
                    }
                    n1 = n1 / n2;
                }
                hist += " " + n2.ToString() + " " + opcclick.Text.Replace("X", "*");
            }
           opc = opcclick.Text.Replace("X", "*");
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
