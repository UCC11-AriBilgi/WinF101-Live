
using Microsoft.Data.SqlClient;

namespace ADONet
{
    
    public partial class frmMain : Form
    {
        static string vs_ConnStr = "Server=BASAE;Database=Northwind;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true;";

        // Tan�ma g�re ba�lanmak i�in gerekli talimatlar� ald�
        SqlConnection connection = new SqlConnection(vs_ConnStr);


        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dBBa�lanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dBBa�lanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Bir DBye ba�lanabilmek i�in iki �eye ihtiyac�m var
            // 1. ConnectionString dedi�imiz bir string de�er
            // 2. Bunu anlayacak bir k�t�phaneye ihtiya�

            //// Tan�ma g�re ba�lanmak i�in gerekli talimatlar� ald�


            try
            {
                connection.Open(); // ba�lant�y� a�..

                MessageBox.Show("VT ba�lant�s� a��ld�...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT ba�lant�s�nda problem var...");
                MessageBox.Show(ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Close();
                MessageBox.Show("Ba�lant� kapand�");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
