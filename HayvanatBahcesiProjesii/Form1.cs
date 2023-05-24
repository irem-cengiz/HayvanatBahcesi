using Altyap�.S�n�flar;
using Altyap�.SoyutS�nflar;
using System.Security.Cryptography.X509Certificates;

namespace HayvanatBahcesiProjesii
{
    public partial class Form1 : Form
    {
        Altyap�.SoyutS�nflar.HayvanatBahcesi hayvanatBahcesi;
        public Form1()
        {

            InitializeComponent();
            hayvanatBahcesi = new Altyap�.SoyutS�nflar.HayvanatBahcesi();

            //comboboxa hayvan doldural�m
            cmbHayvanlar.Items.Add("Se�iniz:");
            cmbHayvanlar.Items.Add(new Kedi());
            cmbHayvanlar.Items.Add(new Balik());
            cmbHayvanlar.Items.Add(new Aslan());
            cmbHayvanlar.SelectedIndex = 0;  //se�iniz ile ba�lamas� i�in yazd�k.
            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedIndex == 0)
            {
                MessageBox.Show("L�tfen se�im yap�n�z.");
                return;
            }

            try
            {
                Hayvan eklenenHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                eklenenHayvan = (Hayvan)Activator.CreateInstance(eklenenHayvan.GetType());  //polimorfizm...
                eklenenHayvan.Yas = Convert.ToInt32(TXTyAS.Text);
                eklenenHayvan.Cinsiyet = rbErkek.Checked ? Altyap�.Enum.Cinsiyet.Erkek : Altyap�.Enum.Cinsiyet.Di�i;
                eklenenHayvan.ComboboxHali = false;
                btnS�L.Enabled = true;


                hayvanatBahcesi.HayvanEkle(eklenenHayvan);
                Listele();
                //isme g�re s�ralar.
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }

        }

        private void lstHayvanOzellikleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hayvan seciliHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);
            MessageBox.Show(seciliHayvan.GetType().Name + "," + "Ya��:" + seciliHayvan.Yas + " " + "Cinsiyet:" + seciliHayvan.Cinsiyet);
        }

        private void btnS�L_Click(object sender, EventArgs e)
        {
            try
            {
                Hayvan seciliHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);

                if (seciliHayvan == null)
                {
                    MessageBox.Show("L�tfen silinecek hayvan se�iniz:");
                    return;
                }
                hayvanatBahcesi.HayvanCikar(seciliHayvan);

                Listele();
                MessageBox.Show("Hayvan silinmi�tir.");

                if (hayvanatBahcesi.Hayvanlar.Count() == 0) //hi� hayvan kalmad�ysa
                    btnS�L.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }

        }

        private void Listele()
        {
            lstHayvanOzellikleri.Items.Clear();

            lstHayvanOzellikleri.Items.AddRange(hayvanatBahcesi.Hayvanlar.OrderBy(h => h.GetType().Name).ToArray());
        }
    }


}