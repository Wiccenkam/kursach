using kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string password2 = textBoxPassword2.Text;

            List<User> allUsers = User.GetUsersFromLocalFile();
            bool flag = false;
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].login == login)
                {
                    MessageBox.Show("Users with this login alredy exists");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    textBoxPassword2.Text = "";
                    return;
                }
            }


            if (password == password2)
            {
                User user = new User();
                user.login = login;
                user.password = password;
                User.SaveToLocalFile(user);
                MessageBox.Show("You was register");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password dont match");
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxPassword2.Text = "";
            }

        }
    }
}
