using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text .RegularExpressions ;


namespace Calculadora
{
    public partial class Form1 : Form
    {
         TextBox texto1 = new TextBox(), texto2 = new TextBox();
        Button boton = new Button();
        public Form1()
        {
            InitializeComponent();
            
        }
        int num1, num2, rpta;
        string operacion;
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnRPTA_Click(object sender, EventArgs e)
        {
        
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = int.Parse(txtnum1.Text);
            txtnum1.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = int.Parse(txtnum1.Text);
            txtnum1.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = int.Parse(txtnum1.Text);
            txtnum1.Text = "";
                    }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = int.Parse(txtnum1.Text);
            txtnum1.Text = "";
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtnum1.Text);
            switch (operacion)
            {
                case "+":
                    rpta = num1 + num2;
                    break;
                case "-":
                    rpta = num1 - num2;
                    break;
                case "*":
                    rpta = num1 * num2;
                    break;
                case "/":
                    rpta = num1 / num2;
                    break;                    
            }
         

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

