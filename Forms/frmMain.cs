namespace Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Burası bir event
        private void btonGoster_Click(object sender, EventArgs e)
        {
            // ekrandan aldığı bilgileri bir mesaj kutusunda göstersin
            string ad = tboxAd.Text; // içeriğini değişgene yükledim.

            string soyad = tboxSoyad.Text;

            MessageBox.Show($"Girmiş olduğunuz ad soyad bilgisi {ad} {soyad} dır...");

            tboxAd.Clear(); // temizle
            tboxSoyad.Clear();

            tboxAd.Focus(); // tboxAd a odaklanıyorum.


        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programdan çıkar
        }
    }
}
