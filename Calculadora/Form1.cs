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
            this.Text = "Ejemplos de Tipos";

           
            texto1.Top = 30;
            texto1.Left = 30;

            texto2.Top = 60;
            texto2.Left = 30;
            
            // otra forma de establecer posición
            boton.Location = new System.Drawing.Point(30, 90);

            boton.Text = "Sumar";

            // vincular al botón el evento click
            boton.Click += new System.EventHandler(boton_Click);
            
            // agregando controles al formulario
            this.Controls.Add(texto1);
            this.Controls.Add(texto2);
            this.Controls.Add(boton);
        }

         

        void boton_Click(object sender, EventArgs e)
        {
            
            if (texto1.Text == "" || texto2.Text == "")
            {
                MessageBox.Show("Uno de los textos está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!(new Regex(@"^[0-9]+$")).IsMatch(texto1.Text) || !(new Regex(@"^[0-9]+$")).IsMatch(texto2.Text))
            {
                MessageBox.Show("Uno de los textos no es un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           

            int val1 = Convert.ToInt32(texto1.Text);
            int val2 = Convert.ToInt32(texto2.Text);
            int suma = val1 + val2;
            MessageBox.Show("La suma es igual a " + Convert.ToString(suma), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

