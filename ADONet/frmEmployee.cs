using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ADONet
{
    public partial class frmEmployee : Form
    {
        static string vs_ConnStr = "Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        // Tanıma göre bağlanmak için gerekli talimatları aldı
        SqlConnection connection = new SqlConnection(vs_ConnStr);
        SqlCommand SqlCommand = new SqlCommand();


        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            FormInit();
        }

        private void FormInit()
        {
            //tboxAd.Enabled = false;
            //tboxSoyad.Enabled = false;
            //tboxSehir.Enabled = false;
        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            //tboxAd.Enabled = true;
            //tboxSoyad.Enabled = true;
            //tboxSehir.Enabled = true;
            NewRecord();





        }

        private void NewRecord()
        {
            try
            {
                connection.Open(); // bağlantıyı aç..

                // INSERT INTO Employees....
                SqlCommand.CommandText = "INSERT INTO Employees (FirstName,LastName,City) VALUES ('";
                SqlCommand.CommandText += tboxAd.Text + "','";
                SqlCommand.CommandText += tboxSoyad.Text + "','";
                SqlCommand.CommandText += tboxSehir.Text + "')";

                SqlCommand.Connection = connection; // bu bağlantıyı kullanacaksın
                SqlCommand.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("VT bağlantısında problem var...");
                MessageBox.Show(ex.Message);

            }




        }
    }
}
