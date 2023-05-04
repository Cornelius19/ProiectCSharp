
using SistemDeVanzariAuto;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace ProiectFinalForm
{
    public partial class Logare : Form
    {
        ListaUser list = new ListaUser()
        {
            new Admin("admin",
                "Strada A nr 5",
                "Museteanu Corneliu",
                23,
                0785551559,
                "admin",
                "passpass"),
            new Client("client",
                "Sorina Damaschin",
                22,
                0795556221,
                50000,
                "client",
                "passpass")
        };


        public Logare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.MaximizeBox = false;
            textBox1.Focus();

        }

        // butonul ok
        private void button1_Click(object sender, EventArgs e)
        {
            ListaUser l = new ListaUser();
            l.ReadJson("user.json");
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].username == textBox1.Text && l[i].GetType() == typeof(Admin))
                {
                    if (l[i].password == textBox2.Text && l[i].GetType() == typeof(Admin))
                    {
                        this.Hide();
                        InterfataAdmin interfataAdmin = new InterfataAdmin();
                        interfataAdmin.Show();
                        //interfataAdmin.label4.Text = l[i].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Ati introdus ceva gresit! :D");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        break;
                    }
                    break;
                }
                else if (l[i].username == textBox1.Text && l[i].GetType() == typeof(Client))
                {
                    if (l[i].password == textBox2.Text && l[i].GetType() == typeof(Client))
                    {
                        this.Hide();
                        User m = new User();
                        m = (Client)l[i];
                        InterfataClient interfataClient = new InterfataClient((Client)m);
                        interfataClient.Show();
                        //interfataClient.label2.Text = m.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ati introdus ceva gresit! D:");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        break;
                    }
                }
                else if (l[i].username != textBox1.Text && i == l.Count - 1)
                {
                    MessageBox.Show("Ati introdus ceva gresit:DDD");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }



            }

        }



        private void Logare_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreareCont c = new CreareCont();
            c.Show();
        }
    }
}