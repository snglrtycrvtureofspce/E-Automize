using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace E_Automize
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string usernames;
        private Authentication auth;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty)
            {
                checkAccount(txtUsername.Text, txtPassword.Text);
            }
        }

        private void checkAccount(string username, string password)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString, true))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"SELECT * FROM users WHERE Username='" + username + "' and Password='" + password + "'";

                    int count = 0;
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Успешный вход!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernames = username;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Имя пользователя или пароль неверны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
