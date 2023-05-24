using Altyapý.Enum;
using Altyapý.Sýnýflar;
using Altyapý.SoyutSýnflar;
using System.Security.Cryptography.X509Certificates;

namespace HayvanatBahcesiProjesii
{
    public partial class Form1 : Form
    {
        Altyapý.SoyutSýnflar.HayvanatBahcesi hayvanatBahcesi;
        Hayvan guncellenecekHayvan; //global tanýmlanmasýnýn sebebi farklý metotlarda da eriþilebilmesi.

        public Form1()
        {

            InitializeComponent();
            hayvanatBahcesi = new Altyapý.SoyutSýnflar.HayvanatBahcesi();

            //comboboxa hayvan dolduralým
            cmbHayvanlar.Items.Add("Seçiniz:"); //0.indekste seçiniz var.
            cmbHayvanlar.Items.Add(new Kedi());
            cmbHayvanlar.Items.Add(new Balik());
            cmbHayvanlar.Items.Add(new Aslan());
            cmbHayvanlar.SelectedIndex = 0;  //seçiniz ile baþlamasý için yazdýk.(0.indeks)
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

                
                hayvanatBahcesi.HayvanEkle(eklenenHayvan);  //hayvanatbahçesi clasýmýzda hayvanekle metodu var.
                                                            //isme göre sýralar. cünkü listele metodu içinde orderby name yaptýk...

                Listele();
                //ekle metodu kullanmadan eklemek içinde:

                //lstHayvanOzellikleri.Items.Add($"Tür: {eklenenHayvan.GetType().Name}, Yaþ: {eklenenHayvan.Yas}, Cinsiyet: {eklenenHayvan.Cinsiyet}");
                //lstHayvanOzellikleri.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }
        }
        private void lstHayvanOzellikleri_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            guncellenecekHayvan = (Hayvan)(lstHayvanOzellikleri.SelectedItem);
            //Güncellecek hayvaný seçtikten sonra, bilgilerini ekleme bölümünde görelim


            //comboboxta göster:
            Type tur = guncellenecekHayvan.GetType();

            foreach (var item in cmbHayvanlar.Items)
            {
                if (item.GetType() == tur)
                {
                    cmbHayvanlar.SelectedItem = (Hayvan)item;
                    break;
                }
            }
         

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

                //lstHayvanOzellikleri.Items.Remove(seciliHayvan);
                //lstHayvanOzellikleri.Show();

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
                if (guncellenecekHayvan == null)
                {
                    MessageBox.Show("Lütfen güncellenecek hayvaný seçiniz.");
                    return;
                }

                //eðer güncellenecek hayvan varsa güncelle // güncelleme için normal ekleme gibi yapýyoruz SADECE sonunda hayvan güncelle metodunu cagýrýyoruz.
                //hayvangüncelle metodu eskisini cýkarýp yenisini ekle. böylece güncelleniyor.

                Hayvan eklenenHayvan = (Hayvan)(cmbHayvanlar.SelectedItem);
                eklenenHayvan = (Hayvan)Activator.CreateInstance(eklenenHayvan.GetType());  //polimorfizm...
                eklenenHayvan.Yas = Convert.ToInt32(TXTyAS.Text);
                eklenenHayvan.Cinsiyet = rbErkek.Checked ? Altyapý.Enum.Cinsiyet.Erkek : Altyapý.Enum.Cinsiyet.Diþi;
                eklenenHayvan.ComboboxHali = false;
                hayvanatBahcesi.HayvanGuncelle(guncellenecekHayvan, eklenenHayvan);
                MessageBox.Show("Hayvan güncellenmiþtir.");
                Listele();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }

        }
    }

}