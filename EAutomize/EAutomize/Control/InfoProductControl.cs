using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EAutomize.Control
{
    public partial class InfoProductControl : UserControl
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public InfoProductControl()
        {
            InitializeComponent();
        }


        bool changet3 = false;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (changet3)
            {
                gunaAdvenceButton1.ForeColor = Color.Black;
                gunaAdvenceButton1.BackColor = SystemColors.Control;
                gunaAdvenceButton1.Text = "Добавить в корзину";
                gunaAdvenceButton1.ImageOffsetX = 0;
                DeleteBasketBook();
            }
            else
            {
                gunaAdvenceButton1.ForeColor = Color.White;
                gunaAdvenceButton1.BackColor = Color.Black;
                gunaAdvenceButton1.Text = "Книга в корзине";
                gunaAdvenceButton1.ImageOffsetX = 10;
                AddBasketProduct();
            }
            changet3 = !changet3;
        }
        
        private void AddBasketProduct()
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                gunaPictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);


                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO basket (name, photo, price) VALUES ('" + gunaLabel1.Text + "', @photo, '" + gunaLabel12.Text + "')", con);
                cmd.Parameters.AddWithValue("@photo", Photo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void DeleteBasketBook()
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
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        
    }
}
