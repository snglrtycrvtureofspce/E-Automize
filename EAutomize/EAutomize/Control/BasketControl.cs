using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EAutomize.Control
{
    public partial class BasketControl : UserControl
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public BasketControl()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO [order] (name, phone, address) VALUES ('{gunaTextBox1.Text}', '{gunaTextBox2.Text}', '{gunaTextBox3.Text}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Заказ успешно оформлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
