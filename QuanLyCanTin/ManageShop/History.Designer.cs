namespace ManageShop
{
    partial class History
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.cbBox_Title = new System.Windows.Forms.ComboBox();
            this.cbBox_Sons = new System.Windows.Forms.ComboBox();
            this.cbBox_Sons2 = new System.Windows.Forms.ComboBox();
            this.cbBox_Sons3 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Selling = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(9, 65);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(649, 149);
            this.customerDataGridView.TabIndex = 0;
            // 
            // cbBox_Title
            // 
            this.cbBox_Title.FormattingEnabled = true;
            this.cbBox_Title.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Tên Món Ăn",
            "Tên Đồ Uống"});
            this.cbBox_Title.Location = new System.Drawing.Point(26, 30);
            this.cbBox_Title.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_Title.Name = "cbBox_Title";
            this.cbBox_Title.Size = new System.Drawing.Size(92, 21);
            this.cbBox_Title.TabIndex = 1;
            this.cbBox_Title.SelectedIndexChanged += new System.EventHandler(this.cbBox_Title_SelectedIndexChanged);
            // 
            // cbBox_Sons
            // 
            this.cbBox_Sons.FormattingEnabled = true;
            this.cbBox_Sons.Location = new System.Drawing.Point(135, 30);
            this.cbBox_Sons.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_Sons.Name = "cbBox_Sons";
            this.cbBox_Sons.Size = new System.Drawing.Size(92, 21);
            this.cbBox_Sons.TabIndex = 2;
            this.cbBox_Sons.SelectedIndexChanged += new System.EventHandler(this.cbBox_Sons_SelectedIndexChanged);
            // 
            // cbBox_Sons2
            // 
            this.cbBox_Sons2.FormattingEnabled = true;
            this.cbBox_Sons2.Location = new System.Drawing.Point(135, 30);
            this.cbBox_Sons2.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_Sons2.Name = "cbBox_Sons2";
            this.cbBox_Sons2.Size = new System.Drawing.Size(92, 21);
            this.cbBox_Sons2.TabIndex = 3;
            this.cbBox_Sons2.SelectedIndexChanged += new System.EventHandler(this.cbBox_Sons2_SelectedIndexChanged);
            // 
            // cbBox_Sons3
            // 
            this.cbBox_Sons3.FormattingEnabled = true;
            this.cbBox_Sons3.Location = new System.Drawing.Point(135, 30);
            this.cbBox_Sons3.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_Sons3.Name = "cbBox_Sons3";
            this.cbBox_Sons3.Size = new System.Drawing.Size(92, 21);
            this.cbBox_Sons3.TabIndex = 4;
            this.cbBox_Sons3.SelectedIndexChanged += new System.EventHandler(this.cbBox_Sons3_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moveToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Refresh});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip_Refresh
            // 
            this.menuStrip_Refresh.Name = "menuStrip_Refresh";
            this.menuStrip_Refresh.Size = new System.Drawing.Size(113, 22);
            this.menuStrip_Refresh.Text = "Refresh";
            this.menuStrip_Refresh.Click += new System.EventHandler(this.menuStrip_Refresh_Click);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Login,
            this.menuStrip_MainMenu,
            this.menuStrip_Menu,
            this.menuStrip_Selling});
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.moveToToolStripMenuItem.Text = "Move to...";
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
            // menuStrip_Selling
            // 
            this.menuStrip_Selling.Name = "menuStrip_Selling";
            this.menuStrip_Selling.Size = new System.Drawing.Size(132, 22);
            this.menuStrip_Selling.Text = "Selling";
            this.menuStrip_Selling.Click += new System.EventHandler(this.menuStrip_Selling_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 235);
            this.Controls.Add(this.cbBox_Sons3);
            this.Controls.Add(this.cbBox_Sons2);
            this.Controls.Add(this.cbBox_Sons);
            this.Controls.Add(this.cbBox_Title);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.ComboBox cbBox_Title;
        private System.Windows.Forms.ComboBox cbBox_Sons;
        private System.Windows.Forms.ComboBox cbBox_Sons2;
        private System.Windows.Forms.ComboBox cbBox_Sons3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Refresh;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Login;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Menu;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Selling;
    }
}