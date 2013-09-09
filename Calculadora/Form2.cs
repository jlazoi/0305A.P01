using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double rptatemp;
        double temp;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
                            
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < -273.15)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Celcius es -273.15.");
            }
            else
            {
                rptatemp = temp * 9 / 5 + 32;
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < -273.15)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Celcius es -273.15.");
            }
            else
            {
                rptatemp = temp + (273.15);
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }

        private void btnFC_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < -459.58)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Fahrenheit es -459.58.");
            }
            else
            {
                rptatemp = (temp - 32) * 5 / 9;
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }

        private void btnFK_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < -459.58)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Fahrenheit es -459.58.");
            }
            else
            {
                rptatemp = (temp - 459.67) * 5 / 9;
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }

        private void btnKC_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < 0)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Kelvin es 0.");
            }
            else
            {
                rptatemp = temp - 273.15;
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }

        private void btnKF_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);
            if (temp < 0)
            {
                MessageBox.Show("VALOR INCORRECTO, el cero absoluto de Kelvin es 0.");

            }
            else
            {
                rptatemp = temp * 9 / 5 - 459.67;
                MessageBox.Show("La respuesta es: " + rptatemp);
            }
        }
    }
}

    }
}
