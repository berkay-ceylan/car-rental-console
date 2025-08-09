using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi.basearac
{
    public class Otomobil : BaseArac 
    {
        public Otomobil(string marka, string model, AracTuru aracturu, VitesTuru vitesturu, YakıtTuruEnum yakıtturu, string renk) : base(marka, model,aracturu ,vitesturu, yakıtturu, renk)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
