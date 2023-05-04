using Newtonsoft.Json;
using SistemDeVanzariAuto;

namespace ProiectFinalForm
{
    partial class InterfataAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadJsonToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            label4 = new Label();
            button8 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Date Personale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(495, 17);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 1;
            label2.Text = "Lista Masini Disponibile";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(495, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 364);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(337, 18);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 4;
            button1.Text = "Adauga Masina Combustibil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(337, 122);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 5;
            button2.Text = "Sterge";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(337, 174);
            button3.Name = "button3";
            button3.Size = new Size(139, 40);
            button3.TabIndex = 6;
            button3.Text = "UpgradeMotor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(337, 226);
            button4.Name = "button4";
            button4.Size = new Size(139, 40);
            button4.TabIndex = 7;
            button4.Text = "UpgradeAutonomie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(337, 330);
            button5.Name = "button5";
            button5.Size = new Size(139, 40);
            button5.TabIndex = 8;
            button5.Text = "Detalii Masina";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(337, 278);
            button6.Name = "button6";
            button6.Size = new Size(139, 40);
            button6.TabIndex = 9;
            button6.Text = "ModificaPret";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(337, 70);
            button7.Name = "button7";
            button7.Size = new Size(139, 40);
            button7.TabIndex = 10;
            button7.Text = "Adauga Masina Electrica";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(685, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadJsonToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadJsonToolStripMenuItem
            // 
            loadJsonToolStripMenuItem.Name = "loadJsonToolStripMenuItem";
            loadJsonToolStripMenuItem.Size = new Size(123, 22);
            loadJsonToolStripMenuItem.Text = "LoadJson";
            loadJsonToolStripMenuItem.Click += loadJsonToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 426);
            label3.Name = "label3";
            label3.Size = new Size(594, 15);
            label3.TabIndex = 12;
            label3.Text = "Va rog sa incarcati fisierul json inainte de a incepe sa faceti mofdificarile! Toate modificarile se salveaza automat!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 13;
            // 
            // button8
            // 
            button8.Location = new Point(337, 376);
            button8.Name = "button8";
            button8.Size = new Size(139, 40);
            button8.TabIndex = 14;
            button8.Text = "BackLogin";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // InterfataAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InterfataAdmin";
            Text = "InterfataAdmin";
            FormClosing += InterfataAdmin_FormClosing;
            Load += InterfataAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadJsonToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        public Label label4;
        private Button button8;
    }
}