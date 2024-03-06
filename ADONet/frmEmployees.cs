using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONet
{
    public partial class frmEmployees : Form
    {
        static string vs_ConnStr = "Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        // Tanıma göre bağlanmak için gerekli talimatları aldı
        SqlConnection conn = new SqlConnection(vs_ConnStr);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dataReader;
        string sqlstr;


        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            cmd.Connection = conn;

            conn.Open(); // bağlantıyı acıyorum

            FormInit(); // formun bazı kontrollerin ayarlamaları

        }

        private void FormInit()
        {
            tboxEmployeeID.ReadOnly= true;
            tboxFName.ReadOnly= true;
            tboxLName.ReadOnly= true;
            tboxTitle.ReadOnly= true;
            tboxCity.ReadOnly= true;
            tboxCountry.ReadOnly= true;

            btonInsert.Enabled = false;
            btonUpdate.Enabled = false;
            btonDelete.Enabled = false;

        }

        private void LoadData()
        {
            // Veriyi SQL Serverdan çekecek bölüm
            cmd.CommandText = "SELECT EmployeeID,FirstName,LastName,Title,City,Country FROM Employees ORDER BY EmployeeID";

            // sql cümlesine göre cmd nesnesinin komutunu karsıya gönder..çalıştır..sonucları geri al
            dataReader = cmd.ExecuteReader();

            ShowData();
        }

        private void ShowData()
        {
            if(dataReader.Read()) // Okuyabildiği sürece kontrollerin içini dolduracak.
            {
                tboxEmployeeID.Text = dataReader[0].ToString();
                tboxFName.Text = dataReader[1].ToString();
                tboxLName.Text = dataReader[2].ToString();
                tboxTitle.Text = dataReader[3].ToString();
                tboxCity.Text = dataReader[4].ToString();
                tboxCountry.Text = dataReader[5].ToString();
            }
            else
            {
                MessageBox.Show("Gösterilecek herhangi bir veri bulunamadı..");
            }
        }
    }
}
