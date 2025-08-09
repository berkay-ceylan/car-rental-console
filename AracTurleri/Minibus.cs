using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi.basearac
{
    public class Minibus : BaseArac
    {
        public Minibus(string marka, string model, AracTuru aracturu, VitesTuru vitesturu, YakıtTuruEnum yakıtturu, string renk,int koltuksayisi) : base(marka, model, aracturu, vitesturu, yakıtturu, renk)
        {
            Fiyat = 400;
            _kotuksayisi= koltuksayisi;
        }

        public int _kotuksayisi { get; set; }
        

        public override string ToString()
        {
            return base.ToString() +" koltuk sayısı: " + _kotuksayisi;
        }
    }
}
