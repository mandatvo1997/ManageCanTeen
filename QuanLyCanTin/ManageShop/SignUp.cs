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
    public partial class SignUp : Form
    {
        string connetPath = @"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=TrueData Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True";
        SqlConnection sqlConnect;
        SqlDataAdapter sqlDa;
        DataTable table;
        SqlCommand cmd;
        DataGridViewRow dGr;
        int rows;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            bool isSimiliar = false;
            bool canSignUp = true;
            if(txt_PW.Text != txt_PW2.Text)
            {
                canSignUp = false;
            }
            for (int i = 0; i < rows; i++)
            {
                dGr = dataGridView1.Rows[i];
                if (txt_ID.Text == dGr.Cells["ID"].Value.ToString())
                {
                    isSimiliar = true;
                }
            }
            if(isSimiliar == false && canSignUp == true)
            {
                sqlConnect.Open();
                cmd = new SqlCommand("Insert into LoginInfo(ID, Password) values('" + txt_ID.Text + "', '" + txt_PW.Text + "')", sqlConnect);
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                Login login = new Login();
                login.Login_Load(sender, e);
                MessageBox.Show("Đăng Ký Thành Công");
                this.Close();
            }
            if(isSimiliar == true)
            {
                MessageBox.Show("ID: " + txt_ID.Text + " đã có người sử dụng");
            }
            if(canSignUp == false)
            {
                MessageBox.Show("Nhập Lại Mật Khẩu Không Đúng");
            }
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connetPath);
            sqlDa = new SqlDataAdapter("Select * From LoginInfo", sqlConnect);
            table = new DataTable("LoginInfo");
            sqlDa.Fill(table);
            dataGridView1.DataSource = table;
            rows = dataGridView1.Rows.Count - 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txt_ID.Text.Length > 0 && txt_PW.Text.Length >0 && txt_PW2.Text.Length > 0 )
            {
                btn_SignUp.Enabled = true;
            }
            else
            {
                btn_SignUp.Enabled = false;
            }
        }
    }
}
