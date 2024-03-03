namespace ProyectoAnalisis
{
    partial class Form6
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
            TB_nombre = new TextBox();
            TB_edad = new TextBox();
            TB_celular = new TextBox();
            Btn_registrar = new Button();
            Btn_mostrar = new Button();
            Btn_quitar = new Button();
            LB_listaPilas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(242, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 0;
            label1.Text = "Pilas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 15);
            label2.TabIndex = 1;
            label2.Text = "A continuacion coloque los siguientes datos, para apilar estudiantes";
            // 
            // TB_nombre
            // 
            TB_nombre.Location = new Point(28, 110);
            TB_nombre.Margin = new Padding(2);
            TB_nombre.Name = "TB_nombre";
            TB_nombre.Size = new Size(114, 23);
            TB_nombre.TabIndex = 2;
            TB_nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_edad
            // 
            TB_edad.Location = new Point(219, 110);
            TB_edad.Margin = new Padding(2);
            TB_edad.Name = "TB_edad";
            TB_edad.Size = new Size(104, 23);
            TB_edad.TabIndex = 3;
            // 
            // TB_celular
            // 
            TB_celular.Location = new Point(386, 110);
            TB_celular.Margin = new Padding(2);
            TB_celular.Name = "TB_celular";
            TB_celular.Size = new Size(104, 23);
            TB_celular.TabIndex = 4;
            // 
            // Btn_registrar
            // 
            Btn_registrar.Location = new Point(548, 107);
            Btn_registrar.Margin = new Padding(2);
            Btn_registrar.Name = "Btn_registrar";
            Btn_registrar.Size = new Size(76, 26);
            Btn_registrar.TabIndex = 5;
            Btn_registrar.Text = "Registrar";
            Btn_registrar.UseVisualStyleBackColor = true;
            Btn_registrar.Click += Btn_registrar_Click;
            // 
            // Btn_mostrar
            // 
            Btn_mostrar.Location = new Point(548, 153);
            Btn_mostrar.Margin = new Padding(2);
            Btn_mostrar.Name = "Btn_mostrar";
            Btn_mostrar.Size = new Size(76, 27);
            Btn_mostrar.TabIndex = 6;
            Btn_mostrar.Text = "Mostrar";
            Btn_mostrar.UseVisualStyleBackColor = true;
            Btn_mostrar.Click += Btn_mostrar_Click;
            // 
            // Btn_quitar
            // 
            Btn_quitar.Location = new Point(548, 294);
            Btn_quitar.Margin = new Padding(2);
            Btn_quitar.Name = "Btn_quitar";
            Btn_quitar.Size = new Size(76, 26);
            Btn_quitar.TabIndex = 7;
            Btn_quitar.Text = "Quitar";
            Btn_quitar.UseVisualStyleBackColor = true;
            Btn_quitar.Click += Btn_quitar_Click;
            // 
            // LB_listaPilas
            // 
            LB_listaPilas.FormattingEnabled = true;
            LB_listaPilas.ItemHeight = 15;
            LB_listaPilas.Location = new Point(28, 153);
            LB_listaPilas.Margin = new Padding(2);
            LB_listaPilas.Name = "LB_listaPilas";
            LB_listaPilas.Size = new Size(462, 169);
            LB_listaPilas.TabIndex = 8;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(683, 338);
            Controls.Add(LB_listaPilas);
            Controls.Add(Btn_quitar);
            Controls.Add(Btn_mostrar);
            Controls.Add(Btn_registrar);
            Controls.Add(TB_celular);
            Controls.Add(TB_edad);
            Controls.Add(TB_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form6";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TB_nombre;
        private TextBox TB_edad;
        private TextBox TB_celular;
        private Button Btn_registrar;
        private Button Btn_mostrar;
        private Button Btn_quitar;
        private ListBox LB_listaPilas;
    }
}