using System;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EAutomize.Control;
using EAutomize.Control.ElControls;

namespace EAutomize.Form
{
    public partial class Home : System.Windows.Forms.Form
    {
        public SQLiteConnection con = new SQLiteConnection("Data Source=users.db;Version=3;");
        public Home()
        {
            InitializeComponent();
            _obj = this;
            this.ActiveControl = logo;
        }

        static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return InfoPanel; }
            set { InfoPanel = value; }
        }

        public Guna.UI.WinForms.GunaPanel pnlAdmin
        {
            get { return AdminPanel; }
            set { AdminPanel = value; }
        }

        public Guna.UI.WinForms.GunaLabel PnlLableUser
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public Guna.UI.WinForms.GunaPanel pnlBasket
        {
            get { return gunaPanel1; }
            set { gunaPanel1 = value; }
        }

        Point lastPoint;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = logo;
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //-------------------------------- Admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
           // SearchPanel.Location = new Point(26, 11);
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            AdminControl adminControl1 = new AdminControl();
            InfoPanel.Controls.Add(adminControl1);
            adminControl1.Dock = DockStyle.Fill;
            adminControl1.BringToFront();

            PrintListUserAdmin(adminControl1);
            PrintListProductAdmin(adminControl1);
            PrintStatisticAdmin(adminControl1);
        }

        private void PrintStatisticAdmin(AdminControl adminControl1)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM product", con);
            con.Open();
            adminControl1.CountProducts.Text = "0" + cmd.ExecuteScalar().ToString();
            con.Close();

            cmd = new SQLiteCommand("SELECT COUNT(*) FROM people", con);
            con.Open();
            adminControl1.CountUsers.Text = "0" + cmd.ExecuteScalar().ToString();
            con.Close();

            Random random = new Random();
            adminControl1.CountBuyProducts.Text = "0" + random.Next(0,30);
        }

        private void PrintListProductAdmin(AdminControl adminControl1)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [product]", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            adminControl1.flowLayoutPanel1.Controls.Clear();
            Random random = new Random();

            while (reader.Read())
            {
                ElProductList Item = new ElProductList();

                byte[] Photo = (byte[])(reader[6]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaCirclePictureBox1.Image = Image.FromStream(memoryStream);

                Item.gunaLabel1.Text = reader[1].ToString();
                Item.gunaLabel3.Text = reader[2].ToString();
                Item.gunaLabel4.Text += reader[0].ToString();

                adminControl1.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            con.Close();
        }

        private void PrintListUserAdmin(AdminControl adminControl1)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [people]", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            adminControl1.flowLayoutPanel3.Controls.Clear();
            Random random = new Random();

            while (reader.Read())
            {
                ElUserList Item = new ElUserList();
                Item.gunaLabel1.Text += reader[3].ToString();
                Item.gunaLabel3.Text += reader[4].ToString();
                Item.gunaLabel4.Text += reader[1].ToString();
                Item.gunaLabel2.Text += random.Next(1, 15).ToString();

                adminControl1.flowLayoutPanel3.Controls.Add(Item);
            }
            reader.Close();
            con.Close();
        }

        //--------------------------------- Заказы
        private void btnOrder_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            OrderControl orderControl = new OrderControl();
            InfoPanel.Controls.Add(orderControl);
            orderControl.Dock = DockStyle.Fill;
            orderControl.BringToFront();
            PrintOrder(orderControl);
        }

        private void PrintOrder(OrderControl orderControl)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [order]", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            Random random = new Random();

            orderControl.flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElOrderList Item = new ElOrderList();
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.gunaLabel2.Text = reader[2].ToString();
                Item.gunaLabel6.Text = reader[3].ToString();
                Item.gunaLabel4.Text += random.Next(1, 1500).ToString();
                Item.Size = new Size(709, 36);

                orderControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            con.Close();
        }

        //-------------------------------- Товары
        private void PrintProduct(ProductControl productControl, string str)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM product", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str == reader[2].ToString())
                {
                    ElProduct Item = new ElProduct();

                    byte[] Photo = (byte[])(reader[6]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    Item.gunaPictureBox1.Image = Image.FromStream(memoryStream);
                    Item.NameProduct.Text = reader[1].ToString();

                    productControl.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            reader.Close();
            con.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintProduct(productControl, "Видеокарты");
        }

        private void btnBestSellers_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintProduct(productControl, "Процессоры");
        }

        private void btnChildrens_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintProduct(productControl, "Клавиатура");
        }

        private void btnFantasy_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintProduct(productControl, "Мыши");
        }

        //------------------------------------------ Корзина
        private void btnBasket_Click(object sender, EventArgs e)
        {

            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            BasketControl basketControl = new BasketControl();
            InfoPanel.Controls.Add(basketControl);
            basketControl.Dock = DockStyle.Fill;
            basketControl.BringToFront();

            PrintBasketBook(basketControl);
            CountBasketBook(basketControl);
        }

        private void CountBasketBook(BasketControl basketControl)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM basket", con);
            con.Open();
            basketControl.gunaLabel5.Text = "Итого: " + cmd.ExecuteScalar().ToString() + " товаров";
            con.Close();
        }

        private void PrintBasketBook(BasketControl basketControl)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM basket", con);
            con.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ElBasketList Item = new ElBasketList();

                byte[] Photo = (byte[])(reader[2]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.gunaCirclePictureBox1.Image = Image.FromStream(memoryStream);
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.gunaLabel2.Text = reader[3].ToString();
                basketControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            con.Close();
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            InfoPanel.Controls.Add(userControl1);

            if (UserName.Text != "Name")
            {
                userControl1.PanelLogReg.Visible = false;
                userControl1.Size = new Size(134, 45);
            }

            userControl1.Location = new Point(626, 0);
            userControl1.BringToFront();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [basket]", con);
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SystemSP system = new SystemSP();
            system.Show();
        }
    }
}
