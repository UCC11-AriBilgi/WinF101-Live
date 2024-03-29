﻿
using Microsoft.Data.SqlClient;

namespace ADONet
{

    public partial class frmMain : Form
    {
        static string vs_ConnStr = "Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        // Tanýma göre bağlanmak için gerekli talimatlarý aldý
        SqlConnection connection = new SqlConnection(vs_ConnStr);


        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Close();
                MessageBox.Show("Bağlantý kapandý");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }



        private void Connect(object sender, EventArgs e)
        {
            // Bir DBye bağlanabilmek için iki þeye ihtiyacým var
            // 1. ConnectionString dediğimiz bir string değer
            // 2. Bunu anlayacak bir kütüphaneye ihtiyaç

            //// Tanýma göre bağlanmak için gerekli talimatlarý aldý


            try
            {
                connection.Open(); // bağlantıyı aç..

                MessageBox.Show("VT bağlantısı açıldı...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT bağlantısında problem var...");
                MessageBox.Show(ex.Message);

            }

            connection.Close();
        }

        private void GetEmployeeForm(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();

            frmEmployees.ShowDialog();
        }

        private void GetCustomersForm(object sender, EventArgs e)
        {
            frmCustomers frmCustomers= new frmCustomers();

            frmCustomers.ShowDialog();
        }
    }
}
