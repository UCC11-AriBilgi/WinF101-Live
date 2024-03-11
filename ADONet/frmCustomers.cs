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
    public partial class frmCustomers : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum

        string vs_ConnStr = @"Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;"; // Connection String : veritabanına bağlanma için
        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kodlar

            // İlk önce DG mi ayarlayacağım
            PrepareGrid();

            BindGrid();

        }

        private void PrepareGrid()
        {
            // Ekrandaki DG yi ayarlar...

            // AutoGenerateColums --> false

            dgrdCustomers.AutoGenerateColumns = false;

            // AllowUser.. --> false .. grid üzerinde kayıt ekleme yapaması...benim butonuma mahkum olsun
            dgrdCustomers.AllowUserToAddRows = false;
            dgrdCustomers.AllowUserToDeleteRows = false;

            // AutoSizeColumnsMode --> Fill kolonların genişlikleriyle ilgili

            dgrdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrdCustomers.RowHeadersVisible = false;

            dgrdCustomers.AllowUserToResizeRows = false;

            dgrdCustomers.ReadOnly = false;

            dgrdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgrdCustomers.ColumnCount = 4; // gösterilecek kolon sayısı

            // Add Columns

            dgrdCustomers.Columns[0].Name = "CustomerID";
            dgrdCustomers.Columns[0].HeaderText = "Customer ID";
            dgrdCustomers.Columns[0].DataPropertyName = "CustomerID";

            dgrdCustomers.Columns[1].Name = "CompanyName";
            dgrdCustomers.Columns[1].HeaderText = "Company Name";
            dgrdCustomers.Columns[1].DataPropertyName = "CompanyName";

            dgrdCustomers.Columns[2].Name = "ContactName";
            dgrdCustomers.Columns[2].HeaderText = "Contact Name";
            dgrdCustomers.Columns[2].DataPropertyName = "ContactName";

            dgrdCustomers.Columns[3].Name = "Country";
            dgrdCustomers.Columns[3].HeaderText = "Country";
            dgrdCustomers.Columns[3].DataPropertyName = "Country";

        }

        private void BindGrid()
        {
            // VT tarafındaki bilginin alınıp DG içinde gösterilmesini sağlıyacak
            vs_SQLCommand = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr)) // Bağlantı
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection)) // Komut tarafı
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))  // Adaptör kısmı
                    {
                        using (DataSet dset = new DataSet()) // Verilerim
                        {
                            adapter.Fill(dset);

                            dgrdCustomers.DataSource = dset.Tables[0]; // vt tarafından alınan veri DG içinde gösterilmek için

                        }
                    }

                }
            }

        }

        private void ShowData(string prmMod)
        {
            frmCustomerDetails frmCustomerDetails = new frmCustomerDetails();

            frmCustomerDetails.Mod = prmMod;

            // IUD olma moduna göre 2.formdaki bazı ayarlamaları yapacağım

            switch (prmMod)
            {
                case "I": // Insert Modu
                    frmCustomerDetails.tboxCustomerID.Enabled = true;
                    frmCustomerDetails.tboxCustomerID.Text = "";
                    frmCustomerDetails.tboxCompanyName.Text = "";
                    frmCustomerDetails.tboxContactName.Text = "";
                    frmCustomerDetails.tboxCountry.Text = "";

                    break;
                case "U": // Update Modu
                    frmCustomerDetails.tboxCustomerID.Enabled = false;
                    // DG üzerindeki bilgileri yerleştiriyorum
                    frmCustomerDetails.tboxCustomerID.Text = dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
                    frmCustomerDetails.tboxCompanyName.Text = dgrdCustomers.CurrentRow.Cells[1].Value.ToString(); ;
                    frmCustomerDetails.tboxContactName.Text = dgrdCustomers.CurrentRow.Cells[2].Value.ToString(); ;
                    frmCustomerDetails.tboxCountry.Text = dgrdCustomers.CurrentRow.Cells[3].Value.ToString(); ;
                    break;
                default:
                    break;
            }

            frmCustomerDetails.ShowDialog();



        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U");

            BindGrid();
        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            ShowData("I");

            BindGrid();
        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            vs_SQLCommand = "DELETE FROM Customers WHERE CustomerID=@CustomerID";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr)) // Bağlantı
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection)) // Komut tarafı
                {
                    // yani burası parametreleri ayarlayacak ve çalıştıracak

                    command.Parameters.AddWithValue("CustomerID", dgrdCustomers.CurrentRow.Cells[0].Value.ToString());
                    // dg deki 0.indexdeki bilgi parametre içine atanıyor.

                    command.CommandType= CommandType.Text;

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Bilginiz veritabanından basarıyla silindi....");
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.Message.ToString());
                    }



                }
            }


        }
    }
}
