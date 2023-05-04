using Newtonsoft.Json;
using SistemDeVanzariAuto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalForm
{
    public partial class AdaugaMasinaCombustibil : Form
    {


        public AdaugaMasinaCombustibil()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {



                do
                {
                    InterfataAdmin a = new InterfataAdmin();
                    MasinaPeCombustibil masina = new MasinaPeCombustibil(
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    uint.Parse(textBox5.Text),
                    uint.Parse(textBox6.Text),
                    uint.Parse(textBox7.Text),
                    uint.Parse(textBox8.Text),
                    uint.Parse(textBox9.Text));
                    ListaMasini lista = new ListaMasini();
                    lista.ReadJson("lista.json");
                    lista.Add((MasinaPeCombustibil)masina);
                    a.listBox1.DataSource = null;
                    a.listBox1.DataSource = lista;
                    a.listBox1.DisplayMember = "marca" + " model";


                    lista.SaveJson("lista.json");
                    this.Close();
                    a.Show();
                } while (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "");


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
                textBox9.Text = string.Empty;

                MessageBox.Show("A aparut o eroare, posibil ati lasat un camp gol sau nu ati introdus o valoare numerica in cumpurile 5,6,7,8,9 sau era negativa :D");
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void AdaugaMasinaCombustibil_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.MaximizeBox = false;
        }

        private void AdaugaMasinaCombustibil_FormClosing(object sender, FormClosingEventArgs e)
        {

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
    }
}
