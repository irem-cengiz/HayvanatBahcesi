using HayvanatBahcesi.S�n�f;

namespace HayvanatBahcesi
{
    public partial class Form1 : Form
    {
        private List<Hayvan> hayvanlar;
        public Form1()
        {
            InitializeComponent();
            hayvanlar = new List<Hayvan>();

            cmbHayvanlar.DisplayMember = "TamBilgi";
            cmbHayvanlar.DataSource = hayvanlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string tur = txtTur.Text;

            Hayvan yeniHayvan = new Hayvan(ad, tur);
            hayvanlar.Add(yeniHayvan);

            // ComboBox'� g�ncelle
            cmbHayvanlar.DataSource = null;
            cmbHayvanlar.DataSource = hayvanlar;
            cmbHayvanlar.DisplayMember = "TamBilgi";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedIndex != -1)
            {
                Hayvan seciliHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                seciliHayvan.Ad = txtAd.Text;
                seciliHayvan.Tur = txtTur.Text;

                // ComboBox'� g�ncelle
                cmbHayvanlar.DataSource = null;
                cmbHayvanlar.DataSource = hayvanlar;
                cmbHayvanlar.DisplayMember = "TamBilgi";


            }
            else
            {
                MessageBox.Show("G�ncellemek i�in bir hayvan se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedIndex != -1)
            {
                hayvanlar.RemoveAt(cmbHayvanlar.SelectedIndex);

                // ComboBox'� g�ncelle
                cmbHayvanlar.DataSource = null;
                cmbHayvanlar.DataSource = hayvanlar;
                cmbHayvanlar.DisplayMember = "TamBilgi";


            }
            else
            {
                MessageBox.Show("Silmek i�in bir hayvan se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstHayvanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedIndex != -1)
            {
                Hayvan seciliHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                txtAd.Text = seciliHayvan.Ad;
                txtTur.Text = seciliHayvan.Tur;
            }
        }
    }
}