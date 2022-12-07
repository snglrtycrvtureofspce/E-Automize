using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim() == "" && pass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "SELECT * FROM people WHERE username= @user AND password = @pass";
                SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", user.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You are Logged in", "Login Succesfull");
                }
                else
                {
                    MessageBox.Show("Login Failed", "Error");
                }
            }
        }
    }
}
