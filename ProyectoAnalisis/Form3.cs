using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoAnalisis
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Tick += Timer_Tick;
            label3.Visible = false;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 109, 130);
            button1.BackColor = Color.FromArgb(39, 55, 77);
            button1.ForeColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 109, 130);
            button1.TabStop = false;
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            if (!string.IsNullOrEmpty(texto))
            {
                // Convertir todo el texto a minúsculas y luego la primera letra a mayúscula
                string textoFormateado = texto.ToLower();
                textoFormateado = char.ToUpper(textoFormateado[0]) + textoFormateado.Substring(1);

                // Agregar el texto formateado a la ListBox
                listBox1.Items.Add(textoFormateado);

                // Limpiar el TextBox
                textBox1.Text = string.Empty;

            }
            else
            {
                label3.Visible = true;
                label3.Text = "Ingrese una frase o palabra";
                label3.ForeColor = Color.Red;
                timer1.Start();

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(82, 109, 130);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(39, 55, 77);
        }
    }
}
