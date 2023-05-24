using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi.Interface
{
    public interface IEkleGuncelleSil
    {
        public void Ekle();
        public void Guncelle(string yeniAd, string yeniTur);
        public void SesCikar();
        public void Sil();
    }
}
