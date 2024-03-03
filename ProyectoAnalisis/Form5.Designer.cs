namespace ProyectoAnalisis
{
    partial class Form5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_NumOrdenado = new TextBox();
            txt_Num1 = new TextBox();
            txt_Num7 = new TextBox();
            txt_Num6 = new TextBox();
            txt_Num5 = new TextBox();
            txt_Num4 = new TextBox();
            txt_Num3 = new TextBox();
            txt_Num2 = new TextBox();
            btn_Ordenar = new Button();
            cmb_Ordenamiento = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 15);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Algoritmos de ordenamiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 82);
            label2.Name = "label2";
            label2.Size = new Size(352, 15);
            label2.TabIndex = 1;
            label2.Text = "A continuacion coloque una secuencia desordenada de numeros:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 217);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 2;
            label3.Text = "Los numeros ordenados son:";
            // 
            // txt_NumOrdenado
            // 
            txt_NumOrdenado.Location = new Point(276, 313);
            txt_NumOrdenado.Name = "txt_NumOrdenado";
            txt_NumOrdenado.Size = new Size(251, 23);
            txt_NumOrdenado.TabIndex = 3;
            // 
            // txt_Num1
            // 
            txt_Num1.Location = new Point(94, 114);
            txt_Num1.Name = "txt_Num1";
            txt_Num1.Size = new Size(54, 23);
            txt_Num1.TabIndex = 4;
            // 
            // txt_Num7
            // 
            txt_Num7.Location = new Point(654, 114);
            txt_Num7.Name = "txt_Num7";
            txt_Num7.Size = new Size(54, 23);
            txt_Num7.TabIndex = 5;
            // 
            // txt_Num6
            // 
            txt_Num6.Location = new Point(556, 114);
            txt_Num6.Name = "txt_Num6";
            txt_Num6.Size = new Size(54, 23);
            txt_Num6.TabIndex = 6;
            // 
            // txt_Num5
            // 
            txt_Num5.Location = new Point(456, 114);
            txt_Num5.Name = "txt_Num5";
            txt_Num5.Size = new Size(54, 23);
            txt_Num5.TabIndex = 7;
            // 
            // txt_Num4
            // 
            txt_Num4.Location = new Point(371, 114);
            txt_Num4.Name = "txt_Num4";
            txt_Num4.Size = new Size(54, 23);
            txt_Num4.TabIndex = 8;
            // 
            // txt_Num3
            // 
            txt_Num3.Location = new Point(276, 114);
            txt_Num3.Name = "txt_Num3";
            txt_Num3.Size = new Size(54, 23);
            txt_Num3.TabIndex = 9;
            // 
            // txt_Num2
            // 
            txt_Num2.Location = new Point(193, 114);
            txt_Num2.Name = "txt_Num2";
            txt_Num2.Size = new Size(54, 23);
            txt_Num2.TabIndex = 10;
            // 
            // btn_Ordenar
            // 
            btn_Ordenar.Location = new Point(535, 213);
            btn_Ordenar.Name = "btn_Ordenar";
            btn_Ordenar.Size = new Size(75, 23);
            btn_Ordenar.TabIndex = 11;
            btn_Ordenar.Text = "Ordenar";
            btn_Ordenar.UseVisualStyleBackColor = true;
            btn_Ordenar.Click += btn_Ordenar_Click;
            // 
            // cmb_Ordenamiento
            // 
            cmb_Ordenamiento.FormattingEnabled = true;
            cmb_Ordenamiento.Items.AddRange(new object[] { "Bubble Sort", "Heap Sort", "Selection Sort", "Merge Sort" });
            cmb_Ordenamiento.Location = new Point(344, 182);
            cmb_Ordenamiento.Name = "cmb_Ordenamiento";
            cmb_Ordenamiento.Size = new Size(129, 23);
            cmb_Ordenamiento.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 155);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 13;
            label4.Text = "Elige una opcion";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cmb_Ordenamiento);
            Controls.Add(btn_Ordenar);
            Controls.Add(txt_Num2);
            Controls.Add(txt_Num3);
            Controls.Add(txt_Num4);
            Controls.Add(txt_Num5);
            Controls.Add(txt_Num6);
            Controls.Add(txt_Num7);
            Controls.Add(txt_Num1);
            Controls.Add(txt_NumOrdenado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_NumOrdenado;
        private TextBox txt_Num1;
        private TextBox txt_Num7;
        private TextBox txt_Num6;
        private TextBox txt_Num5;
        private TextBox txt_Num4;
        private TextBox txt_Num3;
        private TextBox txt_Num2;
        private Button btn_Ordenar;
        private ComboBox cmb_Ordenamiento;
        private Label label4;
    }
}