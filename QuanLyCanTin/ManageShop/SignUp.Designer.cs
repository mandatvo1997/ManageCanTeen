namespace ManageShop
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PW2 = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(107, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(107, 43);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PasswordChar = '*';
            this.txt_PW.Size = new System.Drawing.Size(100, 22);
            this.txt_PW.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại MK";
            // 
            // txt_PW2
            // 
            this.txt_PW2.Location = new System.Drawing.Point(107, 74);
            this.txt_PW2.Name = "txt_PW2";
            this.txt_PW2.PasswordChar = '*';
            this.txt_PW2.Size = new System.Drawing.Size(100, 22);
            this.txt_PW2.TabIndex = 2;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(230, 40);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 29);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "Đăng Ký";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(26, 23);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 114);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txt_PW2);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PW2;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}