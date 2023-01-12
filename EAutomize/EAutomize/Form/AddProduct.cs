using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EAutomize.Form
{
    public partial class AddProduct : System.Windows.Forms.Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) // кнопка закрыть
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    PictureBox.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO product (name, category, brand, age, photo, price, description) VALUES ('" + TextBoxName.Text + "', '" + BoxCategory.Text + "', '" + TextBoxBrand.Text + "', '" + TextBoxAge.Text + "', @photo, '" + TextBoxPrice.Text + "', '" + TextBoxDescription.Text + "')", con);
                cmd.Parameters.AddWithValue("@photo", Photo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
