using HayvanatBahcesi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi.Sınıf
{
    public class Hayvan : IEkleGuncelleSil
    {
        public string Ad { get; set; }
        public string Tur { get; set; }

        public string TamBilgi => $"{Ad} ({Tur})";
        public Hayvan(string ad, string tur)
        {
            Ad = ad;
            Tur = tur;
        }

        public override string ToString()
        {
            return TamBilgi;
        }

        public void Ekle()
        {
            throw new NotImplementedException();
        }

        public void Guncelle(string yeniAd, string yeniTur)
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }

        public void SesCikar()
        {
            throw new NotImplementedException();
        }
    }
}
