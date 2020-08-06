namespace ManageShop
{
    partial class MainMenu
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btn_Selling = new System.Windows.Forms.Button();
            this.btn_FoodMenu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Selling
            // 
            this.btn_Selling.BackgroundImage = global::ManageShop.Properties.Resources.Bán_hàng;
            this.btn_Selling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Selling.Location = new System.Drawing.Point(459, 91);
            this.btn_Selling.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Selling.Name = "btn_Selling";
            this.btn_Selling.Size = new System.Drawing.Size(231, 74);
            this.btn_Selling.TabIndex = 0;
            this.btn_Selling.UseVisualStyleBackColor = true;
            this.btn_Selling.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_FoodMenu
            // 
            this.btn_FoodMenu.BackgroundImage = global::ManageShop.Properties.Resources.Menu;
            this.btn_FoodMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FoodMenu.Location = new System.Drawing.Point(459, 172);
            this.btn_FoodMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FoodMenu.Name = "btn_FoodMenu";
            this.btn_FoodMenu.Size = new System.Drawing.Size(231, 74);
            this.btn_FoodMenu.TabIndex = 1;
            this.btn_FoodMenu.UseVisualStyleBackColor = true;
            this.btn_FoodMenu.Click += new System.EventHandler(this.btn_FoodMenu_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ManageShop.Properties.Resources.Doanh_thu;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(459, 254);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 74);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ManageShop.Properties.Resources.Thoát;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(459, 335);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 74);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageShop.Properties.Resources._39020284_1838944149533635_2942100503825219584_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 540);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_FoodMenu);
            this.Controls.Add(this.btn_Selling);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_Selling;
        private System.Windows.Forms.Button btn_FoodMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

