using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuerzaResultante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Se calcula el vector resultante.
            try
            {
                // F = Fuerza
                // a = ángulo
                // Fx = Fuerzas en x
                // Fy = Fuerzas en y
                // Fr = Fuerza resultante
                // ar = ángulo resultante
                double F1, F2, F3, a1, a2, a3, Fx, Fy, Fr, ar;
                
                // Captura de información para las variables.
                F1 = double.Parse(textBox1.Text);
                F2 = double.Parse(textBox3.Text);
                F3 = double.Parse(textBox5.Text);
                a1 = double.Parse(textBox2.Text);
                a2 = double.Parse(textBox4.Text);
                a3 = double.Parse(textBox6.Text);

                // Cálculo de fuerzas sobre los ejes.
                Fx = F1 * Math.Cos(a1 * (Math.PI / 180)) + F2 * Math.Cos(a2 * (Math.PI / 180)) + F3 * Math.Cos(a3 * (Math.PI / 180));
                Fy = F1 * Math.Sin(a1 * (Math.PI / 180)) + F2 * Math.Sin(a2 * (Math.PI / 180)) + F3 * Math.Sin(a3 * (Math.PI / 180));

                // Cálculo de fuerza resultante.
                Fr = Math.Sqrt(Math.Pow(Fx, 2) + Math.Pow(Fy, 2));

                // Cálculo de ángulo resultante.
                ar = Math.Atan(Fy / Fx) * (180 / Math.PI);
                if (ar < 0)
                {
                    ar += 360;
                }

                // Despliegue de resultados
                textBox7.Text = Fr.ToString();
                textBox8.Text = ar.ToString();
                pictureBox1.Visible = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Favor de ingresar valores válidos.\n\n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error desconocido.\n\n" + ex);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Limpieza del programa. Se regresa al estado como inició el programa.
            textBox1.Text = "10";
            textBox2.Text = "90";
            textBox3.Text = "20";
            textBox4.Text = "245";
            textBox5.Text = "30";
            textBox6.Text = "350";
            textBox7.Text = "";
            textBox8.Text = "";
            pictureBox1.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Salida del programa
            Close();
        }
    }
}