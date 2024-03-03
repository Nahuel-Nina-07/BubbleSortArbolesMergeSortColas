using System.Text;
using System.Windows.Forms;
namespace ProyectoAnalisis
{
    public partial class Form8 : Form
    {
        Arbol arbol;
        NodoArbol nodo;
        public Form8()
        {
            arbol = new Arbol();
            nodo = new NodoArbol();
            InitializeComponent();

            btn_Subarbol.Click += btn_Subarbol_Click;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Numero.Text, out int numero))
            {
                arbol.crearArbol(numero);
                txt_Numero.Clear();
                txt_Numero.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese solo números en el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_preOrden_Click(object sender, EventArgs e)
        {
            lst_Orden.Items.Clear();
            NodoArbol auxiliar;
            auxiliar = arbol.devolverRaiz();
            preOrden(auxiliar);
        }
        private void preOrden(NodoArbol numeroPreOrden)
        {
            if (numeroPreOrden != null)
            {
                lst_Orden.Items.Add(numeroPreOrden.Numero);
                preOrden(numeroPreOrden.Izquierda);
                preOrden(numeroPreOrden.Derecha);
            }
        }
        private void btn_Nivel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_NumeroNivel.Text, out int numeroBusqueda))
            {
                int nivel = arbol.obtenerNivel(numeroBusqueda);
                txt_Nivel.Text = $"El número {numeroBusqueda} se encuentra en el nivel {nivel}";
                txt_NumeroNivel.Clear();
                txt_NumeroNivel.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese solo números en el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_MayRaiz_Click(object sender, EventArgs e)
        {
            List<int> mayoresRaiz = arbol.obtenerMayoresRaiz();
            string numerosSeparados = string.Join(", ", mayoresRaiz);
            txt_MayRaiz.Text = "Los números mayores a la raíz son: " + numerosSeparados;
        }
        private void btn_MenRaiz_Click(object sender, EventArgs e)
        {
            List<int> menoresRaiz = arbol.obtenerMenoresRaiz();
            string numerosSeparados = string.Join(", ", menoresRaiz);
            txt_MenRaiz.Text = "Los números menores a la raíz son: " + numerosSeparados;
        }
        private void btn_inOrden_Click(object sender, EventArgs e)
        {
            lst_Orden.Items.Clear();
            List<int> inOrden = arbol.obtenerInOrden();
            foreach (int numero in inOrden)
            {
                lst_Orden.Items.Add(numero);
            }
        }
        private void btn_postOrden_Click(object sender, EventArgs e)
        {
            lst_Orden.Items.Clear();
            List<int> postOrden = arbol.obtenerPostOrden();
            foreach (int numero in postOrden)
            {
                lst_Orden.Items.Add(numero);
            }

        }
        private void btn_Amplitud_Click(object sender, EventArgs e)
        {
            lst_Orden.Items.Clear();
            List<int> amplitud = arbol.obtenerAmplitud();
            foreach (int numero in amplitud)
            {
                lst_Orden.Items.Add(numero);
            }
        }
        private void btn_Altura_Click(object sender, EventArgs e)
        {
            lst_Orden.Items.Clear();
            int altura = arbol.obtenerAltura();
            lst_Orden.Items.Add("La altura del árbol es: " + altura);
        }

        private void btn_Subarbol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Subarbol.Text, out int numeroBusqueda))
            {
                NodoArbol subArbol = obtenerSubArbol(arbol.devolverRaiz(), numeroBusqueda);
                if (subArbol != null)
                {
                    lst_Orden.Items.Clear();
                    preOrden(subArbol);
                }
                else
                {
                    MessageBox.Show("El número no existe en el árbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese solo números en el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NodoArbol obtenerSubArbol(NodoArbol nodoActual, int numeroBusqueda)
        {
            if (nodoActual == null)
                return null;

            if (nodoActual.Numero == numeroBusqueda)
                return nodoActual;

            NodoArbol subArbolIzquierdo = obtenerSubArbol(nodoActual.Izquierda, numeroBusqueda);
            if (subArbolIzquierdo != null)
                return subArbolIzquierdo;

            NodoArbol subArbolDerecho = obtenerSubArbol(nodoActual.Derecha, numeroBusqueda);
            if (subArbolDerecho != null)
                return subArbolDerecho;

            return null;
        }
    }
}