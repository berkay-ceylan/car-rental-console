using AracKiralamaYazilimi.basearac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi
{
    public class Rent
    {

        public Musteri musteri { get; }
        public BaseArac arac { get; }
        
        public int gunSayisi { get; }

        public decimal toplamTutar;


        public Rent(Musteri Musteri, BaseArac Arac,  int GunSayisi)
        {


            musteri = Musteri;
            arac = Arac;
            
            gunSayisi = GunSayisi;

            toplamTutar = Arac.Fiyat * GunSayisi;

        }
        public override string ToString()
        {
            return $"müşteri: {musteri} kiralanan araç: {arac}  kiralanacak gün sayısı: {gunSayisi} toplam ödenecek tutar: {toplamTutar} ";
        }
    }
}
