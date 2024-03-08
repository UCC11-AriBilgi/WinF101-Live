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
    public partial class frmCustomers : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum

        string vs_ConnStr = @"Server = PHOKAIA\SS2019DE ; Database = Northwind; user id=sa;password=Doga251200; Trusted_Connection = False;Encrypt=false;"; // Connection String : veritabanına bağlanma için


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

            dgrdCustomers.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;

            dgrdCustomers.RowHeadersVisible = false;

            dgrdCustomers.AllowUserToResizeRows = false;

            dgrdCustomers.ReadOnly= false;

            dgrdCustomers.SelectionMode=DataGridViewSelectionMode.FullRowSelect;

            dgrdCustomers.ColumnCount = 4; // gösterilecek kolon sayısı

            // Add Columns

            dgrdCustomers.Columns[0].Name = "CustomerID";
            dgrdCustomers.Columns[0].HeaderText = "Customer ID";
            dgrdCustomers.Columns[0].DataPropertyName    = "CustomerID";
            
            dgrdCustomers.Columns[1].Name = "CompanyName";
            dgrdCustomers.Columns[1].HeaderText = "Company Name";
            dgrdCustomers.Columns[1].DataPropertyName    = "CompanyName";
            
            dgrdCustomers.Columns[2].Name = "ContactName";
            dgrdCustomers.Columns[2].HeaderText = "Contact Name";
            dgrdCustomers.Columns[2].DataPropertyName    = "ContactName";
            
            dgrdCustomers.Columns[3].Name = "Country";
            dgrdCustomers.Columns[3].HeaderText = "Country";
            dgrdCustomers.Columns[3].DataPropertyName    = "Country";

        }
    }
}
