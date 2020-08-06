namespace ManageShop
{
    partial class FoodMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_FoodNew = new System.Windows.Forms.Button();
            this.btn_FoodEdit = new System.Windows.Forms.Button();
            this.btn_foodXoa = new System.Windows.Forms.Button();
            this.btn_themFood = new System.Windows.Forms.Button();
            this.txt_FoodDonGia = new System.Windows.Forms.TextBox();
            this.txt_FoodName = new System.Windows.Forms.TextBox();
            this.txt_FoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DrinkNew = new System.Windows.Forms.Button();
            this.btn_DrinkEdit = new System.Windows.Forms.Button();
            this.btn_DrinkXoa = new System.Windows.Forms.Button();
            this.btn_themDrink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DrinkDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DrinkName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DrinkID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStirp_MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Selling = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_History = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Save = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Location = new System.Drawing.Point(12, 349);
            this.foodDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodDataGridView.MultiSelect = false;
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.ReadOnly = true;
            this.foodDataGridView.RowTemplate.Height = 24;
            this.foodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodDataGridView.Size = new System.Drawing.Size(485, 207);
            this.foodDataGridView.TabIndex = 0;
            this.foodDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellClick);
            // 
            // drinkDataGridView
            // 
            this.drinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkDataGridView.Location = new System.Drawing.Point(543, 349);
            this.drinkDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drinkDataGridView.MultiSelect = false;
            this.drinkDataGridView.Name = "drinkDataGridView";
            this.drinkDataGridView.ReadOnly = true;
            this.drinkDataGridView.RowTemplate.Height = 24;
            this.drinkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drinkDataGridView.Size = new System.Drawing.Size(485, 207);
            this.drinkDataGridView.TabIndex = 1;
            this.drinkDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drinkDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FoodNew);
            this.groupBox1.Controls.Add(this.btn_FoodEdit);
            this.groupBox1.Controls.Add(this.btn_foodXoa);
            this.groupBox1.Controls.Add(this.btn_themFood);
            this.groupBox1.Controls.Add(this.txt_FoodDonGia);
            this.groupBox1.Controls.Add(this.txt_FoodName);
            this.groupBox1.Controls.Add(this.txt_FoodID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(485, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đồ Ăn";
            // 
            // btn_FoodNew
            // 
            this.btn_FoodNew.BackgroundImage = global::ManageShop.Properties.Resources.Làm_mới;
            this.btn_FoodNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FoodNew.Location = new System.Drawing.Point(319, 197);
            this.btn_FoodNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FoodNew.Name = "btn_FoodNew";
            this.btn_FoodNew.Size = new System.Drawing.Size(123, 38);
            this.btn_FoodNew.TabIndex = 5;
            this.btn_FoodNew.UseVisualStyleBackColor = true;
            this.btn_FoodNew.Click += new System.EventHandler(this.btn_FoodNew_Click);
            // 
            // btn_FoodEdit
            // 
            this.btn_FoodEdit.BackgroundImage = global::ManageShop.Properties.Resources.Sửa;
            this.btn_FoodEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FoodEdit.Location = new System.Drawing.Point(367, 122);
            this.btn_FoodEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FoodEdit.Name = "btn_FoodEdit";
            this.btn_FoodEdit.Size = new System.Drawing.Size(75, 37);
            this.btn_FoodEdit.TabIndex = 5;
            this.btn_FoodEdit.UseVisualStyleBackColor = true;
            this.btn_FoodEdit.Click += new System.EventHandler(this.btn_FoodEdit_Click);
            // 
            // btn_foodXoa
            // 
            this.btn_foodXoa.BackgroundImage = global::ManageShop.Properties.Resources.Xoá;
            this.btn_foodXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_foodXoa.Location = new System.Drawing.Point(367, 69);
            this.btn_foodXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_foodXoa.Name = "btn_foodXoa";
            this.btn_foodXoa.Size = new System.Drawing.Size(75, 41);
            this.btn_foodXoa.TabIndex = 4;
            this.btn_foodXoa.UseVisualStyleBackColor = true;
            this.btn_foodXoa.Click += new System.EventHandler(this.btn_foodXoa_Click);
            // 
            // btn_themFood
            // 
            this.btn_themFood.BackgroundImage = global::ManageShop.Properties.Resources.Thêm;
            this.btn_themFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_themFood.Location = new System.Drawing.Point(367, 16);
            this.btn_themFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themFood.Name = "btn_themFood";
            this.btn_themFood.Size = new System.Drawing.Size(75, 41);
            this.btn_themFood.TabIndex = 3;
            this.btn_themFood.UseVisualStyleBackColor = true;
            this.btn_themFood.Click += new System.EventHandler(this.btn_themFood_Click);
            // 
            // txt_FoodDonGia
            // 
            this.txt_FoodDonGia.Location = new System.Drawing.Point(93, 110);
            this.txt_FoodDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FoodDonGia.Name = "txt_FoodDonGia";
            this.txt_FoodDonGia.Size = new System.Drawing.Size(100, 22);
            this.txt_FoodDonGia.TabIndex = 2;
            this.txt_FoodDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FoodDonGia_KeyPress);
            // 
            // txt_FoodName
            // 
            this.txt_FoodName.Location = new System.Drawing.Point(93, 63);
            this.txt_FoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FoodName.Name = "txt_FoodName";
            this.txt_FoodName.Size = new System.Drawing.Size(100, 22);
            this.txt_FoodName.TabIndex = 1;
            // 
            // txt_FoodID
            // 
            this.txt_FoodID.Location = new System.Drawing.Point(93, 18);
            this.txt_FoodID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FoodID.Name = "txt_FoodID";
            this.txt_FoodID.Size = new System.Drawing.Size(100, 22);
            this.txt_FoodID.TabIndex = 0;
            this.txt_FoodID.TextChanged += new System.EventHandler(this.txt_FoodID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DrinkNew);
            this.groupBox2.Controls.Add(this.btn_DrinkEdit);
            this.groupBox2.Controls.Add(this.btn_DrinkXoa);
            this.groupBox2.Controls.Add(this.btn_themDrink);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_DrinkDonGia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_DrinkName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DrinkID);
            this.groupBox2.Location = new System.Drawing.Point(543, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(485, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ Uống";
            // 
            // btn_DrinkNew
            // 
            this.btn_DrinkNew.BackgroundImage = global::ManageShop.Properties.Resources.Làm_mới;
            this.btn_DrinkNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DrinkNew.Location = new System.Drawing.Point(328, 193);
            this.btn_DrinkNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DrinkNew.Name = "btn_DrinkNew";
            this.btn_DrinkNew.Size = new System.Drawing.Size(123, 38);
            this.btn_DrinkNew.TabIndex = 6;
            this.btn_DrinkNew.UseVisualStyleBackColor = true;
            this.btn_DrinkNew.Click += new System.EventHandler(this.btn_DrinkNew_Click);
            // 
            // btn_DrinkEdit
            // 
            this.btn_DrinkEdit.BackgroundImage = global::ManageShop.Properties.Resources.Sửa;
            this.btn_DrinkEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DrinkEdit.Location = new System.Drawing.Point(376, 116);
            this.btn_DrinkEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DrinkEdit.Name = "btn_DrinkEdit";
            this.btn_DrinkEdit.Size = new System.Drawing.Size(75, 37);
            this.btn_DrinkEdit.TabIndex = 5;
            this.btn_DrinkEdit.UseVisualStyleBackColor = true;
            this.btn_DrinkEdit.Click += new System.EventHandler(this.btn_DrinkEdit_Click);
            // 
            // btn_DrinkXoa
            // 
            this.btn_DrinkXoa.BackgroundImage = global::ManageShop.Properties.Resources.Xoá;
            this.btn_DrinkXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DrinkXoa.Location = new System.Drawing.Point(376, 70);
            this.btn_DrinkXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DrinkXoa.Name = "btn_DrinkXoa";
            this.btn_DrinkXoa.Size = new System.Drawing.Size(75, 37);
            this.btn_DrinkXoa.TabIndex = 4;
            this.btn_DrinkXoa.UseVisualStyleBackColor = true;
            this.btn_DrinkXoa.Click += new System.EventHandler(this.btn_DrinkXoa_Click);
            // 
            // btn_themDrink
            // 
            this.btn_themDrink.BackgroundImage = global::ManageShop.Properties.Resources.Thêm;
            this.btn_themDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_themDrink.Location = new System.Drawing.Point(376, 23);
            this.btn_themDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themDrink.Name = "btn_themDrink";
            this.btn_themDrink.Size = new System.Drawing.Size(75, 37);
            this.btn_themDrink.TabIndex = 3;
            this.btn_themDrink.UseVisualStyleBackColor = true;
            this.btn_themDrink.Click += new System.EventHandler(this.btn_themDrink_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn Giá";
            // 
            // txt_DrinkDonGia
            // 
            this.txt_DrinkDonGia.Location = new System.Drawing.Point(93, 105);
            this.txt_DrinkDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DrinkDonGia.Name = "txt_DrinkDonGia";
            this.txt_DrinkDonGia.Size = new System.Drawing.Size(100, 22);
            this.txt_DrinkDonGia.TabIndex = 2;
            this.txt_DrinkDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DrinkDonGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drink Name";
            // 
            // txt_DrinkName
            // 
            this.txt_DrinkName.Location = new System.Drawing.Point(93, 64);
            this.txt_DrinkName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DrinkName.Name = "txt_DrinkName";
            this.txt_DrinkName.Size = new System.Drawing.Size(100, 22);
            this.txt_DrinkName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Drink ID";
            // 
            // txt_DrinkID
            // 
            this.txt_DrinkID.Location = new System.Drawing.Point(93, 20);
            this.txt_DrinkID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DrinkID.Name = "txt_DrinkID";
            this.txt_DrinkID.Size = new System.Drawing.Size(100, 22);
            this.txt_DrinkID.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Login,
            this.menuStirp_MainMenu,
            this.menuStrip_Selling,
            this.menuStrip_History});
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.moveToToolStripMenuItem.Text = "Move To...";
            // 
            // menuStrip_Login
            // 
            this.menuStrip_Login.Name = "menuStrip_Login";
            this.menuStrip_Login.Size = new System.Drawing.Size(158, 26);
            this.menuStrip_Login.Text = "Login";
            this.menuStrip_Login.Click += new System.EventHandler(this.menuStrip_Login_Click);
            // 
            // menuStirp_MainMenu
            // 
            this.menuStirp_MainMenu.Name = "menuStirp_MainMenu";
            this.menuStirp_MainMenu.Size = new System.Drawing.Size(158, 26);
            this.menuStirp_MainMenu.Text = "Main Menu";
            this.menuStirp_MainMenu.Click += new System.EventHandler(this.menuStirp_MainMenu_Click);
            // 
            // menuStrip_Selling
            // 
            this.menuStrip_Selling.Name = "menuStrip_Selling";
            this.menuStrip_Selling.Size = new System.Drawing.Size(158, 26);
            this.menuStrip_Selling.Text = "Selling";
            this.menuStrip_Selling.Click += new System.EventHandler(this.menuStrip_Selling_Click);
            // 
            // menuStrip_History
            // 
            this.menuStrip_History.Name = "menuStrip_History";
            this.menuStrip_History.Size = new System.Drawing.Size(158, 26);
            this.menuStrip_History.Text = "History";
            this.menuStrip_History.Click += new System.EventHandler(this.menuStrip_History_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(464, 307);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 37);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Cập Nhật";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 567);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drinkDataGridView);
            this.Controls.Add(this.foodDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.Load += new System.EventHandler(this.FoodMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_FoodName;
        private System.Windows.Forms.TextBox txt_FoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themFood;
        private System.Windows.Forms.TextBox txt_FoodDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DrinkDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DrinkName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DrinkID;
        private System.Windows.Forms.Button btn_themDrink;
        private System.Windows.Forms.Button btn_foodXoa;
        private System.Windows.Forms.Button btn_DrinkXoa;
        private System.Windows.Forms.Button btn_FoodEdit;
        private System.Windows.Forms.Button btn_DrinkEdit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_FoodNew;
        private System.Windows.Forms.Button btn_DrinkNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Login;
        private System.Windows.Forms.ToolStripMenuItem menuStirp_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Selling;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_History;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}