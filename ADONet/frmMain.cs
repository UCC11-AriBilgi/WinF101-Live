
using Microsoft.Data.SqlClient;

namespace ADONet
{
    
    public partial class frmMain : Form
    {
        static string vs_ConnStr = "Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        // Tanýma göre baðlanmak için gerekli talimatlarý aldý
        SqlConnection connection = new SqlConnection(vs_ConnStr);


        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dBBaðlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dBBaðlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Bir DBye baðlanabilmek için iki þeye ihtiyacým var
            // 1. ConnectionString dediðimiz bir string deðer
            // 2. Bunu anlayacak bir kütüphaneye ihtiyaç

            //// Tanýma göre baðlanmak için gerekli talimatlarý aldý


            try
            {
                connection.Open(); // baðlantýyý aç..

                MessageBox.Show("VT baðlantýsý açýldý...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT baðlantýsýnda problem var...");
                MessageBox.Show(ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Close();
                MessageBox.Show("Baðlantý kapandý");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
