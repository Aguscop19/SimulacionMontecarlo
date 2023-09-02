namespace SimulacionMontecarlo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 0;
            label1.Text = "Montecarlo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 43);
            label2.Name = "label2";
            label2.Size = new Size(357, 41);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de simulaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(862, 539);
            label3.Name = "label3";
            label3.Size = new Size(217, 41);
            label3.TabIndex = 2;
            label3.Text = "Promedio Final";
            // 
            // button1
            // 
            button1.Location = new Point(1078, 60);
            button1.Name = "button1";
            button1.Size = new Size(299, 121);
            button1.TabIndex = 3;
            button1.Text = "Simulacion:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(797, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1241, 533);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(567, 375);
            dataGridView1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1266, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(862, 271);
            label4.Name = "label4";
            label4.Size = new Size(216, 41);
            label4.TabIndex = 7;
            label4.Text = "Limiete inferior";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1266, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 47);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(862, 355);
            label5.Name = "label5";
            label5.Size = new Size(215, 41);
            label5.TabIndex = 9;
            label5.Text = "Limite superior";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1266, 427);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 47);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(862, 427);
            label6.Name = "label6";
            label6.Size = new Size(279, 41);
            label6.TabIndex = 11;
            label6.Text = "Numero de paneles";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1239, 616);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(250, 47);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(860, 622);
            label7.Name = "label7";
            label7.Size = new Size(282, 41);
            label7.TabIndex = 13;
            label7.Text = "Desviacion estandar";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1433, 60);
            button2.Name = "button2";
            button2.Size = new Size(299, 121);
            button2.TabIndex = 15;
            button2.Text = "Descargar Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 708);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Button button2;
    }
}