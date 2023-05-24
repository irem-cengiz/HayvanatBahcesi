using Altyapı.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altyapı.Sınıflar
{
    public abstract class Hayvan
    {
        public bool ComboboxHali { get; set; } = true;
        private int yas;

        public int Yas
        {
            get { return yas; }
            set
            {

                if (value < 0 || value > 250)
                    yas = 0;
                else yas = value;
            }
        }
        public Cinsiyet Cinsiyet { get; set; }

        public virtual string SesCikar()    //metoda abstract dersek hayvana göre bu ses mecburi değişsin yapmıs olduk.                                   Abstract  yapmazsa  sescıkar metodu nyer almayabilir.
        {
            return "Sesi Yok";
        }

        public override string ToString()
        {
            if (ComboboxHali)
            {
                return this.GetType().Name;   //ilk açıldıgı zaman comboboxta bunu göster sonra
            }
            else
                return this.GetType().Name + " ," + "Yaşı:" + yas + " " + "Cinsiyet:" + Cinsiyet + " " + "Hayvan Sesi:" + SesCikar();
        }
    }
}
