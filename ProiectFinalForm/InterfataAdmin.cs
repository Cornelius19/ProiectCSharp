using Newtonsoft.Json;
using SistemDeVanzariAuto;
using System;
using System.CodeDom;
using System.Collections;
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
    public partial class InterfataAdmin : Form
    {
        //ListaMasini masina = new ListaMasini()
        //{
        //    new MasinaElectrica("1",
        //        "2",
        //        "3",
        //        "4",
        //        151,
        //        16,
        //        1,
        //        1)
        //};
        User client = new User();
        ListaUser users = new ListaUser();
        public InterfataAdmin()
        {

            InitializeComponent();

        }

        private void InterfataAdmin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.MaximizeBox = false;
            label4.Text = client.ToString();
            users.ReadJson("user.json");
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetType() == typeof(Admin))
                {
                    label4.Text = users[i].ToString();
                }
            }
        }

        //LoadJson Menu
        private void loadJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                List<object> lista = JsonConvert.DeserializeObject<List<object>>(json);
                foreach (object item in lista)
                {
                    listBox1.Items.Add(item);

                    listBox1.DisplayMember = "marca";
                }
            }
        }

        //Detalii la masina selectata
        private void button5_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex != -1)
            //{
            //    MessageBox.Show(listBox1.SelectedItem.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Selectati masina pentru a vedea detaliile!");
            //}

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

        //butonul de adaugare masina pe combustibil
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Incarcati fisierul json va rog!");
            }
            else
            {
                this.Hide();
                AdaugaMasinaCombustibil a = new AdaugaMasinaCombustibil();
                a.Show();
            }

        }

        //Butonul modifica pret
        private void button6_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Alegeti masina din lista va rog!");
            }
            else
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Introduceti noul pret al masinii:");
                uint pretNou;
                try
                {
                    pretNou = uint.Parse(userInput);
                    ListaMasini l = new ListaMasini();
                    l.ReadJson("lista.json");
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (index == i)
                        {
                            MessageBox.Show(l[i].ModificaPret(pretNou));
                            l.SaveJson("lista.json");
                            listBox1.DataSource = null;
                            listBox1.DataSource = l;
                            listBox1.DisplayMember = "marca";
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Introduceti o valoare pozitiva!");
                }
            }
        }

        //Butonul de stergere element
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti masina?", "Confirmare stergere", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ListaMasini l = new ListaMasini();
                    l.ReadJson("lista.json");


                    int index = listBox1.SelectedIndex;
                    Masina masinaDeSters = null;
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (index == i)
                        {
                            masinaDeSters = l[i];
                            break;
                        }
                    }

                    if (masinaDeSters != null)
                    {
                        //l.Remove(masinaDeSters);
                        l.StergeMasina(masinaDeSters);

                        l.SaveJson("lista.json");
                        listBox1.DataSource = null;
                        listBox1.DataSource = l;
                        listBox1.DisplayMember = "marca";
                    }

                }
            }

        }

        //butonul de adaugare masina electrica
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Incarcati fiserul json va rog!");
            }
            else
            {
                this.Hide();
                AdaugareMasinaElectrica a = new AdaugareMasinaElectrica();
                a.Show();
            }

        }

        //Butonul de modificare a capacitatii motorului
        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selectati masina va rog!");
            }
            else
            {
                try
                {

                    string userInput = Microsoft.VisualBasic.Interaction.InputBox("Introduceti noua capacitate a motorului!");
                    uint capacitateNoua;
                    capacitateNoua = uint.Parse(userInput);

                    ListaMasini l = new ListaMasini();
                    l.ReadJson("lista.json");
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (index == i)
                        {

                            if (l[i].GetType() == typeof(MasinaPeCombustibil))
                            {
                                MasinaPeCombustibil m = new MasinaPeCombustibil((MasinaPeCombustibil)l[i]);
                                MessageBox.Show(m.UpgradeMotor(capacitateNoua));
                                l[i] = m;
                                l.SaveJson("lista.json");
                                listBox1.DataSource = null;
                                listBox1.DataSource = l;
                                listBox1.DisplayMember = "marca";
                            }
                            else
                            {
                                MessageBox.Show("Masina selectata nu este pe combustibil!");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Introduceti o valoare pozitiva!");
                }
            }

        }

        //butonul de upgrade autonomie
        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Alegeti masina va rog!");
            }
            else
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Introduceti noua valoare de autonomie!");
                uint capacitateNoua;
                try
                {
                    capacitateNoua = uint.Parse(userInput);
                    ListaMasini list = new ListaMasini();
                    list.ReadJson("lista.json");
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (index == i)
                        {
                            if (list[i].GetType() == typeof(MasinaElectrica))
                            {
                                MasinaElectrica m = new MasinaElectrica((MasinaElectrica)list[i]);
                                MessageBox.Show(m.ModificaAutonomie(capacitateNoua));
                                list[i] = m;
                                list.SaveJson("lista.json");
                                listBox1.DataSource = null;
                                listBox1.DataSource = list;
                                listBox1.DisplayMember = "marca";
                            }
                            else
                            {
                                MessageBox.Show("Masina selectata nu este electrica!");
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Introduceti o valoare pozitiva!");
                }
            }


        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InterfataAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare logare = new Logare();
            logare.Show();
        }
    }
}
