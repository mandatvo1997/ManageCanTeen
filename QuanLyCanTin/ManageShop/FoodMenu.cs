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
    public partial class FoodMenu : Form
    {
        string connetPath = @"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True";
        SqlConnection sqlConnect;
        SqlDataAdapter sqlDaFood, sqlDaDrink;
        DataTable foodTable, drinkTable;
        SqlCommand cmd;
        DataGridViewRow dGrFood, dGrDrink;
        int foodRowIndex, drinkRowIndex;
        string donGiaFood, donGiaDrink, nameFood, nameDrink;
        int foodRows, drinkRow;

        Thread th;

        private void btn_themFood_Click(object sender, EventArgs e)
        {
            int i;
            bool isSimilar = false;
            for (i = 0; i < foodRows; i++)
            {
                dGrFood = foodDataGridView.Rows[i];
                if (txt_FoodID.Text == dGrFood.Cells["FoodID"].Value.ToString())
                {
                    isSimilar = true;
                    MessageBox.Show("Không thể thêm vì trùng FoodID " + txt_FoodID.Text);
                }
            }
            if (isSimilar == false)
            {
                DataRow dR = foodTable.NewRow();
                string truyVan = string.Format("Insert into FoodInfo(FoodID, FoodName, DonGia) values (@FoodID, @FoodName, @DonGia)", sqlConnect);
                cmd = new SqlCommand(truyVan, sqlConnect);

                cmd.Parameters.Add("@FoodID", SqlDbType.NVarChar, 50, "FoodID");
                cmd.Parameters.Add("@FoodName", SqlDbType.NVarChar, 50, "FoodName");
                cmd.Parameters.Add("@DonGia", SqlDbType.Int, 32, "DonGia");

                dR["FoodID"] = txt_FoodID.Text;
                dR["FoodName"] = txt_FoodName.Text;
                dR["DonGia"] = txt_FoodDonGia.Text;
                foodTable.Rows.Add(dR);

                sqlDaFood.InsertCommand = cmd;
                sqlDaFood.Update(foodTable);

                txt_FoodID.Text = "";
                txt_FoodName.Text = "";
                txt_FoodDonGia.Text = "";
            }
        }

        //Them Drink
        private void btn_themDrink_Click(object sender, EventArgs e)
        {
            int i;
            bool isSimilar = false;
            for (i = 0; i < drinkRow; i++)
            {
                dGrDrink = drinkDataGridView.Rows[i];
                if (txt_DrinkID.Text == dGrDrink.Cells["DrinkID"].Value.ToString())
                {
                    isSimilar = true;
                    MessageBox.Show("Không thể thêm vì trùng DrinkID " + txt_DrinkID.Text);
                }
            }
            if (isSimilar == false)
            {
                DataRow dR = drinkTable.NewRow();
                string truyVan = string.Format("Insert into DrinkInfo(DrinkID, DrinkName, DonGia) values (@DrinkID, @DrinkName, @DonGia)", sqlConnect);
                cmd = new SqlCommand(truyVan, sqlConnect);

                cmd.Parameters.Add("@DrinkID", SqlDbType.NVarChar, 50, "DrinkID");
                cmd.Parameters.Add("@DrinkName", SqlDbType.NVarChar, 50, "DrinkName");
                cmd.Parameters.Add("@DonGia", SqlDbType.Int, 32, "DonGia");

                dR["DrinkID"] = txt_DrinkID.Text;
                dR["DrinkName"] = txt_DrinkName.Text;
                dR["DonGia"] = txt_DrinkDonGia.Text;
                drinkTable.Rows.Add(dR);

                sqlDaDrink.InsertCommand = cmd;
                sqlDaDrink.Update(drinkTable);

                txt_DrinkID.Text = "";
                txt_DrinkName.Text = "";
                txt_DrinkDonGia.Text = "";

            }
        }

        //Xoa Food
        private void btn_foodXoa_Click(object sender, EventArgs e)
        {
            int i;
            bool isSimilar = false;
            for (i = 0; i < foodRows; i++)
            {
                dGrFood = foodDataGridView.Rows[i];
                if (txt_FoodID.Text == dGrFood.Cells["FoodID"].Value.ToString())
                {
                    isSimilar = true;
                }
            }
            if (isSimilar == true)
            {
                for (i = 0; i < foodRows; i++)
                {
                    dGrFood = foodDataGridView.Rows[i];
                    if (txt_FoodID.Text == dGrFood.Cells["FoodID"].Value.ToString())
                    {
                        foodRowIndex = foodDataGridView.Rows[i].Index;
                    }
                }
                sqlConnect.Open();
                cmd = new SqlCommand("Delete FROM FoodInfo Where FoodID = '" + txt_FoodID.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                foodTable.Rows[foodRowIndex].Delete();
                sqlConnect.Close();
            }

            else if (isSimilar == false)
            {
                MessageBox.Show("Không Tìm Thấy ID: " + txt_FoodID.Text.ToString());
            }
            txt_FoodID.Text = "";
            txt_FoodName.Text = "";
            txt_FoodDonGia.Text = "";

        }

        private void btn_DrinkXoa_Click(object sender, EventArgs e)
        {
            int i;
            bool isSimilar = false;
            for (i = 0; i < drinkRow; i++)
            {
                dGrDrink = drinkDataGridView.Rows[i];
                if (txt_DrinkID.Text == dGrDrink.Cells["DrinkID"].Value.ToString())
                {
                    isSimilar = true;
                }
            }
            if (isSimilar == true)
            {
                for (i = 0; i < drinkRow; i++)
                {
                    dGrDrink = drinkDataGridView.Rows[i];
                    if (txt_DrinkID.Text == dGrDrink.Cells["DrinkID"].Value.ToString())
                    {
                        drinkRowIndex = drinkDataGridView.Rows[i].Index;
                    }
                }
                sqlConnect.Open();
                cmd = new SqlCommand("Delete FROM DrinkInfo Where DrinkID = '" + txt_DrinkID.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                drinkTable.Rows[drinkRowIndex].Delete();
                sqlConnect.Close();
            }
            else if (isSimilar == false)
            {
                MessageBox.Show("Không Tìm Thấy ID: " + txt_DrinkID.Text.ToString());
            }
            txt_DrinkID.Text = "";
            txt_DrinkName.Text = "";
            txt_DrinkDonGia.Text = "";

        }

        //Click hien len textbox Food
        private void foodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGrFood = foodDataGridView.SelectedRows[0];
            txt_FoodID.Text = dGrFood.Cells["FoodID"].Value.ToString();
            txt_FoodName.Text = dGrFood.Cells["FoodName"].Value.ToString();
            txt_FoodDonGia.Text = dGrFood.Cells["DonGia"].Value.ToString();


            //Sửa
            donGiaFood = dGrFood.Cells["DonGia"].Value.ToString();
            nameFood = dGrFood.Cells["FoodName"].Value.ToString();
        }

        //Click hien len textbox Drink
        private void drinkDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGrDrink = drinkDataGridView.SelectedRows[0];
            txt_DrinkID.Text = dGrDrink.Cells["DrinkID"].Value.ToString();
            txt_DrinkName.Text = dGrDrink.Cells["DrinkName"].Value.ToString();
            txt_DrinkDonGia.Text = dGrDrink.Cells["DonGia"].Value.ToString();


            //Sửa
            donGiaDrink = dGrDrink.Cells["DonGia"].Value.ToString();
            nameDrink = dGrDrink.Cells["DrinkName"].Value.ToString();
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Food Btn

            //Btn Them
            if (txt_FoodID.Text.Length == 0 ||
                txt_FoodName.Text.Length == 0 ||
                txt_FoodDonGia.Text.Length == 0)
            {
                btn_themFood.Enabled = false;
            }
            else if (txt_FoodID.Text.Length > 0 &&
                txt_FoodName.Text.Length > 0 &&
                txt_FoodDonGia.Text.Length > 0)
            {
                btn_themFood.Enabled = true;
            }

            //Btn Xoa
            if (txt_FoodID.Text.Length == 0)
            {
                btn_foodXoa.Enabled = false;
            }
            else if (txt_FoodID.Text.Length > 0)
            {
                btn_foodXoa.Enabled = true;
            }

            //Btn Edit
            if ((txt_FoodDonGia.Text != donGiaFood || txt_FoodName.Text != nameFood) && txt_FoodDonGia.Text.Length > 0 && txt_FoodName.Text.Length > 0)
            {
                btn_FoodEdit.Enabled = true;
            }
            else if (txt_FoodDonGia.Text == donGiaFood ||
                txt_FoodDonGia.Text.Length == 0)
            {
                btn_FoodEdit.Enabled = false;
            }
            else if (txt_FoodName.Text == nameFood || txt_FoodName.Text.Length == 0)
            {
                btn_FoodEdit.Enabled = false;
            }

            //Drink Btn

            //Btn Them
            if (txt_DrinkID.Text.Length == 0 ||
                txt_DrinkName.Text.Length == 0 ||
                txt_DrinkDonGia.Text.Length == 0)
            {
                btn_themDrink.Enabled = false;
            }
            else if (txt_DrinkID.Text.Length > 0 &&
                txt_DrinkName.Text.Length > 0 &&
                txt_DrinkDonGia.Text.Length > 0)
            {
                btn_themDrink.Enabled = true;
            }

            //Btn Xoa
            if (txt_DrinkID.Text.Length == 0)
            {
                btn_DrinkXoa.Enabled = false;
            }
            else if (txt_DrinkID.Text.Length > 0)
            {
                btn_DrinkXoa.Enabled = true;
            }

            //Btn Sua
            if ((txt_DrinkDonGia.Text != donGiaDrink || txt_DrinkName.Text != nameDrink) && txt_DrinkDonGia.Text.Length > 0 && txt_DrinkName.Text.Length > 0)
            {
                btn_DrinkEdit.Enabled = true;
            }
            else if (txt_DrinkDonGia.Text == donGiaDrink || txt_DrinkDonGia.Text.Length == 0)
            {
                btn_DrinkEdit.Enabled = false;
            }
            else if (txt_DrinkName.Text == nameDrink || txt_DrinkName.Text.Length == 0)
            {
                btn_DrinkEdit.Enabled = false;
            }


        }

        private void menuStrip_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLoginFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void menuStirp_MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainMenuFrom);
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

        private void menuStrip_History_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHistoryFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainMenuFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_FoodNew_Click(object sender, EventArgs e)
        {
            txt_FoodID.Text = "";
            txt_FoodName.Text = "";
            txt_FoodDonGia.Text = "";
            btn_FoodEdit.Enabled = false;
        }

        private void btn_DrinkNew_Click(object sender, EventArgs e)
        {
            txt_DrinkID.Text = "";
            txt_DrinkName.Text = "";
            txt_DrinkDonGia.Text = "";
            btn_DrinkEdit.Enabled = false;
        }

        private void txt_FoodID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_FoodDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_DrinkDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connetPath);
            sqlDaFood = new SqlDataAdapter("Select * From FoodInfo", sqlConnect);
            sqlDaDrink = new SqlDataAdapter("Select * From DrinkInfo", sqlConnect);

            foodTable = new DataTable("FoodInfo");
            drinkTable = new DataTable("DrinkInfo");

            sqlDaFood.Fill(foodTable);
            sqlDaDrink.Fill(drinkTable);

            foodDataGridView.DataSource = foodTable;
            drinkDataGridView.DataSource = drinkTable;
        }

        private void btn_DrinkEdit_Click(object sender, EventArgs e)
        {
            if (txt_DrinkDonGia.Text != donGiaDrink)
            {
                sqlConnect.Open();
                cmd = new SqlCommand("Update DrinkInfo Set DonGia = '" + txt_DrinkDonGia.Text + "'" + "Where DrinkId = '" + txt_DrinkID.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                dGrDrink.Cells["DonGia"].Value = txt_DrinkDonGia.Text;
                drinkTable.AcceptChanges();
                sqlConnect.Close();
            }
            if (txt_DrinkName.Text != nameDrink)
            {
                sqlConnect.Open();
                cmd = new SqlCommand("Update DrinkInfo Set DrinkName = '" + txt_DrinkName.Text + "'" + "Where DrinkId = '" + txt_DrinkID.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                dGrDrink.Cells["DrinkName"].Value = txt_DrinkName.Text;
                drinkTable.AcceptChanges();
                sqlConnect.Close();
            }
            btn_DrinkEdit.Enabled = false;
        }

        private void btn_FoodEdit_Click(object sender, EventArgs e)
        {
            if (txt_FoodDonGia.Text != donGiaFood)
            {
                sqlConnect.Open();
                cmd = new SqlCommand("Update FoodInfo Set DonGia ='" + txt_FoodDonGia.Text + "'" + "Where FoodID = '" + txt_FoodID.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                dGrFood.Cells["DonGia"].Value = txt_FoodDonGia.Text;
                foodTable.AcceptChanges();
                sqlConnect.Close();
            }
            if (txt_FoodName.Text != nameFood)
            {
                sqlConnect.Open();
                cmd = new SqlCommand("Update FoodInfo Set FoodName = '" + txt_FoodName.Text + "'" + "Where FoodID = '" + txt_FoodName.Text + "'", sqlConnect);
                cmd.ExecuteNonQuery();
                dGrFood.Cells["FoodName"].Value = txt_FoodName.Text;
                foodTable.AcceptChanges();
                sqlConnect.Close();
            }
            btn_FoodEdit.Enabled = false;
        }

        public FoodMenu()
        {
            InitializeComponent();
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connetPath);
            sqlDaFood = new SqlDataAdapter("Select * From FoodInfo", sqlConnect);
            sqlDaDrink = new SqlDataAdapter("Select * From DrinkInfo", sqlConnect);

            foodTable = new DataTable("FoodInfo");
            drinkTable = new DataTable("DrinkInfo");

            sqlDaFood.Fill(foodTable);
            sqlDaDrink.Fill(drinkTable);

            foodDataGridView.DataSource = foodTable;
            drinkDataGridView.DataSource = drinkTable;

            btn_DrinkEdit.Enabled = false;
            btn_FoodEdit.Enabled = false;

            foodRows = foodDataGridView.Rows.Count - 1;
            drinkRow = drinkDataGridView.Rows.Count - 1;
        }

        private void openMainMenuFrom(object obj)
        {
            Application.Run(new MainMenu());
        }
        private void openLoginFrom(object obj)
        {
            Application.Run(new Login());
        }
        private void openHistoryFrom(object obj)
        {
            Application.Run(new History());
        }
        private void openSellingFrom(object obj)
        {
            Application.Run(new Selling());
        }
    }
}
