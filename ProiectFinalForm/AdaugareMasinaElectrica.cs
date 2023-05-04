using Newtonsoft.Json;
using SistemDeVanzariAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectFinalForm
{
    public partial class AdaugareMasinaElectrica : Form
    {
        public AdaugareMasinaElectrica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    InterfataAdmin a = new InterfataAdmin();
                    MasinaElectrica masina = new MasinaElectrica(
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        textBox4.Text,
                        uint.Parse(textBox5.Text),
                        uint.Parse(textBox6.Text),
                        uint.Parse(textBox7.Text),
                        uint.Parse(textBox8.Text));
                    ListaMasini lista = new ListaMasini();
                    lista.ReadJson("lista.json");
                    lista.Add((MasinaElectrica)masina);
                    a.listBox1.DataSource = null;
                    a.listBox1.DataSource = lista;
                    a.listBox1.DisplayMember = "marca";
                    lista.SaveJson("lista.json");
                    a.Show();
                    this.Close();
                } while (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "");
            }
            catch (Exception)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;


                MessageBox.Show("A aparut o eroare, posibil ati lasat un camp gol sau nu ati introdus o valoare numerica in cumpurile 5,6,7,8 sau era negativa :D");
            }

        }

        private void AdaugareMasinaElectrica_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdaugareMasinaElectrica_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            InterfataAdmin a = new InterfataAdmin();
            ListaMasini l = new ListaMasini();
            l.ReadJson("lista.json");
            a.listBox1.DataSource = l;
            a.listBox1.DisplayMember = "marca";
            a.Show();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

