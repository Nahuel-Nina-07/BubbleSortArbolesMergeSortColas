namespace ProyectoAnalisis
{
    partial class Form8
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
            lst_Orden = new ListBox();
            txt_Numero = new TextBox();
            label1 = new Label();
            btn_Registrar = new Button();
            btn_preOrden = new Button();
            btn_inOrden = new Button();
            btn_postOrden = new Button();
            btn_Amplitud = new Button();
            btn_Altura = new Button();
            btn_Nivel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Subarbol = new TextBox();
            txt_MenRaiz = new TextBox();
            btn_MenRaiz = new Button();
            btn_MayRaiz = new Button();
            txt_NumeroNivel = new TextBox();
            txt_Nivel = new TextBox();
            txt_MayRaiz = new TextBox();
            btn_Subarbol = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // lst_Orden
            // 
            lst_Orden.FormattingEnabled = true;
            lst_Orden.ItemHeight = 15;
            lst_Orden.Location = new Point(23, 120);
            lst_Orden.Name = "lst_Orden";
            lst_Orden.Size = new Size(166, 244);
            lst_Orden.TabIndex = 0;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(195, 67);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(100, 23);
            txt_Numero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 67);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 2;
            label1.Text = "Coloca aqui un numero:";
            // 
            // btn_Registrar
            // 
            btn_Registrar.Location = new Point(314, 67);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(75, 23);
            btn_Registrar.TabIndex = 3;
            btn_Registrar.Text = "Registrar";
            btn_Registrar.UseVisualStyleBackColor = true;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_preOrden
            // 
            btn_preOrden.Location = new Point(212, 123);
            btn_preOrden.Name = "btn_preOrden";
            btn_preOrden.Size = new Size(122, 23);
            btn_preOrden.TabIndex = 4;
            btn_preOrden.Text = "Mostrar preOrden";
            btn_preOrden.UseVisualStyleBackColor = true;
            btn_preOrden.Click += btn_preOrden_Click;
            // 
            // btn_inOrden
            // 
            btn_inOrden.Location = new Point(212, 168);
            btn_inOrden.Name = "btn_inOrden";
            btn_inOrden.Size = new Size(122, 23);
            btn_inOrden.TabIndex = 5;
            btn_inOrden.Text = "Mostrar inOrden";
            btn_inOrden.UseVisualStyleBackColor = true;
            btn_inOrden.Click += btn_inOrden_Click;
            // 
            // btn_postOrden
            // 
            btn_postOrden.Location = new Point(212, 208);
            btn_postOrden.Name = "btn_postOrden";
            btn_postOrden.Size = new Size(122, 23);
            btn_postOrden.TabIndex = 6;
            btn_postOrden.Text = "Mostrar postOrden";
            btn_postOrden.UseVisualStyleBackColor = true;
            btn_postOrden.Click += btn_postOrden_Click;
            // 
            // btn_Amplitud
            // 
            btn_Amplitud.Location = new Point(212, 251);
            btn_Amplitud.Name = "btn_Amplitud";
            btn_Amplitud.Size = new Size(122, 23);
            btn_Amplitud.TabIndex = 7;
            btn_Amplitud.Text = "Mostrar amplitud";
            btn_Amplitud.UseVisualStyleBackColor = true;
            btn_Amplitud.Click += btn_Amplitud_Click;
            // 
            // btn_Altura
            // 
            btn_Altura.Location = new Point(212, 293);
            btn_Altura.Name = "btn_Altura";
            btn_Altura.Size = new Size(122, 23);
            btn_Altura.TabIndex = 8;
            btn_Altura.Text = "Mostrar la altura";
            btn_Altura.UseVisualStyleBackColor = true;
            btn_Altura.Click += btn_Altura_Click;
            // 
            // btn_Nivel
            // 
            btn_Nivel.Location = new Point(651, 127);
            btn_Nivel.Name = "btn_Nivel";
            btn_Nivel.Size = new Size(75, 23);
            btn_Nivel.TabIndex = 9;
            btn_Nivel.Text = "Mostrar Nivel";
            btn_Nivel.UseVisualStyleBackColor = true;
            btn_Nivel.Click += btn_Nivel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 130);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 10;
            label2.Text = "Halle el nivel de:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 203);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 11;
            label3.Text = "Halle los numeros mayores a la raiz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 276);
            label4.Name = "label4";
            label4.Size = new Size(193, 15);
            label4.TabIndex = 12;
            label4.Text = "Halle los numeros menores a la raiz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 348);
            label5.Name = "label5";
            label5.Size = new Size(197, 15);
            label5.TabIndex = 13;
            label5.Text = "Mostrar el subarbol en base a la raiz:";
            // 
            // txt_Subarbol
            // 
            txt_Subarbol.Location = new Point(421, 344);
            txt_Subarbol.Name = "txt_Subarbol";
            txt_Subarbol.Size = new Size(100, 23);
            txt_Subarbol.TabIndex = 14;
            txt_Subarbol.TextChanged += textBox2_TextChanged;
            // 
            // txt_MenRaiz
            // 
            txt_MenRaiz.Location = new Point(373, 302);
            txt_MenRaiz.Name = "txt_MenRaiz";
            txt_MenRaiz.Size = new Size(353, 23);
            txt_MenRaiz.TabIndex = 15;
            // 
            // btn_MenRaiz
            // 
            btn_MenRaiz.Location = new Point(651, 272);
            btn_MenRaiz.Name = "btn_MenRaiz";
            btn_MenRaiz.Size = new Size(75, 23);
            btn_MenRaiz.TabIndex = 16;
            btn_MenRaiz.Text = "Mostrar";
            btn_MenRaiz.UseVisualStyleBackColor = true;
            btn_MenRaiz.Click += btn_MenRaiz_Click;
            // 
            // btn_MayRaiz
            // 
            btn_MayRaiz.Location = new Point(651, 203);
            btn_MayRaiz.Name = "btn_MayRaiz";
            btn_MayRaiz.Size = new Size(75, 23);
            btn_MayRaiz.TabIndex = 17;
            btn_MayRaiz.Text = "Mostrar";
            btn_MayRaiz.UseVisualStyleBackColor = true;
            btn_MayRaiz.Click += btn_MayRaiz_Click;
            // 
            // txt_NumeroNivel
            // 
            txt_NumeroNivel.Location = new Point(483, 127);
            txt_NumeroNivel.Name = "txt_NumeroNivel";
            txt_NumeroNivel.Size = new Size(153, 23);
            txt_NumeroNivel.TabIndex = 18;
            // 
            // txt_Nivel
            // 
            txt_Nivel.Location = new Point(373, 164);
            txt_Nivel.Name = "txt_Nivel";
            txt_Nivel.Size = new Size(353, 23);
            txt_Nivel.TabIndex = 19;
            // 
            // txt_MayRaiz
            // 
            txt_MayRaiz.Location = new Point(373, 237);
            txt_MayRaiz.Name = "txt_MayRaiz";
            txt_MayRaiz.Size = new Size(353, 23);
            txt_MayRaiz.TabIndex = 20;
            // 
            // btn_Subarbol
            // 
            btn_Subarbol.Location = new Point(551, 348);
            btn_Subarbol.Name = "btn_Subarbol";
            btn_Subarbol.Size = new Size(75, 23);
            btn_Subarbol.TabIndex = 21;
            btn_Subarbol.Text = "Mostrar";
            btn_Subarbol.UseVisualStyleBackColor = true;
            btn_Subarbol.Click += btn_Subarbol_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 29);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 22;
            label6.Text = "Arboles";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btn_Subarbol);
            Controls.Add(txt_MayRaiz);
            Controls.Add(txt_Nivel);
            Controls.Add(txt_NumeroNivel);
            Controls.Add(btn_MayRaiz);
            Controls.Add(btn_MenRaiz);
            Controls.Add(txt_MenRaiz);
            Controls.Add(txt_Subarbol);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Nivel);
            Controls.Add(btn_Altura);
            Controls.Add(btn_Amplitud);
            Controls.Add(btn_postOrden);
            Controls.Add(btn_inOrden);
            Controls.Add(btn_preOrden);
            Controls.Add(btn_Registrar);
            Controls.Add(label1);
            Controls.Add(txt_Numero);
            Controls.Add(lst_Orden);
            Name = "Form8";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_Orden;
        private TextBox txt_Numero;
        private Label label1;
        private Button btn_Registrar;
        private Button btn_preOrden;
        private Button btn_inOrden;
        private Button btn_postOrden;
        private Button btn_Amplitud;
        private Button btn_Altura;
        private Button btn_Nivel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Subarbol;
        private TextBox txt_MenRaiz;
        private Button btn_MenRaiz;
        private Button btn_MayRaiz;
        private TextBox txt_NumeroNivel;
        private TextBox txt_Nivel;
        private TextBox txt_MayRaiz;
        private Button btn_Subarbol;
        private Label label6;
    }
}