//Integrantes 
//Cristian Martinez
//Luis Luna
//Cristian Nahuel Nina
//Pablo Guerrero
namespace ProyectoAnalisis
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBox1.KeyDown += TextBox_KeyDown;
            textBox2.KeyDown += TextBox_KeyDown;
            timer1.Tick += Timer_Tick;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contrase�a = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrase�a))
            {
                // Validaci�n de campos vac�os
                label4.Visible = true;
                timer1.Start();
                label4.Text = "Por favor, ingrese el usuario y la contrase�a.";
                label4.ForeColor = Color.Red;
            }
            else if (ValidarCredenciales(usuario, contrase�a))
            {
                Form2 abrir = new Form2();
                abrir.Show();
                this.Hide();
            }
            else
            {
                // Credenciales inv�lidas, mostrar mensaje de error
                label4.Visible = true;
                timer1.Start();
                label4.Text = "Usuario o contrase�a incorrecta.";
                label4.ForeColor = Color.Red;

            }
        }
        private bool ValidarCredenciales(string usuario, string contrase�a)
        {
            // Aqu� puedes implementar la l�gica de validaci�n de las credenciales
            // Por ejemplo, verificar en una base de datos si el usuario y la contrase�a son correctos

            // Retornar true si las credenciales son v�lidas, false en caso contrario
            return (usuario == "usuario" && contrase�a == "contrase�a");
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se produzca el sonido de "beep"
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label4.Visible = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
        }
    }
}