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
    public partial class Selling : Form
    {
        string connectPath = @"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True";
        SqlConnection sqlConnect;
        SqlDataAdapter sqlDaFood, sqlDaDrink, sqlDaSelling;
        SqlCommand cmd;
        DataTable foodTable, drinkTable, sellingTable;
        DataGridViewRow dGrFood, dGrDrink, dGrCustomer;
        int foodRows, drinkRows, customerRows;
        int tienFood, tienDrink, TongTien;

        Thread th;

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

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Reportfrm Rp;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txt_MaPhieu.Text.ToString().Trim() == "")
                return;
            if (Rp == null || Rp.IsDisposed)
            {
                Rp = new Reportfrm(txt_MaPhieu.Text.ToString());
                Rp.MdiParent = this.MdiParent;
                
                Rp.Show();
            }
            else
            {
                Rp.Activate();
            }
            
        }

        private void menuStrip_History_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHistoryFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void menuStrip_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < foodRows; i++)
            {
                dGrFood = foodDataGridView.Rows[i];
                if (cbo_MonAn.Text == dGrFood.Cells["Tên Món Ăn"].Value.ToString())
                {
                    tienFood = Convert.ToInt32(dGrFood.Cells["Giá(VND)"].Value.ToString()) * Convert.ToInt32(num_MonAn.Value.ToString());
                }
            }
            for (int i = 0; i < drinkRows; i++)
            {
                dGrDrink = drinkDataGridView.Rows[i];
                if (cbo_ThucUong.Text == dGrDrink.Cells["Tên Đồ Uống"].Value.ToString())
                {
                    tienDrink = Convert.ToInt32(dGrDrink.Cells["Giá(VND)"].Value.ToString()) * Convert.ToInt32(num_ThucUong.Value.ToString());
                }
            }
            TongTien = tienDrink + tienFood;
            if(Convert.ToInt32(num_MonAn.Value.ToString()) > 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) > 0)
            {
                //Hien Label Food
                lbl_MonAn.Text = cbo_MonAn.Text;
                lbl_FooDSL.Text = num_MonAn.Value.ToString();
                lbl_TienFood.Text = tienFood.ToString() + " VND";

                //Hien Label Drink
                lbl_DoUong.Text = cbo_ThucUong.Text;
                lbl_DrinkSL.Text = num_ThucUong.Value.ToString();
                lbl_TienDrink.Text = tienDrink.ToString() + " VND";

            }
            else if(Convert.ToInt32(num_MonAn.Value.ToString()) > 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) == 0)
            {
                //Hien Label Food
                lbl_MonAn.Text = cbo_MonAn.Text;
                lbl_FooDSL.Text = num_MonAn.Value.ToString();
                lbl_TienFood.Text = tienFood.ToString() + " VND";

                //Hien Label Drink
                lbl_DoUong.Text = "";
                lbl_DrinkSL.Text = "";
                lbl_TienDrink.Text = "";
            }
            else if(Convert.ToInt32(num_MonAn.Value.ToString()) == 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) > 0)
            {
                //Hien Label Food
                lbl_MonAn.Text = "";
                lbl_FooDSL.Text = "";
                lbl_TienFood.Text = "";

                //Hien Label Drink
                lbl_DoUong.Text = cbo_ThucUong.Text;
                lbl_DrinkSL.Text = num_ThucUong.Value.ToString();
                lbl_TienDrink.Text = tienDrink.ToString() + " VND";
            }
            else if(Convert.ToInt32(num_MonAn.Value.ToString()) == 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) == 0)
            {
                //Label
                lbl_TongTien.Text = "";
                lbl_MonAn.Text = "";
                lbl_FooDSL.Text = "";
                lbl_TienFood.Text = "";
                lbl_DoUong.Text = "";
                lbl_DrinkSL.Text = "";
                lbl_TienDrink.Text = "";
                TongTien = 0;
            }
            //Hien Labal Tong Tien
            lbl_TongTien.Text = TongTien.ToString() + " VND";
        }

        
        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            bool isSimiliar = false;
            for(int i = 0; i < customerRows; i++)
            {
                dGrCustomer = sellingDataGridView.Rows[i];
                if(txt_MaPhieu.Text == dGrCustomer.Cells["MaPhieu"].Value.ToString())
                {
                    isSimiliar = true;
                    MessageBox.Show("Không thể thanh toán vì trùng Mã Phiếu:  " + txt_MaPhieu.Text);
                }
            }
            if(isSimiliar == false && TongTien > 0 && txt_MaPhieu.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Đồng Ý Thanh Toán", "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    if (Convert.ToInt32(num_MonAn.Value.ToString()) > 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) > 0)
                    {
                        DataRow dr = sellingTable.NewRow();
                        string truyVan = string.Format("Insert into SellingInfo(MaPhieu, FoodName, SLFood, DrinkName, SLDrink, TongTien) values (@MaPhieu, @FoodName, @SLFood, @DrinkName, @SLDrink, @TongTien)", sqlConnect);
                        cmd = new SqlCommand(truyVan, sqlConnect);

                        cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
                        cmd.Parameters.Add("@FoodName", SqlDbType.NVarChar, 50, "FoodName");
                        cmd.Parameters.Add("@SLFood", SqlDbType.Int, 10, "SLFood");
                        cmd.Parameters.Add("@DrinkName", SqlDbType.NVarChar, 50, "DrinkName");
                        cmd.Parameters.Add("@SLDrink", SqlDbType.Int, 10, "SLDrink");
                        cmd.Parameters.Add("@TongTien", SqlDbType.Int, 10, "TongTien");

                        dr[0] = txt_MaPhieu.Text;
                        dr[1] = cbo_MonAn.Text;
                        dr[2] = num_MonAn.Value.ToString();
                        dr[3] = cbo_ThucUong.Text;
                        dr[4] = num_ThucUong.Value.ToString();
                        dr[5] = TongTien.ToString();
                        sellingTable.Rows.Add(dr);

                        sqlDaSelling.InsertCommand = cmd;
                        sqlDaSelling.Update(sellingTable);
                    }
                    else if (Convert.ToInt32(num_MonAn.Value.ToString()) > 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) == 0)
                    {
                        DataRow dr = sellingTable.NewRow();
                        string truyVan = string.Format("Insert into SellingInfo(MaPhieu, FoodName, SLFood, DrinkName, SLDrink, TongTien) values (@MaPhieu, @FoodName, @SLFood, @DrinkName, @SLDrink, @TongTien)", sqlConnect);
                        cmd = new SqlCommand(truyVan, sqlConnect);

                        cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
                        cmd.Parameters.Add("@FoodName", SqlDbType.NVarChar, 50, "FoodName");
                        cmd.Parameters.Add("@SLFood", SqlDbType.Int, 10, "SLFood");
                        cmd.Parameters.Add("@DrinkName", SqlDbType.NVarChar, 50, "DrinkName");
                        cmd.Parameters.Add("@SLDrink", SqlDbType.Int, 10, "SLDrink");
                        cmd.Parameters.Add("@TongTien", SqlDbType.Int, 10, "TongTien");

                        dr[0] = txt_MaPhieu.Text;
                        dr[1] = cbo_MonAn.Text;
                        dr[2] = num_MonAn.Value.ToString();
                        dr[3] = "Không";
                        dr[4] = num_ThucUong.Value.ToString();
                        dr[5] = TongTien.ToString();
                        sellingTable.Rows.Add(dr);

                        sqlDaSelling.InsertCommand = cmd;
                        sqlDaSelling.Update(sellingTable);
                    }
                    else if (Convert.ToInt32(num_MonAn.Value.ToString()) == 0 && Convert.ToInt32(num_ThucUong.Value.ToString()) > 0)
                    {
                        DataRow dr = sellingTable.NewRow();
                        string truyVan = string.Format("Insert into SellingInfo(MaPhieu, FoodName, SLFood, DrinkName, SLDrink, TongTien) values (@MaPhieu, @FoodName, @SLFood, @DrinkName, @SLDrink, @TongTien)", sqlConnect);
                        cmd = new SqlCommand(truyVan, sqlConnect);

                        cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar, 50, "MaPhieu");
                        cmd.Parameters.Add("@FoodName", SqlDbType.NVarChar, 50, "FoodName");
                        cmd.Parameters.Add("@SLFood", SqlDbType.Int, 10, "SLFood");
                        cmd.Parameters.Add("@DrinkName", SqlDbType.NVarChar, 50, "DrinkName");
                        cmd.Parameters.Add("@SLDrink", SqlDbType.Int, 10, "SLDrink");
                        cmd.Parameters.Add("@TongTien", SqlDbType.Int, 10, "TongTien");

                        dr[0] = txt_MaPhieu.Text;
                        dr[1] = "Không";
                        dr[2] = num_MonAn.Value.ToString();
                        dr[3] = cbo_ThucUong.Text;
                        dr[4] = num_ThucUong.Value.ToString();
                        dr[5] = TongTien.ToString();
                        sellingTable.Rows.Add(dr);

                        sqlDaSelling.InsertCommand = cmd;
                        sqlDaSelling.Update(sellingTable);
                    }
                }
            }
            if(isSimiliar == false && TongTien == 0)
            {
                MessageBox.Show("Vui lòng chọn món");
            }
            if(isSimiliar == false && txt_MaPhieu.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã Phiếu");
            }
            txt_MaPhieu.Text = "";
            
        }

        public Selling()
        {
            InitializeComponent();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            //Food va Drink DataGridView
            sqlConnect = new SqlConnection(connectPath);
            sqlDaFood = new SqlDataAdapter("Select FoodName as 'Tên Món Ăn', DonGia as 'Giá(VND)' From FoodInfo", sqlConnect);
            sqlDaDrink = new SqlDataAdapter("Select DrinkName as 'Tên Đồ Uống', DonGia as 'Giá(VND)' From DrinkInfo", sqlConnect);

            foodTable = new DataTable("FoodInfo");
            drinkTable = new DataTable("DrinkInfo");

            sqlDaFood.Fill(foodTable);
            sqlDaDrink.Fill(drinkTable);

            foodDataGridView.DataSource = foodTable;
            drinkDataGridView.DataSource = drinkTable;

            //Ban Hang
            sqlDaSelling = new SqlDataAdapter(" Select  * From SellingInfo", sqlConnect);
            sellingTable = new DataTable("SellingInfo");
            sqlDaSelling.Fill(sellingTable);
            sellingDataGridView.DataSource = sellingTable;

            //Combo box Mon An
            sqlConnect.Open();
            string truyVanFood = "Select FoodName From FoodInfo";
            SqlCommand foodCommand = new SqlCommand(truyVanFood, sqlConnect);
            SqlDataAdapter foodDa = new SqlDataAdapter(truyVanFood, sqlConnect);
            DataSet foodDS = new DataSet();
            foodDa.Fill(foodDS);
            foodCommand.ExecuteNonQuery();
            sqlConnect.Close();

            cbo_MonAn.DisplayMember = "FoodName";
            cbo_MonAn.ValueMember = "FoodName";
            cbo_MonAn.DataSource = foodDS.Tables[0];

            //Combo box Do Uong
            sqlConnect.Open();
            string truyVanDrik = "Select DrinkName From DrinkInfo";
            SqlCommand drinkCmd = new SqlCommand(truyVanDrik, sqlConnect);
            SqlDataAdapter drinkDA = new SqlDataAdapter(truyVanDrik, sqlConnect);
            DataSet drinkDS = new DataSet();
            drinkDA.Fill(drinkDS);
            drinkCmd.ExecuteNonQuery();
            sqlConnect.Close();

            cbo_ThucUong.DisplayMember = "DrinkName";
            cbo_ThucUong.ValueMember = "DrinkName";
            cbo_ThucUong.DataSource = drinkDS.Tables[0];

            //FoodRows, Drink, Customer Rows
            foodRows = foodDataGridView.Rows.Count - 1;
            drinkRows = drinkDataGridView.Rows.Count - 1;
            customerRows = sellingDataGridView.Rows.Count - 1;
        }

        private void openMainMenuFrom(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void openMenuFrom(object obj)
        {
            Application.Run(new FoodMenu());
        }
        private void openLoginFrom(object obj)
        {
            Application.Run(new Login());
        }
        private void openHistoryFrom(object obj)
        {
            Application.Run(new History());
        }

    }
}
