using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaYazilimi.basearac
{
    public class Musteri
    {

       
        public Musteri(string fullname ,string email, string phonenumber)
        {
            FullName = fullname;       
            Email = email;
            PhoneNumber = phonenumber;

        }

        private string _fullname;
        private string _email;

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (value.Length == 11 && !string.IsNullOrWhiteSpace(value))
                    _phoneNumber = value;
                else
                    throw new Exception("telefon numarası 11 haneden oluşmak zorundadır.");
            }
        }


        

        public string FullName
        {
            get
            {
                return _fullname;
            }

            set
            {
                if (value.Length <= 30 && !string.IsNullOrWhiteSpace(value))
                    _fullname = value;
                else
                    throw new Exception("kullanıcı ad ve soyadı toplam uzunluğu 30 karakterden fazla ve boşluk olamaz.");
            }

        }
        public string Email
        {
            get
            { 
                return _email;
            }


            set
            {
                if (value.Length < 50 && !string.IsNullOrWhiteSpace(value))
                    _email = value;
                else
                    throw new Exception("eposta uzunluğu 50 karakterden fazla ve boş olamaz. ");
            }
        }


        public override string ToString()
        {
            return $"müşteri adı ve soyadı:  {FullName}  müşteri telefon numarası: {PhoneNumber}  müşteri e mail adresi:  {Email} ";
        }

    }
}
