namespace ProyectoAnalisis
{
    public partial class Form6 : Form
    {
        Pila Registro;
        Pila RegistroAux;
        public Form6()
        {
            Registro = new Pila();
            RegistroAux = new Pila();
            InitializeComponent();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            string Nombre = TB_nombre.Text;
            string Edad = TB_edad.Text;
            string Celular = TB_celular.Text;

            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Edad) || string.IsNullOrWhiteSpace(Celular))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsNombreValido(Nombre))
            {
                MessageBox.Show("El campo Nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsEdadValida(Edad))
            {
                MessageBox.Show("El campo Edad debe ser valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsCelularValido(Celular))
            {
                MessageBox.Show("El campo Celular debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Registro.Apilar(Nombre, Edad, Celular);
            TB_nombre.Clear();
            TB_edad.Clear();
            TB_celular.Clear();

            TB_nombre.Focus();
            TB_edad.Focus();
            TB_celular.Focus();
        }

        private bool EsNombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && nombre.All(char.IsLetter);
        }

        private bool EsEdadValida(string edad)
        {
            if (int.TryParse(edad, out int edadNumerica))
            {
                return edadNumerica >= 0 && edadNumerica <= 120;
            }

            return false;
        }

        private bool EsCelularValido(string celular)
        {
            return int.TryParse(celular, out int celularNumerico) && celularNumerico >= 0;
        }


        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            if (Registro.devolverFinal() != null)
            {
                LB_listaPilas.Items.Clear();
                copiarPila();
            }
        }

        private void copiarPila()
        {
            NodoPila aux;
            while (Registro.devolverFinal() != null)
            {
                aux = Registro.Desapilar();
                LB_listaPilas.Items.Add(aux.getNombre() + "  " + aux.getEdad() + "  " + aux.getCelular());
                RegistroAux.Apilar(aux.getNombre(), aux.getEdad(), aux.getCelular());
            }
            while (RegistroAux.devolverFinal() != null)
            {
                aux = RegistroAux.Desapilar();
                Registro.Apilar(aux.getNombre(), aux.getEdad(), aux.getCelular());
            }
        }
        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            NodoPila aux = Registro.Desapilar();
            if (Registro.devolverFinal() == null)
            {
                MessageBox.Show("existen errores");
            }
            else
            {
                MessageBox.Show("Se esta desapilando el elemento:  " + aux.getNombre() + "," + aux.getEdad() + "," + aux.getCelular());
                LB_listaPilas.Items.Clear();
                Btn_mostrar_Click(sender, e);
            }
        }
    }
}