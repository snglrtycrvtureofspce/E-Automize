using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using EAutomize.Form;

namespace EAutomize
{
    public partial class SIGNin : System.Windows.Forms.Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public SIGNin()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void TextBoxUser_Enter(object sender, EventArgs e)
        {
            if(TextBoxUser.Text == "Имя пользователя")
            {
                TextBoxUser.Text = "";
                TextBoxUser.ForeColor = Color.Black;
            }
        }

        private void TextBoxUser_Leave(object sender, EventArgs e)
        {
            if(TextBoxUser.Text == "")
            {
                TextBoxUser.Text = "Имя пользователя";
                TextBoxUser.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if(TextBoxPassword.Text == "Пароль")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if(TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Пароль";
                TextBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxUser.Text != "Имя пользователя" && TextBoxPassword.Text != "Пароль")
                {
                    string query = "SELECT * FROM people WHERE username ='" + TextBoxUser.Text + "' AND password='" + TextBoxPassword.Text + "'";
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", TextBoxUser.Text);
                    cmd.Parameters.AddWithValue("@pass", TextBoxPassword.Text);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count != 1)
                    {
                        ErrorPanel.Visible = true;
                        Messenge.ForeColor = Color.Red;
                        Messenge.Text = "Пользователь не найден!";
                    }
                    else
                    {
                        if (TextBoxUser.Text == "admin") { Home.Instance.pnlAdmin.Visible = true; }
                        Home.Instance.PnlLableUser.Text = TextBoxUser.Text;
                        Home.Instance.PnlLableUser.Visible = true;
                        Home.Instance.pnlBasket.Visible = true;
                        Home.Instance.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (TextBoxPassword.Text == "Пароль")
                        TextBoxPassword.BorderColor = Color.Red;
                    if (TextBoxUser.Text == "Имя пользователя")
                        TextBoxUser.BorderColor = Color.Red;
                    ErrorPanel.Visible = true;
                    Messenge.ForeColor = Color.Red;
                    Messenge.Text = "Есть пустые поля!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNup sIGNup = new SIGNup();
            sIGNup.Show();
        }
    }
}
