using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EAutomize.Control.ElControls
{
    public partial class ElOrderList : UserControl
    {
        public SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");

        public ElOrderList()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (this.Height == 36) { this.Height += 46; }
            else { this.Height = 36; }

            SQLiteCommand cmd = new SQLiteCommand($"SELECT name, photo, price FROM [product] where key = {rand.Next(1,7)}", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElBasketList Item = new ElBasketList();
                Item.btnDeleteSoonFilm.Visible = false;
                Item.Size = new Size(706, 46);
                Item.Dock = DockStyle.Top;
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.gunaLabel2.Text = reader[5] + " руб.";

                byte[] Photo = (byte[])(reader[6]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaCirclePictureBox1.Image = Image.FromStream(memoryStream);

                flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            con.Close();
        }
    }
}
