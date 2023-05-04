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

namespace ProiectFinalForm
{
    public partial class CreareCont : Form
    {
        public CreareCont()
        {
            InitializeComponent();
        }
        ListaUser l = new ListaUser();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare l = new Logare();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.ReadJson("user.json");
            Client c = new Client();
            try
            {
                string status = "Client";
                string nume = textBox1.Text +" "+ textBox2.Text;
                int numarTelefon = 0;
                bool nrTelefon = false;
                uint varsta = uint.Parse(textBox3.Text);
                if (textBox4.Text.Length == 10)
                {
                    numarTelefon = int.Parse(textBox4.Text);
                    nrTelefon = true;
                }
                else
                {
                    MessageBox.Show("Numar de telefon invalid!");
                    textBox4.Clear();
                }
                    
                uint balance = 0;
                string username = textBox5.Text;
                string password = textBox6.Text;
                if (nrTelefon)
                {
                    c = new Client(status, nume, varsta, numarTelefon, balance, username, password);
                    l.Add(c);
                }
               
                
                l.SaveJson("user.json");


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
