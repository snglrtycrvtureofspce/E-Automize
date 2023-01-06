namespace EAutomize.Control.ElControls
{
    partial class ElProductList
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElProductList));
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnDeleteSoonFilm = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSoonFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(631, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(20, 15);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "№";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(512, 9);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Category";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaLabel1.Location = new System.Drawing.Point(91, 2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(415, 28);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Name";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(29, 0);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 5;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // btnDeleteSoonFilm
            // 
            this.btnDeleteSoonFilm.BaseColor = System.Drawing.Color.White;
            this.btnDeleteSoonFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSoonFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSoonFilm.Image")));
            this.btnDeleteSoonFilm.Location = new System.Drawing.Point(689, 9);
            this.btnDeleteSoonFilm.Name = "btnDeleteSoonFilm";
            this.btnDeleteSoonFilm.Size = new System.Drawing.Size(15, 15);
            this.btnDeleteSoonFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteSoonFilm.TabIndex = 10;
            this.btnDeleteSoonFilm.TabStop = false;
            this.btnDeleteSoonFilm.Click += new System.EventHandler(this.btnDeleteSoonFilm_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(21, 32);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(667, 10);
            this.gunaSeparator1.TabIndex = 11;
            // 
            // ElProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btnDeleteSoonFilm);
            this.Controls.Add(this.gunaLabel4);
            this.Name = "ElProductList";
            this.Size = new System.Drawing.Size(716, 38);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSoonFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaPictureBox btnDeleteSoonFilm;
        public Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
    }
}
