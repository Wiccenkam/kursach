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
    //Определение частичного класса loginForm
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label3repeatpass_Click(object sender, EventArgs e)
        {

        }
        //Метод ButtonLogin
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            bool flag = false;

            List<User> allUsers = User.GetUsersFromLocalFile();
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].login == login && allUsers[i].password == password)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                MessageBox.Show(" You was log in");
                journalForm form = new journalForm();
                this.Hide();
                form.ShowDialog();
                ClearInput();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong login or passwod");
            }
        }
        private void ClearInput()
        { 
        textBoxLogin.Text = "";
        textBoxPassword.Text = "";
       }
        private void button2_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
