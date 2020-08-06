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
    public partial class History : Form
    {
        string connectPath = @"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True";
        SqlConnection sqlConnect;
        SqlDataAdapter sqlDaSelling;
        DataTable sellingTable;
        Thread th;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connectPath);
            sqlDaSelling = new SqlDataAdapter("Select MaPhieu as 'Mã Phiếu', FoodName as 'Tên Món Ăn', SLFood as 'Số Lượng Món Ăn', DrinkName as 'Tên Đồ Uống', SLDrink as 'Số Lượng Đồ Uống', TongTien as 'Tổng Tiền(VND)' From SellingInfo", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            customerDataGridView.DataSource = sellingTable;
        }


        private void cbBox_Title_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_Title.Text == "Mã Phiếu")
            {
                cbBox_Sons.Visible = true;
                cbBox_Sons2.Visible = false;
                cbBox_Sons3.Visible = false;
                sqlConnect.Open();
                string truyVanMaPhieu = "Select MaPhieu From SellingInfo";
                SqlCommand maPhieuCmd = new SqlCommand(truyVanMaPhieu, sqlConnect);
                SqlDataAdapter maPhieuDA = new SqlDataAdapter(truyVanMaPhieu, sqlConnect);
                DataSet maPhieuDS = new DataSet();
                maPhieuDA.Fill(maPhieuDS);
                maPhieuCmd.ExecuteNonQuery();
                sqlConnect.Close();

                cbBox_Sons.ValueMember = "MaPhieu";
                cbBox_Sons.DisplayMember = "MaPhieu";
                cbBox_Sons.DataSource = maPhieuDS.Tables[0];
            }
            else if(cbBox_Title.Text == "Tên Món Ăn")
            {
                cbBox_Sons.Visible = false;
                cbBox_Sons2.Visible = true;
                cbBox_Sons3.Visible = false;
                sqlConnect.Open();
                string truyVanFood = "Select FoodName From SellingInfo";
                SqlCommand foodCommand = new SqlCommand(truyVanFood, sqlConnect);
                SqlDataAdapter foodDa = new SqlDataAdapter(truyVanFood, sqlConnect);
                DataSet foodDS = new DataSet();
                foodDa.Fill(foodDS);
                foodCommand.ExecuteNonQuery();
                sqlConnect.Close();

                cbBox_Sons2.ValueMember = "FoodName";
                cbBox_Sons2.DisplayMember = "FoodName";
                cbBox_Sons2.DataSource = foodDS.Tables[0];
            }
            else if(cbBox_Title.Text == "Tên Đồ Uống")
            {
                cbBox_Sons.Visible = false;
                cbBox_Sons2.Visible = false;
                cbBox_Sons3.Visible = true;
                sqlConnect.Open();
                string truyVanDrik = "Select DrinkName From SellingInfo";
                SqlCommand drinkCmd = new SqlCommand(truyVanDrik, sqlConnect);
                SqlDataAdapter drinkDA = new SqlDataAdapter(truyVanDrik, sqlConnect);
                DataSet drinkDS = new DataSet();
                drinkDA.Fill(drinkDS);
                drinkCmd.ExecuteNonQuery();
                sqlConnect.Close();

                cbBox_Sons3.ValueMember = "DrinkName";
                cbBox_Sons3.DisplayMember = "DrinkName";
                cbBox_Sons3.DataSource = drinkDS.Tables[0];
            }
        }

        private void cbBox_Sons_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connectPath);
            sqlDaSelling = new SqlDataAdapter("Select MaPhieu as 'Mã Phiếu', FoodName as 'Tên Món Ăn', SLFood as 'Số Lượng Món Ăn', DrinkName as 'Tên Đồ Uống', SLDrink as 'Số Lượng Đồ Uống', TongTien as 'Tổng Tiền(VND)' From SellingInfo Where MaPhieu = '" + cbBox_Sons.Text + "'", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            customerDataGridView.DataSource = sellingTable;
        }

        private void cbBox_Sons2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connectPath);
            sqlDaSelling = new SqlDataAdapter("Select MaPhieu as 'Mã Phiếu', FoodName as 'Tên Món Ăn', SLFood as 'Số Lượng Món Ăn', DrinkName as 'Tên Đồ Uống', SLDrink as 'Số Lượng Đồ Uống', TongTien as 'Tổng Tiền(VND)' From SellingInfo Where FoodName = '" + cbBox_Sons2.Text + "'", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            customerDataGridView.DataSource = sellingTable;
        }

        private void cbBox_Sons3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connectPath);
            sqlDaSelling = new SqlDataAdapter("Select MaPhieu as 'Mã Phiếu', FoodName as 'Tên Món Ăn', SLFood as 'Số Lượng Món Ăn', DrinkName as 'Tên Đồ Uống', SLDrink as 'Số Lượng Đồ Uống', TongTien as 'Tổng Tiền(VND)' From SellingInfo Where DrinkName = '" + cbBox_Sons3.Text + "'", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            customerDataGridView.DataSource = sellingTable;
        }

        private void menuStrip_Refresh_Click(object sender, EventArgs e)
        {
            cbBox_Title.Text = "";
            sqlConnect = new SqlConnection(connectPath);
            sqlDaSelling = new SqlDataAdapter("Select MaPhieu as 'Mã Phiếu', FoodName as 'Tên Món Ăn', SLFood as 'Số Lượng Món Ăn', DrinkName as 'Tên Đồ Uống', SLDrink as 'Số Lượng Đồ Uống', TongTien as 'Tổng Tiền(VND)' From SellingInfo", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            customerDataGridView.DataSource = sellingTable;
        }

        private void menuStrip_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void menuStrip_MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainMenuFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void menuStrip_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMenuFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void menuStrip_Selling_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSellingFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMenuFrom(object obj)
        {
            Application.Run(new FoodMenu());
        }
        private void openLoginFrom(object obj)
        {
            Application.Run(new Login());
        }
        private void openSellingFrom(object obj)
        {
            Application.Run(new Selling());
        }
        private void openMainMenuFrom(object obj)
        {
            Application.Run(new MainMenu());
        }
        private void txt_MaPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
