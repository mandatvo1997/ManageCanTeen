using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ManageShop
{
    public partial class MainMenu : Form
    {
        Thread th;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát Chương Trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_FoodMenu_DouubleClick(object sender, EventArgs e)
        {
            
        }

        private void btn_FoodMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFoodMenuFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFoodMenuFrom(object obj)
        {
            Application.Run(new FoodMenu());
        }

        private void openSellingFrom(object obj)
        {
            Application.Run(new Selling());
        }
        private void openHistoryFrom(object obj)
        {
            Application.Run(new History());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openSellingFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openHistoryFrom);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
