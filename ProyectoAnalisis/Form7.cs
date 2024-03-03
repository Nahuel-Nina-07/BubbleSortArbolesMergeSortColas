namespace ProyectoAnalisis
{
    public partial class Form7 : Form
    {
        private int n = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string estado = txtEstado.Text;

            if (string.IsNullOrWhiteSpace(nombre) || !EsNombreValido(nombre))
            {
                MessageBox.Show("El campo Nombre es obligatorio y solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(estado) || !EsNombreValido(estado))
            {
                MessageBox.Show("El campo Estado es obligatorio y solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int filaIndex = datos.Rows.Add();
            datos.Rows[filaIndex].Cells[0].Value = nombre;
            datos.Rows[filaIndex].Cells[1].Value = estado;
            datos.Rows[filaIndex].Cells[2].Value = txtSexo.Text;

            txtNombre.Text = "";
            txtEstado.Text = "";
            txtSexo.Text = "";
        }

        private bool EsNombreValido(string nombre)
        {
            return !string.IsNullOrWhiteSpace(nombre) && nombre.All(char.IsLetter);
        }
        private void datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                datos.Rows.RemoveAt(n);
            }

        }


    }
}