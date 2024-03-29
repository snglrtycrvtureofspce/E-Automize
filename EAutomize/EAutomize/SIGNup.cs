﻿using System;
using System.Data.SQLite;
using System.Drawing;
using EAutomize.Form;

namespace EAutomize
{
    public partial class SIGNup : System.Windows.Forms.Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public SIGNup()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Имя")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                TextBoxName.Text = "Имя";
                TextBoxName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSurname_Enter(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "Фамилия")
            {
                TextBoxSurname.Text = "";
                TextBoxSurname.ForeColor = Color.Black;
            }
        }

        private void TextBoxSurname_Leave(object sender, EventArgs e)
        {
            if (TextBoxSurname.Text == "")
            {
                TextBoxSurname.Text = "Фамилия";
                TextBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "Имя пользователя")
            {
                TextBoxUsername.Text = "";
                TextBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                TextBoxUsername.Text = "Имя пользователя";
                TextBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Пароль")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Пароль";
                TextBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text != "Имя" && TextBoxSurname.Text != "Фамилия" && TextBoxUsername.Text != "Имя пользователя" && TextBoxPassword.Text != "Пароль")
                {
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO people (username, password, name, surname) VALUES ('" + TextBoxUsername.Text + "', '" + TextBoxPassword.Text + "', '" + TextBoxUsername.Text + "', '" + TextBoxSurname.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();   

                    this.Hide();
                    SIGNin sIGNin = new SIGNin();
                    sIGNin.Show();
                }
                else
                {
                    if (TextBoxName.Text == "Имя")
                        TextBoxName.BorderColor = Color.Red;
                    if (TextBoxSurname.Text == "Фамилия")
                        TextBoxSurname.BorderColor = Color.Red;
                    if (TextBoxPassword.Text == "Пароль")
                        TextBoxPassword.BorderColor = Color.Red;
                    if (TextBoxUsername.Text == "Имя пользователя")
                        TextBoxUsername.BorderColor = Color.Red;
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Есть пустые поля";
                }
            }
            catch
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пользователь уже зарегестрирован!";
                con.Close();
            }
        }

        private void LabelSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }
    }
}
