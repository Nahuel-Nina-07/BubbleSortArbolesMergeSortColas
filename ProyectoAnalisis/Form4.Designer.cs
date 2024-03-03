namespace ProyectoAnalisis
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            label1=new Label();
            label2=new Label();
            textBox1=new TextBox();
            button1=new Button();
            listBox1=new ListBox();
            label3=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(320, 36);
            label1.Name="label1";
            label1.Size=new Size(99, 15);
            label1.TabIndex=0;
            label1.Text="Ejercicios C# No4";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(320, 68);
            label2.Name="label2";
            label2.Size=new Size(98, 15);
            label2.TabIndex=1;
            label2.Text="Escriba una frase:";
            label2.Click+=label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(277, 94);
            textBox1.Margin=new Padding(3, 2, 3, 2);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(266, 23);
            textBox1.TabIndex=2;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location=new Point(277, 130);
            button1.Margin=new Padding(3, 2, 3, 2);
            button1.Name="button1";
            button1.Size=new Size(266, 22);
            button1.TabIndex=3;
            button1.Text="START";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(277, 196);
            listBox1.Margin=new Padding(3, 2, 3, 2);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(266, 34);
            listBox1.TabIndex=4;
            listBox1.SelectedIndexChanged+=listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(277, 166);
            label3.Name="label3";
            label3.Size=new Size(38, 15);
            label3.TabIndex=5;
            label3.Text="label3";
            label3.Click+=label3_Click;
            // 
            // timer1
            // 
            timer1.Enabled=true;
            timer1.Tick+=timer1_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(134, 150, 254);
            ClientSize=new Size(787, 338);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin=new Padding(3, 2, 3, 2);
            Name="Form4";
            Text="Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}