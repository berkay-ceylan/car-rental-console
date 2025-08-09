using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi.basearac
{
    public class ElektrikliOtomobil : BaseArac
    {
        public ElektrikliOtomobil(string marka, string model, AracTuru aracturu, VitesTuru vitesturu, YakıtTuruEnum yakıtturu, string renk,int bataryakapasitesi) : base(marka, model, aracturu, vitesturu, yakıtturu, renk)
        {
            Fiyat = 300m;
            _bataryaKapasitesi = bataryakapasitesi;

        }
       
        public int _bataryaKapasitesi { get; set; }
        

        public override string ToString()
        {
            return base.ToString() + " batarya kapasitesi: " +_bataryaKapasitesi;
        }
    }
}
