using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi.basearac
{
    public class BaseArac
    {
     
			

        public BaseArac(string marka, string model,AracTuru aracturu, VitesTuru vitesturu,YakıtTuruEnum yakıtturu,string renk)
        {
            _aracTuru=aracturu;
            _renk = renk;
            _yakıt= yakıtturu;
            this.vitesturu = vitesturu;
           _marka = marka;
            _model= model;
            id++;
        }
        private static int id = 0;
        private string _model;
        private string _marka;
        public int İd = id;
        private string _renk;
        private YakıtTuruEnum _yakıt;
        public decimal Fiyat = 100m;
        public VitesTuru vitesturu {  get; set; }
        public AracTuru _aracTuru;


        public YakıtTuruEnum Yakıt
        {
            get { return _yakıt; }
            set { _yakıt = value; }
        }

        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }



        public string Marka
        {
            get { return _marka; }
            set
            {
                if (value.Length <= 20 && !string.IsNullOrEmpty(value))
                {
                    _marka = value;
                }
                else
                {
                    throw new Exception("marka boş ve 20 karakterden küçük olamaz!");
                }

            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length <= 15 && !string.IsNullOrEmpty(value))
                    _model = value;
                else
                    throw new Exception("model boş ve 15 karakterden küçük olamaz!");
            }
        }


        public override string ToString()
        {
            return $"marka: {_marka}  model: {_model} araç türü: {_aracTuru} renk: {_renk} vites türü: {vitesturu} yakıt tipi: {_yakıt} fiyat: {Fiyat}";
        }

    }
}
