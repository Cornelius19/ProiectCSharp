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
    public partial class InterfataClient : Form
    {
        Client client;
        ListaMasini lista = new ListaMasini();
        ListaUser user = new ListaUser();
        public InterfataClient(Client c1)
        {
            InitializeComponent();
            client = c1;

        }

        private void InterfataClient_Load(object sender, EventArgs e)
        {
            label2.Text = client.ToString();
            ListaMasini l = new ListaMasini();
            l.ReadJson("lista.json");
            listBox1.DataSource = l;
            listBox1.DisplayMember = "marca";
            lista.ReadJson("masiniCumparate.json");
            listBox2.DataSource = lista;
            listBox2.DisplayMember = "marca";
            CenterToScreen();
            this.MaximizeBox = false;
        }

        //butonul buy
        private void button1_Click(object sender, EventArgs e)
        {
            ListaMasini l = new ListaMasini();
            l.ReadJson("lista.json");
            int index = listBox1.SelectedIndex;
            Masina masina = new Masina();
            if (index == -1)
            {
                MessageBox.Show("Selectati masina va rog!");
            }
            else
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (index == i)
                    {
                        if (client.balance >= l[i].pret)
                        {
                            masina = (Masina)l[i];
                            MessageBox.Show(client.CumparaMasina(masina));
                            user.ReadJson("user.json");
                            for (int j = 0; j < user.Count; j++)
                            {
                                if (user[j].GetType() == typeof(Client))
                                {
                                    user[j] = client;
                                    user.SaveJson("user.json");
                                    break;
                                }
                            }
                            label2.Text = client.ToString();
                            l.StergeMasina(masina);
                            l.SaveJson("lista.json");
                            listBox1.DataSource = null;
                            listBox1.DataSource = l;
                            listBox1.DisplayMember = "marca";
                            lista.Add(masina);
                            lista.SaveJson("masiniCumparate.json");
                        }
                        else
                        {
                            MessageBox.Show("Nu aveti suficienti bani!!!");
                        }

                    }
                }
                user.ReadJson("user.json");
                for (int i = 0; i < user.Count; i++)
                {
                    if (user[i].GetType() == typeof(Client))
                    {
                        client = (Client)user[i];
                    }
                }
                listBox2.DataSource = null;
                listBox2.DataSource = lista;
                listBox2.DisplayMember = "marca";
            }
        }

        private void InterfataClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare l = new Logare();
            l.Show();
        }

        //DetaliiMasina
        private void button2_Click(object sender, EventArgs e)
        {
            ListaMasini l = new ListaMasini();
            l.ReadJson("lista.json");
            int index = listBox1.SelectedIndex;
            for (int i = 0; i < l.Count; i++)
            {
                if (index == i)
                {
                    MessageBox.Show(l[i].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Introduceti suma de bani care doriti sa o adaugati:");
            try
            {
                uint bani = uint.Parse(userInput);
                client.AdaugaBani(bani);
                user.ReadJson("user.json");
                for (int i = 0; i < user.Count; i++)
                {
                    if (user[i].GetType() == typeof(Client))
                    {
                        user[i] = client;
                        MessageBox.Show("Adaugare a fost facuta cu succes!");
                    }
                }
                user.SaveJson("user.json");
                label2.Text = client.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Introduceti o valoare pozitiva!");
            }
        }
    }
}
