namespace EAutomize.Form
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.WinForms.GunaAdvenceButton btnAddProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.BoxCategory = new Guna.UI.WinForms.GunaComboBox();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxBrand = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxAge = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.PictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxDescription = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnBrowse = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            btnAddProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.AnimationHoverSpeed = 0.07F;
            btnAddProduct.AnimationSpeed = 0.03F;
            btnAddProduct.BaseColor = System.Drawing.Color.DimGray;
            btnAddProduct.BorderColor = System.Drawing.Color.Black;
            btnAddProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            btnAddProduct.CheckedBorderColor = System.Drawing.Color.Black;
            btnAddProduct.CheckedForeColor = System.Drawing.Color.White;
            btnAddProduct.CheckedImage = null;
            btnAddProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            btnAddProduct.Font = new System.Drawing.Font("Sitka Text", 12F);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Image = null;
            btnAddProduct.ImageSize = new System.Drawing.Size(20, 20);
            btnAddProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnAddProduct.Location = new System.Drawing.Point(315, 393);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.OnHoverBaseColor = System.Drawing.Color.Gray;
            btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            btnAddProduct.OnHoverForeColor = System.Drawing.Color.White;
            btnAddProduct.OnHoverImage = null;
            btnAddProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            btnAddProduct.Size = new System.Drawing.Size(107, 31);
            btnAddProduct.TabIndex = 29;
            btnAddProduct.Text = " Добавить";
            btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoScroll = true;
            this.gunaPanel2.Controls.Add(this.gunaLabel7);
            this.gunaPanel2.Controls.Add(this.BoxCategory);
            this.gunaPanel2.Controls.Add(this.TextBoxName);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.gunaLabel5);
            this.gunaPanel2.Controls.Add(this.TextBoxBrand);
            this.gunaPanel2.Controls.Add(this.TextBoxAge);
            this.gunaPanel2.Location = new System.Drawing.Point(184, 30);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(351, 201);
            this.gunaPanel2.TabIndex = 35;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(3, 44);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel7.TabIndex = 37;
            this.gunaLabel7.Text = "Категория";
            // 
            // BoxCategory
            // 
            this.BoxCategory.BackColor = System.Drawing.Color.Transparent;
            this.BoxCategory.BaseColor = System.Drawing.Color.White;
            this.BoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.BoxCategory.BorderSize = 1;
            this.BoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxCategory.FocusedColor = System.Drawing.Color.Empty;
            this.BoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BoxCategory.ForeColor = System.Drawing.Color.Black;
            this.BoxCategory.FormattingEnabled = true;
            this.BoxCategory.Items.AddRange(new object[] {
            "Комплектующие",
            "Оргтехника",
            "Ноутбуки",
            "Клавиатуры, мыши",
            "Мониторы",
            "Мультимедия"});
            this.BoxCategory.Location = new System.Drawing.Point(68, 39);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.OnHoverItemBaseColor = System.Drawing.Color.Black;
            this.BoxCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.BoxCategory.Radius = 10;
            this.BoxCategory.Size = new System.Drawing.Size(266, 26);
            this.BoxCategory.TabIndex = 8;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxName.BaseColor = System.Drawing.Color.White;
            this.TextBoxName.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxName.BorderSize = 1;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.Location = new System.Drawing.Point(68, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 10;
            this.TextBoxName.Size = new System.Drawing.Size(266, 30);
            this.TextBoxName.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Название";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(3, 79);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Бренд";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 79);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Бренд";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(3, 115);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(147, 15);
            this.gunaLabel5.TabIndex = 6;
            this.gunaLabel5.Text = "Возрастные ограничения";
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxBrand.BaseColor = System.Drawing.Color.White;
            this.TextBoxBrand.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxBrand.BorderSize = 1;
            this.TextBoxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxBrand.Location = new System.Drawing.Point(68, 72);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.PasswordChar = '\0';
            this.TextBoxBrand.Radius = 10;
            this.TextBoxBrand.Size = new System.Drawing.Size(266, 30);
            this.TextBoxBrand.TabIndex = 9;
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxAge.BaseColor = System.Drawing.Color.White;
            this.TextBoxAge.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxAge.BorderSize = 1;
            this.TextBoxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAge.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAge.Location = new System.Drawing.Point(156, 108);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.PasswordChar = '\0';
            this.TextBoxAge.Radius = 10;
            this.TextBoxAge.Size = new System.Drawing.Size(178, 30);
            this.TextBoxAge.TabIndex = 17;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaPanel1.Controls.Add(this.PictureBox);
            this.gunaPanel1.Location = new System.Drawing.Point(33, 30);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(133, 164);
            this.gunaPanel1.TabIndex = 32;
            // 
            // PictureBox
            // 
            this.PictureBox.BaseColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(133, 164);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(428, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "  Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDescription.BaseColor = System.Drawing.Color.White;
            this.TextBoxDescription.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxDescription.BorderSize = 1;
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescription.Location = new System.Drawing.Point(33, 257);
            this.TextBoxDescription.MultiLine = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.PasswordChar = '\0';
            this.TextBoxDescription.Radius = 10;
            this.TextBoxDescription.Size = new System.Drawing.Size(502, 130);
            this.TextBoxDescription.TabIndex = 28;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(30, 239);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Описание";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationHoverSpeed = 0.07F;
            this.btnBrowse.AnimationSpeed = 0.03F;
            this.btnBrowse.BaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.CheckedForeColor = System.Drawing.Color.White;
            this.btnBrowse.CheckedImage = null;
            this.btnBrowse.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = null;
            this.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBrowse.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.Location = new System.Drawing.Point(33, 200);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnBrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnHoverImage = null;
            this.btnBrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowse.Size = new System.Drawing.Size(133, 31);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Добавить картинку";
            this.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPrice.BaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPrice.BorderSize = 1;
            this.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrice.Location = new System.Drawing.Point(74, 394);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.PasswordChar = '\0';
            this.TextBoxPrice.Radius = 10;
            this.TextBoxPrice.Size = new System.Drawing.Size(92, 30);
            this.TextBoxPrice.TabIndex = 36;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(36, 401);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel8.TabIndex = 37;
            this.gunaLabel8.Text = "Цена";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 454);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(btnAddProduct);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaTextBox TextBoxBrand;
        private Guna.UI.WinForms.GunaTextBox TextBoxAge;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox PictureBox;
        public Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaTextBox TextBoxDescription;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaAdvenceButton btnBrowse;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox BoxCategory;
        private Guna.UI.WinForms.GunaTextBox TextBoxPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}