namespace ManageShop
{
    partial class Login
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
            this.txt_USer = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.login_DataGridView = new System.Windows.Forms.DataGridView();
            this.btn_ShowPW = new System.Windows.Forms.Button();
            this.btn_SginUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_USer
            // 
            this.txt_USer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_USer.Location = new System.Drawing.Point(184, 174);
            this.txt_USer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_USer.Name = "txt_USer";
            this.txt_USer.Size = new System.Drawing.Size(312, 30);
            this.txt_USer.TabIndex = 0;
            this.txt_USer.TextChanged += new System.EventHandler(this.txt_USer_TextChanged);
            // 
            // txt_PW
            // 
            this.txt_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PW.Location = new System.Drawing.Point(184, 255);
            this.txt_PW.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(312, 30);
            this.txt_PW.TabIndex = 1;
            this.txt_PW.TextChanged += new System.EventHandler(this.txt_PW_TextChanged);
            this.txt_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PW_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::ManageShop.Properties.Resources.btn_Go;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(184, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Click);
            // 
            // login_DataGridView
            // 
            this.login_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.login_DataGridView.Location = new System.Drawing.Point(12, 422);
            this.login_DataGridView.Name = "login_DataGridView";
            this.login_DataGridView.RowTemplate.Height = 24;
            this.login_DataGridView.Size = new System.Drawing.Size(21, 21);
            this.login_DataGridView.TabIndex = 3;
            this.login_DataGridView.Visible = false;
            // 
            // btn_ShowPW
            // 
            this.btn_ShowPW.BackgroundImage = global::ManageShop.Properties.Resources._777494_200;
            this.btn_ShowPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowPW.Location = new System.Drawing.Point(503, 255);
            this.btn_ShowPW.Name = "btn_ShowPW";
            this.btn_ShowPW.Size = new System.Drawing.Size(32, 30);
            this.btn_ShowPW.TabIndex = 4;
            this.btn_ShowPW.UseVisualStyleBackColor = true;
            this.btn_ShowPW.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_ShowPW_MouseClick);
            // 
            // btn_SginUp
            // 
            this.btn_SginUp.Location = new System.Drawing.Point(503, 123);
            this.btn_SginUp.Name = "btn_SginUp";
            this.btn_SginUp.Size = new System.Drawing.Size(75, 32);
            this.btn_SginUp.TabIndex = 5;
            this.btn_SginUp.Text = "Đăng Ký";
            this.btn_SginUp.UseVisualStyleBackColor = true;
            this.btn_SginUp.Click += new System.EventHandler(this.btn_SginUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManageShop.Properties.Resources.login_imagé;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 455);
            this.Controls.Add(this.btn_SginUp);
            this.Controls.Add(this.btn_ShowPW);
            this.Controls.Add(this.login_DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_USer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_USer;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView login_DataGridView;
        private System.Windows.Forms.Button btn_ShowPW;
        private System.Windows.Forms.Button btn_SginUp;
    }
}