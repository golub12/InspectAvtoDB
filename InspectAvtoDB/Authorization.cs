using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectAvtoDB
{
    public partial class Authorization : Form
    {
        Model1 db = new Model1();
        public UserLogin USER { get; set; }
        public Authorization FORMA { get; set; }

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text =="")
            {
                MessageBox.Show("Fields not filled in!", "Error");
                return;
            }
            UserLogin usr = db.UserLogin.Find(textBox1.Text);
            if ((usr != null) && (usr.Password == textBox2.Text))
            {
                USER = usr;
                FORMA = this;

                if (usr.Role == "Inspector")
                {
                    MainMenu frm = new MainMenu();
                    this.Hide();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("You don't have the rights of an inspector!", "Error");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Incorrect data!", "Error");
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
