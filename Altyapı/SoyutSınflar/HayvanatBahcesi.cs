using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altyapı.Sınıflar;

namespace Altyapı.SoyutSınflar
{
    public class HayvanatBahcesi
    {
        public List<Hayvan> Hayvanlar { get; set; } = new List<Hayvan>();

        public void HayvanEkle(Hayvan eklenecekHayvan)
        {
            Hayvanlar.Add(eklenecekHayvan);
        }

        public void HayvanCikar(Hayvan cikarilacakHayvan)
        {
            Hayvanlar.Remove(cikarilacakHayvan);
        }

        public void HayvanGuncelle(Hayvan guncellenecekHayvan,Hayvan guncelHayvan)
        {
            //int eskiHayvanIndex = Hayvanlar.IndexOf(guncellenecekHayvan);
            //Hayvanlar[eskiHayvanIndex] = guncelHayvan;
            //diğer yol:

            Hayvanlar.Remove(guncellenecekHayvan);
            Hayvanlar.Add(guncelHayvan);
        }
    } 
}
