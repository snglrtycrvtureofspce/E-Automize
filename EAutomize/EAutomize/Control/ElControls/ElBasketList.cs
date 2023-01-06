using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EAutomize.Control.ElControls
{
    public partial class ElBasketList : UserControl
    {
        public SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public ElBasketList()
        {
            InitializeComponent();
        }

        private void btnDeleteSoonFilm_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM basket WHERE name='" + gunaLabel1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
