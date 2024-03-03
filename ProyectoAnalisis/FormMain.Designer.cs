namespace ProyectoAnalisis
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 89);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 158);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 134);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 194);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(307, 220);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 22);
            button1.TabIndex = 6;
            button1.Text = "INICIAR SESIÓN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 150, 254);
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}