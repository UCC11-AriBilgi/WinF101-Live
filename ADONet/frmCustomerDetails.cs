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
    public partial class frmCustomerDetails : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum

        string vs_ConnStr = @"Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;"; // Connection String : veritabanına bağlanma için

        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        public string Mod = ""; // Bu formun I,U,D işlemlerinden hangisini yapacağını söyleyen değişgen...


        public frmCustomerDetails()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            vs_SQLCommand = "";

            switch (Mod)
            {

                case "I":
                    vs_SQLCommand = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,Country) VALUES (@CustomerID,@CompanyName,@ContactName,@Country)";
                    // Parametrik hazırladık. Nedeni güvenlik...
                    break;
                
                case "U":
                    vs_SQLCommand = "UPDATE Customers SET ";
                    vs_SQLCommand += "CompanyName=@CompanyName,";
                    vs_SQLCommand += "ContactName=@ContactName,";
                    vs_SQLCommand += "Country=@Country ";
                    vs_SQLCommand += "WHERE CustomerID=@CustomerID";
                    break;
                
                default:
                    break;
            }
            // Gerekli SQL Command oluşturuldu.

            using (SqlConnection connection = new SqlConnection(vs_ConnStr)) // Bağlantı
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection)) // Komut tarafı
                {
                    // şimdi parametreleri doldurma zamanı
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("CustomerID",tboxCustomerID.Text);
                    command.Parameters.AddWithValue("CompanyName",tboxCompanyName.Text);
                    command.Parameters.AddWithValue("ContactName",tboxContactName.Text);
                    command.Parameters.AddWithValue("Country",tboxCountry.Text);

                    command.CommandType = CommandType.Text;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery(); // Command calışıyor

                        MessageBox.Show("Bilgileriniz veritabanına basarıyla kaydedildi...");

                        this.Close();
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());
                        
                    }

                }
            }

        }
    }
}
