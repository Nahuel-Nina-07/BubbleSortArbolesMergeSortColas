namespace ProyectoAnalisis
{
    partial class Form7
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtEstado = new TextBox();
            txtSexo = new ComboBox();
            datos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)datos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 122);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(361, 15);
            label2.TabIndex = 2;
            label2.Text = "A continuacion coloque los siguientes datos, para encolar personas";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(211, 122);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(110, 23);
            txtEstado.TabIndex = 3;
            // 
            // txtSexo
            // 
            txtSexo.FormattingEnabled = true;
            txtSexo.Items.AddRange(new object[] { "Hombre", "Mujer " });
            txtSexo.Location = new Point(376, 122);
            txtSexo.Margin = new Padding(3, 2, 3, 2);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(133, 23);
            txtSexo.TabIndex = 4;
            // 
            // datos
            // 
            datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Estado, Sexo });
            datos.Location = new Point(46, 170);
            datos.Margin = new Padding(3, 2, 3, 2);
            datos.Name = "datos";
            datos.RowHeadersWidth = 51;
            datos.RowTemplate.Height = 29;
            datos.Size = new Size(429, 141);
            datos.TabIndex = 5;
            datos.CellClick += datos_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(564, 122);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(564, 289);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 22);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(700, 338);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(datos);
            Controls.Add(txtSexo);
            Controls.Add(txtEstado);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form7";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEstado;
        private ComboBox txtSexo;
        private DataGridView datos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Sexo;
        private Button btnAgregar;
        private Button btnBorrar;
    }
}