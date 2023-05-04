namespace ProiectFinalForm
{
    partial class InterfataClient
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Date Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(322, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 379);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.White;
            listBox2.ForeColor = Color.Black;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 254);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(183, 184);
            listBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(349, 23);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 4;
            label3.Text = "Masini Diponibile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 230);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 5;
            label4.Text = "Masini Cumparate";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(213, 254);
            button1.Name = "button1";
            button1.Size = new Size(87, 38);
            button1.TabIndex = 6;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(213, 298);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 7;
            button2.Text = "Detalii";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(213, 354);
            button3.Name = "button3";
            button3.Size = new Size(87, 38);
            button3.TabIndex = 8;
            button3.Text = "AddMoney";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(213, 398);
            button4.Name = "button4";
            button4.Size = new Size(87, 40);
            button4.TabIndex = 9;
            button4.Text = "BackLogin";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // InterfataClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InterfataClient";
            Text = "InterfataClient";
            FormClosing += InterfataClient_FormClosing;
            Load += InterfataClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        public Label label3;
        public Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}