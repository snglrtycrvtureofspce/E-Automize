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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private Authentication auth;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty
                && txtConfirmPassword.Text != string.Empty
                && txtEmail.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    checkAccount(txtUsername.Text);
                }
                else
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkAccount(string username)
        {
            auth = new Authentication();

            auth.createDatabase();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString, true))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();

                    int count = 0;
                    string query = @"SELECT * FROM users WHERE Username='" + username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Ошибка создания базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (count == 0)
                    {
                        insertData(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void insertData(string usernames, string password, string email)
        {
            auth = new Authentication();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString, true))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"INSERT INTO users(Username, Password, Email) VALUES(@username, @password, @email)";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@username", usernames));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("База данных создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
