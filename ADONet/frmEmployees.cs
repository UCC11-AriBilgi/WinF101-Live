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
        string sqlstr; // sql deyimlerini tutacak değişgen


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

            FormInit(true); // formun bazı kontrollerin ayarlamaları

            LoadData(); // veriyi yüklemek ve göstermek için
        }

        private void FormInit(Boolean pStatus)
        {
            tboxEmployeeID.Clear();
            tboxFName.Clear();
            tboxLName.Clear();
            tboxTitle.Clear();
            tboxCity.Clear();
            tboxCountry.Clear();

            if (pStatus == true)
            {
                tboxEmployeeID.ReadOnly = true;
                tboxFName.ReadOnly = true;
                tboxLName.ReadOnly = true;
                tboxTitle.ReadOnly = true;
                tboxCity.ReadOnly = true;
                tboxCountry.ReadOnly = true;

                btonInsert.Enabled = false;
                btonUpdate.Enabled = false;
                btonDelete.Enabled = false;
            }
            else
            {
                tboxFName.ReadOnly = false;
                tboxLName.ReadOnly = false;
                tboxTitle.ReadOnly = false;
                tboxCity.ReadOnly = false;
                tboxCountry.ReadOnly = false;

                btonInsert.Enabled = true;
                //btonUpdate.Enabled = true;
                //btonDelete.Enabled = true;
            }





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
            if (dataReader.Read()) // Okuyabildiği sürece kontrollerin içini dolduracak.
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

        private void btonNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            // Burası yeni bir kayıt için gerekli bilgileri alır

            // Önce temizleme harekatı
            FormInit(false);

            cmd.CommandText = "SELECT ISNULL(MAX(EmployeeID),1000)+1 FROM Employees";

            dataReader.Close();

            tboxEmployeeID.Text = cmd.ExecuteScalar().ToString();

            tboxFName.Focus();
        }

        private void btonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // db tarafındaki ilgili tablonun kısıtlamalarına göre kontroller
                if (tboxFName.Text == "")
                {
                    MessageBox.Show("Ad alanın boş olamaz...");
                }
                else if (tboxLName.Text=="")
                {
                    MessageBox.Show("Soyad alanı boş olamaz...");
                }
                else
                {
                    sqlstr = string.Format("INSERT INTO Employees (FirstName,LastName,Title,City,Country) VALUES ('{0}','{1}','{2}','{3}','{4}')",tboxFName.Text,tboxLName.Text,tboxTitle.Text,tboxCity.Text,tboxCountry.Text);

                    ExecuteDML();

                    btonInsert.Enabled = false;

                    LoadData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteDML()
        {
            DialogResult dr=MessageBox.Show("İlgili SQL komutunu çalıştırmak istiyor musunuz? " + sqlstr,"Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
            {
                cmd.CommandText = sqlstr;

                int count= cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("İşlem basarılı...");
                }
                else
                    MessageBox.Show("Bir problem var...");
            }
        }
    }
}
