using Altyap�.Enum;
using Altyap�.S�n�flar;
using Altyap�.SoyutS�nflar;
using System.Security.Cryptography.X509Certificates;

namespace HayvanatBahcesiProjesii
{
    public partial class Form1 : Form
    {
        Altyap�.SoyutS�nflar.HayvanatBahcesi hayvanatBahcesi;
        Hayvan guncellenecekHayvan; //global tan�mlanmas�n�n sebebi farkl� metotlarda da eri�ilebilmesi.

        public Form1()
        {

            InitializeComponent();
            hayvanatBahcesi = new Altyap�.SoyutS�nflar.HayvanatBahcesi();

            //comboboxa hayvan doldural�m
            cmbHayvanlar.Items.Add("Se�iniz:"); //0.indekste se�iniz var.
            cmbHayvanlar.Items.Add(new Kedi());
            cmbHayvanlar.Items.Add(new Balik());
            cmbHayvanlar.Items.Add(new Aslan());
            cmbHayvanlar.SelectedIndex = 0;  //se�iniz ile ba�lamas� i�in yazd�k.(0.indeks)
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

                
                hayvanatBahcesi.HayvanEkle(eklenenHayvan);  //hayvanatbah�esi clas�m�zda hayvanekle metodu var.
                                                            //isme g�re s�ralar. c�nk� listele metodu i�inde orderby name yapt�k...

                Listele();
                //ekle metodu kullanmadan eklemek i�inde:

                //lstHayvanOzellikleri.Items.Add($"T�r: {eklenenHayvan.GetType().Name}, Ya�: {eklenenHayvan.Yas}, Cinsiyet: {eklenenHayvan.Cinsiyet}");
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
            //G�ncellecek hayvan� se�tikten sonra, bilgilerini ekleme b�l�m�nde g�relim


            //comboboxta g�ster:
            Type tur = guncellenecekHayvan.GetType();

            foreach (var item in cmbHayvanlar.Items)
            {
                if (item.GetType() == tur)
                {
                    cmbHayvanlar.SelectedItem = (Hayvan)item;
                    break;
                }
            }
         

            //ya� textboxunda g�ster
            TXTyAS.Text = guncellenecekHayvan.Yas.ToString();


            //cinsiyetini radiobuttonda g�ster
            if (guncellenecekHayvan.Cinsiyet == Cinsiyet.Erkek)
                rbErkek.Checked = true;
            else
                rbDisi.Checked = true;

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

                //lstHayvanOzellikleri.Items.Remove(seciliHayvan);
                //lstHayvanOzellikleri.Show();

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (guncellenecekHayvan == null)
                {
                    MessageBox.Show("L�tfen g�ncellenecek hayvan� se�iniz.");
                    return;
                }

                //e�er g�ncellenecek hayvan varsa g�ncelle // g�ncelleme i�in normal ekleme gibi yap�yoruz SADECE sonunda hayvan g�ncelle metodunu cag�r�yoruz.
                //hayvang�ncelle metodu eskisini c�kar�p yenisini ekle. b�ylece g�ncelleniyor.

                Hayvan eklenenHayvan = (Hayvan)(cmbHayvanlar.SelectedItem);
                eklenenHayvan = (Hayvan)Activator.CreateInstance(eklenenHayvan.GetType());  //polimorfizm...
                eklenenHayvan.Yas = Convert.ToInt32(TXTyAS.Text);
                eklenenHayvan.Cinsiyet = rbErkek.Checked ? Altyap�.Enum.Cinsiyet.Erkek : Altyap�.Enum.Cinsiyet.Di�i;
                eklenenHayvan.ComboboxHali = false;
                hayvanatBahcesi.HayvanGuncelle(guncellenecekHayvan, eklenenHayvan);
                MessageBox.Show("Hayvan g�ncellenmi�tir.");
                Listele();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata:" + ex.Message);
            }

        }
    }

}