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
            if (textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Enter your password");
                return;
            }
            if (textBoxLogin.Text == string.Empty)
            {
                MessageBox.Show("Enter your login");
                return;
            }
            
            List<User> allUsers = User.GetUsersFromLocalFile();
            bool flag = false;
            if (IsUserExist())
                return;
            /*for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].login == login)
                {
                    MessageBox.Show("Users with this login alredy exists");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    textBoxPassword2.Text = "";
                    return;
                }
            }*/

            DataBaseModel dB = new DataBaseModel();
            SqlCommand command = new SqlCommand("INSERT INTO users ( Login, Password) VALUES (@login, @password)", dB.getConnection());
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBoxPassword.Text;



            dB.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was create");
            }
            else
            {
                MessageBox.Show("Some issue");
            }

            dB.CloseConnection();
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
        public Boolean IsUserExist()
        {
            DataBaseModel database = new DataBaseModel();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Login = @Login", database.getConnection());
            command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBoxLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Same login already exist");
                return true;
            }
            else
            {
                MessageBox.Show("User not exist");
                return false;
            }
        }
    }
}
