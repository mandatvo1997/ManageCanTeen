namespace ManageShop
{
    partial class Selling
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
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.drinkDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sellingDataGridView = new System.Windows.Forms.DataGridView();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.cbo_MonAn = new System.Windows.Forms.ComboBox();
            this.cbo_ThucUong = new System.Windows.Forms.ComboBox();
            this.num_MonAn = new System.Windows.Forms.NumericUpDown();
            this.num_ThucUong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_MonAn = new System.Windows.Forms.Label();
            this.lbl_DoUong = new System.Windows.Forms.Label();
            this.lbl_FooDSL = new System.Windows.Forms.Label();
            this.lbl_DrinkSL = new System.Windows.Forms.Label();
            this.lbl_TienFood = new System.Windows.Forms.Label();
            this.lbl_TienDrink = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_History = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThucUong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Location = new System.Drawing.Point(46, 17);
            this.foodDataGridView.MultiSelect = false;
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.ReadOnly = true;
            this.foodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodDataGridView.Size = new System.Drawing.Size(240, 176);
            this.foodDataGridView.TabIndex = 0;
            // 
            // drinkDataGridView
            // 
            this.drinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkDataGridView.Location = new System.Drawing.Point(46, 210);
            this.drinkDataGridView.MultiSelect = false;
            this.drinkDataGridView.Name = "drinkDataGridView";
            this.drinkDataGridView.ReadOnly = true;
            this.drinkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drinkDataGridView.Size = new System.Drawing.Size(240, 176);
            this.drinkDataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drinkDataGridView);
            this.groupBox1.Controls.Add(this.foodDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(457, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 410);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // sellingDataGridView
            // 
            this.sellingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingDataGridView.Location = new System.Drawing.Point(129, 362);
            this.sellingDataGridView.Name = "sellingDataGridView";
            this.sellingDataGridView.ReadOnly = true;
            this.sellingDataGridView.Size = new System.Drawing.Size(20, 17);
            this.sellingDataGridView.TabIndex = 0;
            this.sellingDataGridView.Visible = false;
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(98, 17);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(263, 20);
            this.txt_MaPhieu.TabIndex = 0;
            // 
            // cbo_MonAn
            // 
            this.cbo_MonAn.FormattingEnabled = true;
            this.cbo_MonAn.Location = new System.Drawing.Point(55, 61);
            this.cbo_MonAn.Name = "cbo_MonAn";
            this.cbo_MonAn.Size = new System.Drawing.Size(121, 21);
            this.cbo_MonAn.TabIndex = 1;
            // 
            // cbo_ThucUong
            // 
            this.cbo_ThucUong.FormattingEnabled = true;
            this.cbo_ThucUong.Items.AddRange(new object[] {
            "Không"});
            this.cbo_ThucUong.Location = new System.Drawing.Point(307, 62);
            this.cbo_ThucUong.Name = "cbo_ThucUong";
            this.cbo_ThucUong.Size = new System.Drawing.Size(121, 21);
            this.cbo_ThucUong.TabIndex = 3;
            // 
            // num_MonAn
            // 
            this.num_MonAn.Location = new System.Drawing.Point(55, 89);
            this.num_MonAn.Name = "num_MonAn";
            this.num_MonAn.Size = new System.Drawing.Size(120, 20);
            this.num_MonAn.TabIndex = 2;
            // 
            // num_ThucUong
            // 
            this.num_ThucUong.Location = new System.Drawing.Point(307, 89);
            this.num_ThucUong.Name = "num_ThucUong";
            this.num_ThucUong.Size = new System.Drawing.Size(120, 20);
            this.num_ThucUong.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Món Ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thức uống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Phiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.num_ThucUong);
            this.groupBox2.Controls.Add(this.num_MonAn);
            this.groupBox2.Controls.Add(this.cbo_ThucUong);
            this.groupBox2.Controls.Add(this.cbo_MonAn);
            this.groupBox2.Controls.Add(this.txt_MaPhieu);
            this.groupBox2.Location = new System.Drawing.Point(9, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(442, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(166, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên Món";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(262, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(265, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tổng Tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(364, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Thành Tiền";
            // 
            // lbl_MonAn
            // 
            this.lbl_MonAn.AutoSize = true;
            this.lbl_MonAn.Location = new System.Drawing.Point(166, 200);
            this.lbl_MonAn.Name = "lbl_MonAn";
            this.lbl_MonAn.Size = new System.Drawing.Size(44, 13);
            this.lbl_MonAn.TabIndex = 11;
            this.lbl_MonAn.Text = "Món Ăn";
            // 
            // lbl_DoUong
            // 
            this.lbl_DoUong.AutoSize = true;
            this.lbl_DoUong.Location = new System.Drawing.Point(166, 224);
            this.lbl_DoUong.Name = "lbl_DoUong";
            this.lbl_DoUong.Size = new System.Drawing.Size(50, 13);
            this.lbl_DoUong.TabIndex = 11;
            this.lbl_DoUong.Text = "Tên Món";
            // 
            // lbl_FooDSL
            // 
            this.lbl_FooDSL.AutoSize = true;
            this.lbl_FooDSL.Location = new System.Drawing.Point(262, 200);
            this.lbl_FooDSL.Name = "lbl_FooDSL";
            this.lbl_FooDSL.Size = new System.Drawing.Size(80, 13);
            this.lbl_FooDSL.TabIndex = 11;
            this.lbl_FooDSL.Text = "Số Lượng Food";
            // 
            // lbl_DrinkSL
            // 
            this.lbl_DrinkSL.AutoSize = true;
            this.lbl_DrinkSL.Location = new System.Drawing.Point(262, 224);
            this.lbl_DrinkSL.Name = "lbl_DrinkSL";
            this.lbl_DrinkSL.Size = new System.Drawing.Size(81, 13);
            this.lbl_DrinkSL.TabIndex = 11;
            this.lbl_DrinkSL.Text = "Số Lượng Drink";
            // 
            // lbl_TienFood
            // 
            this.lbl_TienFood.AutoSize = true;
            this.lbl_TienFood.Location = new System.Drawing.Point(364, 200);
            this.lbl_TienFood.Name = "lbl_TienFood";
            this.lbl_TienFood.Size = new System.Drawing.Size(89, 13);
            this.lbl_TienFood.TabIndex = 11;
            this.lbl_TienFood.Text = "Thành Tiền Food";
            // 
            // lbl_TienDrink
            // 
            this.lbl_TienDrink.AutoSize = true;
            this.lbl_TienDrink.Location = new System.Drawing.Point(364, 224);
            this.lbl_TienDrink.Name = "lbl_TienDrink";
            this.lbl_TienDrink.Size = new System.Drawing.Size(62, 13);
            this.lbl_TienDrink.TabIndex = 11;
            this.lbl_TienDrink.Text = "Thành Tiền";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(364, 276);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(56, 13);
            this.lbl_TongTien.TabIndex = 12;
            this.lbl_TongTien.Text = "Tổng Tiền";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Login,
            this.menuStrip_MainMenu,
            this.menuStrip_Menu,
            this.menuStrip_History,
            this.reportToolStripMenuItem});
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.moveToToolStripMenuItem.Text = "Move To...";
            // 
            // menuStrip_Login
            // 
            this.menuStrip_Login.Name = "menuStrip_Login";
            this.menuStrip_Login.Size = new System.Drawing.Size(132, 22);
            this.menuStrip_Login.Text = "Login";
            this.menuStrip_Login.Click += new System.EventHandler(this.menuStrip_Login_Click);
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(132, 22);
            this.menuStrip_MainMenu.Text = "MainMenu";
            this.menuStrip_MainMenu.Click += new System.EventHandler(this.menuStrip_MainMenu_Click);
            // 
            // menuStrip_Menu
            // 
            this.menuStrip_Menu.Name = "menuStrip_Menu";
            this.menuStrip_Menu.Size = new System.Drawing.Size(132, 22);
            this.menuStrip_Menu.Text = "Menu";
            this.menuStrip_Menu.Click += new System.EventHandler(this.menuStrip_Menu_Click);
            // 
            // menuStrip_History
            // 
            this.menuStrip_History.Name = "menuStrip_History";
            this.menuStrip_History.Size = new System.Drawing.Size(132, 22);
            this.menuStrip_History.Text = "History";
            this.menuStrip_History.Click += new System.EventHandler(this.menuStrip_History_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.BackgroundImage = global::ManageShop.Properties.Resources.Tính1;
            this.btn_TinhTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TinhTien.Location = new System.Drawing.Point(364, 305);
            this.btn_TinhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(52, 29);
            this.btn_TinhTien.TabIndex = 10;
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(353, 356);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 401);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellingDataGridView);
            this.Controls.Add(this.lbl_TienDrink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_MonAn);
            this.Controls.Add(this.lbl_TienFood);
            this.Controls.Add(this.lbl_DoUong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_FooDSL);
            this.Controls.Add(this.lbl_DrinkSL);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Selling";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.Selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ThucUong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.DataGridView drinkDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView sellingDataGridView;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.ComboBox cbo_MonAn;
        private System.Windows.Forms.ComboBox cbo_ThucUong;
        private System.Windows.Forms.NumericUpDown num_MonAn;
        private System.Windows.Forms.NumericUpDown num_ThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_MonAn;
        private System.Windows.Forms.Label lbl_DoUong;
        private System.Windows.Forms.Label lbl_FooDSL;
        private System.Windows.Forms.Label lbl_DrinkSL;
        private System.Windows.Forms.Label lbl_TienFood;
        private System.Windows.Forms.Label lbl_TienDrink;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Login;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_History;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Button btnIn;
    }
}