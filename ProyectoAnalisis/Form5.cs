namespace ProyectoAnalisis
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            cmb_Ordenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Ordenamiento.SelectedIndex = 0;
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[7];

            if (!ValidarNumeros(numeros))
                return;

            string opcionOrdenamiento = cmb_Ordenamiento.SelectedItem.ToString();

            switch (opcionOrdenamiento)
            {
                case "Bubble Sort":
                    BubbleSort(numeros);
                    break;
                case "Heap Sort":
                    HeapSort(numeros);
                    break;
                case "Selection Sort":
                    SelectionSort(numeros);
                    break;
                case "Merge Sort":
                    MergeSort(numeros, 0, numeros.Length - 1);
                    break;
                default:
                    break;
            }

            txt_NumOrdenado.Text = string.Join(", ", numeros);
        }

        private bool ValidarNumeros(int[] numeros)
        {
            TextBox[] textBoxes = { txt_Num1, txt_Num2, txt_Num3, txt_Num4, txt_Num5, txt_Num6, txt_Num7 };

            for (int i = 0; i < numeros.Length; i++)
            {
                string texto = textBoxes[i].Text.Trim();
                if (!int.TryParse(texto, out int numero) || numero <= 0)
                {
                    MessageBox.Show("Ingrese números positivos en todos los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                numeros[i] = numero;
            }

            return true;
        }

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        private void HeapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[largest])
                largest = l;

            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }
        private void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[middle + 1 + j];

            int k = left;
            int x = 0, y = 0;

            while (x < n1 && y < n2)
            {
                if (L[x] <= R[y])
                {
                    arr[k] = L[x];
                    x++;
                }
                else
                {
                    arr[k] = R[y];
                    y++;
                }
                k++;
            }

            while (x < n1)
            {
                arr[k] = L[x];
                x++;
                k++;
            }

            while (y < n2)
            {
                arr[k] = R[y];
                y++;
                k++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}