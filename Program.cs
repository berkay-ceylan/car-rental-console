using AracKiralamaYazilimi.basearac;

namespace AracKiralamaYazilimi
{
    internal class Program
    {
        public static List<BaseArac> araclar = new List<BaseArac>();
        public static List<Musteri> musteriler = new List<Musteri>();
        public static List<Rent> kiralananlar = new List<Rent>();

        static void Main(string[] args)
        {
            string secim;

            araclar.Add(new Otomobil("audi", "a5",(AracTuru)1 ,(VitesTuru)0, (YakıtTuruEnum)0, "siyah"));
            araclar.Add(new Otomobil("bmw", "520d", (AracTuru)1, (VitesTuru)2, (YakıtTuruEnum)1, "kırmızı"));
            araclar.Add(new Suv("toyota", "helux", (AracTuru)0, (VitesTuru)0, (YakıtTuruEnum)1, "beyaz"));
            araclar.Add(new Suv("bmw", "x5", (AracTuru)0, (VitesTuru)1, (YakıtTuruEnum)0, "siyah"));
            araclar.Add(new ElektrikliOtomobil("Togg", "TX-10", (AracTuru)2, (VitesTuru)0, (YakıtTuruEnum)2, "mavi",300));
            araclar.Add(new ElektrikliOtomobil("tesla", "Model-Y", (AracTuru)2, (VitesTuru)1, (YakıtTuruEnum)2, "gri", 400));
            araclar.Add(new Minibus("mercedes", "vito", (AracTuru)3, (VitesTuru)1, (YakıtTuruEnum)1, "siyah", 50));





            while (true)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n----- araç kiralama sistemi -----\n");
                Console.ResetColor();
                Console.WriteLine("1-Müşteri eklemek için: ");
                Console.WriteLine("2.Araçları listelemek için: ");
                Console.WriteLine("3.araç kiralamak için: ");
                Console.WriteLine("4.kiralanan araçları listelemek için");
                Console.WriteLine("5.çıkış yapmak için");
                Console.Write("\nseçim:");


                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        MusteriEkleme();
                        Console.WriteLine("\n\ndevam etmek için Enter a basın");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        AracListele();
                        Console.WriteLine("\n\ndevam etmek için Enter a basın");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":

                        KiralamaAkisi();
                        Console.WriteLine("\n\ndevam etmek için Enter a basın");
                        Console.ReadLine();

                        Console.Clear();

                        break;
                        case "4":
                        KiralamalariListele();
                        Console.WriteLine("\n\ndevam etmek için Enter a basın");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        CıkısAkisi();
                        
                        return;
                    default:

                        Console.WriteLine("Hata: yanlış tuşlama yaptınız");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                }

            }





        }

        public static void MusteriEkleme()
        {
            try
            {
                Console.Write("\nlütfen adınızı ve oyadınızı giriniz: ");
                string ad = Console.ReadLine();

                Console.Write("\nLütfen telefon numaranızı (başında 0 ile) giriniz: ");
                string tel = Console.ReadLine();

                Console.Write("\nLütfen e-posta adresinizi giriniz: ");
                string email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(email))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBoş değer girilemez.");
                    Console.ResetColor();
                    return;
                }

                Musteri newmusteri = new Musteri(fullname: ad, email: email, phonenumber: tel);
                musteriler.Add(newmusteri);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMüşteri eklendi");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"\nHata: {ex.Message}");
                Console.ResetColor();
            }




        }

        public static void AracListele()
        {
            if (araclar.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nKayıtlı araç yok.");
                Console.ResetColor();
                return;
            }

            int i = 0;
            foreach (var item in araclar)
            {
                if (item.GetType() == typeof(Otomobil))
                {
                    Console.Write(i + ". ");
                    Console.WriteLine((Otomobil)item);
                }
                else if (item.GetType() == typeof(Suv))
                {
                    Console.Write(i + ". ");
                    Console.WriteLine((Suv)item);
                }
                else if (item.GetType() == typeof(ElektrikliOtomobil))
                {
                    Console.Write(i + ". ");
                    Console.WriteLine((ElektrikliOtomobil)item);
                }
                else
                {
                    Console.Write(i + ". ");
                    Console.WriteLine((Minibus)item);
                }
                i++;



            }


        }


        public static void KiralamaAkisi()
        {
            if (musteriler.Count == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nÖnce müşteri ekleyin.");
                Console.ResetColor();
                return;
            }

            MusterilerListele();
            Console.Write("\nLütfen araç kiralayacak müşterinin numarasını seçin: ");
            if (!int.TryParse(Console.ReadLine(), out int mid) || mid < 0 || mid >= musteriler.Count)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nGeçersiz müşteri seçimi.");
                Console.ResetColor();
                return;
            }

            AracListele();
            Console.Write("\nLütfen kiralamak istediğiniz araç numarasını seçin: ");
            if (!int.TryParse(Console.ReadLine(), out int aid) || aid < 0 || aid >= araclar.Count)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nGeçersiz araç seçimi.");
                Console.ResetColor();
                return;
            }

            Console.Write("\nKaç gün kiralamak istiyorsunuz: ");
            if (!int.TryParse(Console.ReadLine(), out int gun) || gun <= 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nGeçersiz gün sayısı.");
                Console.ResetColor();
                return;
            }

            var yeni = new Rent(musteriler[mid], araclar[aid], gun);
            kiralananlar.Add(yeni);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTebrikler, işlem başarıyla sonuçlandı.\n");
            Console.ResetColor();
            Console.WriteLine(yeni.ToString());
        }

        public static void MusterilerListele()
        {
            int j = 0;
            foreach (var musteri in musteriler)
            {

                Console.WriteLine($"{j} {musteri.FullName} {musteri.Email} {musteri.PhoneNumber}");
                j++;
            }


        }
        public static void KiralamalariListele()
        {
            if (kiralananlar.Count == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nHenüz kiralama yok.");
                Console.ResetColor();
                return;
            }

            foreach (var r in kiralananlar)
                Console.WriteLine(r);
        }

        public static void CıkısAkisi()
        {
            Console.Write("çıkış yapılıyor");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".");
            Thread.Sleep(200);
            Console.Write(".\n");
            



        }

    }
}
