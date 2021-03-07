using kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            /*List<User> allUsers = User.GetUsersFromLocalFile();
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].login == login && allUsers[i].password == password)
                {
                    flag = true;
                    break;
                }
            }*/
            DataBaseModel database = new DataBaseModel();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @Login AND Password= @Pass", database.getConnection());
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User allready exist");
                flag = true;
            }
            else
            {
                MessageBox.Show("User not exist");
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
