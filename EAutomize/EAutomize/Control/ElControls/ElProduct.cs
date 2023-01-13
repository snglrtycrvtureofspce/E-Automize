using System;
using System.Data.SQLite;
using System.Windows.Forms;
using EAutomize.Form;

namespace EAutomize.Control.ElControls
{
    public partial class ElProduct : UserControl
    {
        public SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public ElProduct()
        {
            InitializeComponent();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [product] WHERE name='" + this.NameProduct.Text + "'", con);
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();

                InfoProductControl infoproductControl = new InfoProductControl();
                if (Home.Instance.PnlLableUser.Visible == true) { infoproductControl.gunaAdvenceButton1.Visible = true; }
                Home.Instance.PnlContainer.Controls.Add(infoproductControl);
                if (Home.Instance.PnlLableUser.Visible == true) { infoproductControl.gunaAdvenceButton1.Visible = true; }
                infoproductControl.gunaPictureBox1.Image = this.gunaPictureBox1.Image;

                while (reader.Read())
                {
                    //информация
                    infoproductControl.gunaLabel1.Text = reader[1].ToString(); // название товара
                    infoproductControl.gunaLabel2.Text = reader[2].ToString(); // категория
                    infoproductControl.gunaLabel3.Text = reader[3].ToString(); // бренд
                    infoproductControl.gunaLabel5.Text = reader[0].ToString(); // №
                    infoproductControl.gunaLabel6.Text = reader[4].ToString(); // дата выхода
                    infoproductControl.gunaLabel7.Text = reader[7].ToString(); // описание товара
                    infoproductControl.gunaLabel12.Text = reader[5] + " руб."; // цена
                }
                
                infoproductControl.Dock = DockStyle.Fill;
                Home.Instance.PnlContainer.Controls["InfoProductControl"].BringToFront();
                reader.Close();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }
    }
}
