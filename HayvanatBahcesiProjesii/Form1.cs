using Altyapý.Enum;
using Altyapý.Sýnýflar;
using Altyapý.SoyutSýnflar;
using System.Security.Cryptography.X509Certificates;

namespace HayvanatBahcesiProjesii
{
    public partial class Form1 : Form
    {
        Altyapý.SoyutSýnflar.HayvanatBahcesi hayvanatBahcesi;
        Hayvan guncellenecekHayvan;
        

        public Form1()
        {

            InitializeComponent();
            hayvanatBahcesi = new Altyapý.SoyutSýnflar.HayvanatBahcesi();

            //comboboxa hayvan dolduralým
            cmbHayvanlar.Items.Add("Seçiniz:");
            cmbHayvanlar.Items.Add(new Kedi());
            cmbHayvanlar.Items.Add(new Balik());
            cmbHayvanlar.Items.Add(new Aslan());
            cmbHayvanlar.SelectedIndex = 0;  //seçiniz ile baþlamasý için yazdýk.
            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen seçim yapýnýz.");
                return;
            }

            try
            {
                Hayvan eklenenHayvan = (Hayvan)cmbHayvanlar.SelectedItem;
                eklenenHayvan = (Hayvan)Activator.CreateInstance(eklenenHayvan.GetType());  //polimorfizm...
                eklenenHayvan.Yas = Convert.ToInt32(TXTyAS.Text);
                eklenenHayvan.Cinsiyet = rbErkek.Checked ? Altyapý.Enum.Cinsiyet.Erkek : Altyapý.Enum.Cinsiyet.Diþi;
                eklenenHayvan.ComboboxHali = false;
                btnSÝL.Enabled = true;


                hayvanatBahcesi.HayvanEkle(eklenenHayvan);
                Listele();
                //isme göre sýralar.
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }
        }
        private void lstHayvanOzellikleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hayvan aktarilanHayvan = new Kedi();
            Hayvan guncellenecekHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);
            //Güncellecek hayvaný seçtikten sonra, bilgilerini ekleme bölümünde görelim



            //comboboxta göster:
            Type tur = guncellenecekHayvan.GetType();
            
            foreach (var item in cmbHayvanlar.Items)
            {
                if(item.GetType() == tur) 
                {
                    aktarilanHayvan = (Hayvan)item;
                    break;
                }
            }
            cmbHayvanlar.SelectedItem = aktarilanHayvan;

            //yaþ textboxunda göster
            TXTyAS.Text = guncellenecekHayvan.Yas.ToString();



            //cinsiyetini radiobuttonda göster
            if (guncellenecekHayvan.Cinsiyet == Cinsiyet.Erkek)
                rbErkek.Checked = true;
            else
                rbDisi.Checked = true;

         


        }
        private void btnSÝL_Click(object sender, EventArgs e)
        {
            try
            {
                Hayvan seciliHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);

                if (seciliHayvan == null)
                {
                    MessageBox.Show("Lütfen silinecek hayvan seçiniz:");
                    return;
                }
                hayvanatBahcesi.HayvanCikar(seciliHayvan);

                Listele();
                MessageBox.Show("Hayvan silinmiþtir.");

                if (hayvanatBahcesi.Hayvanlar.Count() == 0) //hiç hayvan kalmadýysa
                    btnSÝL.Enabled = false;

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Hayvan seciliHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);

                if (seciliHayvan == null)
                {
                    MessageBox.Show("Lütfen günvellenecek hayvaný seçiniz:");
                    
                }           

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }

        }
    }

}