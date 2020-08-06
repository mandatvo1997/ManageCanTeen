using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace ManageShop
{
    public partial class Login : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sqlDa;
        DataTable table;
        DataGridViewRow dGr;
        Thread th;
        int rows;
        bool isShowPW;
        string connect = @"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Login_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(connect);
            sqlDa = new SqlDataAdapter("Select * From LoginInfo", sqlCon);
            table = new DataTable("LoginInfo");
            sqlDa.Fill(table);
            login_DataGridView.DataSource = table;
            rows = login_DataGridView.Rows.Count - 1;
            isShowPW = false;

            txt_PW.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isLogin = false;
            for(int i = 0;  i < rows; i++)
            {
                dGr = login_DataGridView.Rows[i];
                if(txt_USer.Text == dGr.Cells["ID"].Value.ToString() && txt_PW.Text == dGr.Cells["Password"].Value.ToString())
                {
                    isLogin = true;
                }
            }
            if (isLogin == true)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
                th = new Thread(openMainMenuFrom);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else if(isLogin == false)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

        }

        private void txt_PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(13))
            {
                bool isLogin = false;
                for (int i = 0; i < rows; i++)
                {
                    dGr = login_DataGridView.Rows[i];
                    if (txt_USer.Text == dGr.Cells["ID"].Value.ToString() && txt_PW.Text == dGr.Cells["Password"].Value.ToString())
                    {
                        isLogin = true;
                    }
                }
                if (isLogin == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                    th = new Thread(openMainMenuFrom);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (isLogin == false)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void openMainMenuFrom(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void btn_ShowPW_MouseClick(object sender, MouseEventArgs e)
        {
            if(isShowPW == false)
            {
                txt_PW.PasswordChar = '\0';
                isShowPW = true;
            }
            else if(isShowPW == true)
            {
                txt_PW.PasswordChar = '*';
                isShowPW = false;
            }
        }

        private void btn_SginUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void txt_USer_TextChanged(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(connect);
            sqlDa = new SqlDataAdapter("Select * From LoginInfo", sqlCon);
            table = new DataTable("LoginInfo");
            sqlDa.Fill(table);
            login_DataGridView.DataSource = table;
            rows = login_DataGridView.Rows.Count - 1;
        }
    }
}
