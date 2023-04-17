using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            if(resultado.Text == "0" && boton != null)
            {
                resultado.Text = boton.Text;
            }
            else if(boton != null)
            {
                resultado.Text += boton.Text;
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {

            operacion = "+";
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Clear();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Clear();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            valor1 = Convert.ToDouble(resultado.Text);
            resultado.Clear();
        }

        private void buttonPotencia_Click(Object sender, EventArgs e)
        {
            operacion = "^";
            valor1 = double.Parse(resultado.Text);
            resultado.Clear();
            
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(resultado.Text);
            double result = 0;

            switch (operacion)
            {
                case "+":
                    result = valor1 + valor2;
                    break;
                case "-":
                    result = valor1 - valor2;
                    break;
                case "/":
                    result = valor1 / valor2;
                    break;
                case "*":
                    result = valor1 * valor2;
                    break;
                case "^":
                    result = Math.Pow(valor1, valor2);
                    break;

            }

            resultado.Text = result.ToString();
            operacion = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(resultado.Text == "0")
            {
                resultado.Text = "0";
            }
            else{
                resultado.Text += "0";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            operacion = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void buttonNegativo_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(resultado.Text);
            valor1 = -valor1;
            resultado.Text = valor1.ToString();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!resultado.Text.Contains("."))
            {
                resultado.Text += ".";
            }
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
