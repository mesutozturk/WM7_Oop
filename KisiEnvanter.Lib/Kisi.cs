using System;
using System.Text.RegularExpressions;

namespace KisiEnvanter.Lib
{
    public class Kisi
    {
        //ad soyad ceptelefon (10 haneli 5 ile başlayacak) emil(@ işareti 1 adet . olacak) tckn (11hane 0la başlayamaz tek rakamla bitemez)
        /*
         * Access Modifier 
         * Private
         * Public
         * Internal
         * *Protected
         * *Protected Internal
         */
        private string _ad;
        //private string _soyad;
        private DateTime _dogumTarihi;
        private string _email;

        //Encapsulation
        //Property
        /// <summary>
        /// Ad propertysi falan filan
        /// </summary>
        public string Ad
        {
            set
            {
                if (value.Length < 2)
                    throw new Exception("Ad En az 2 karakter olmalı");
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf) || char.IsPunctuation(harf) || char.IsSymbol(harf))
                        throw new Exception("Ad ifadesi içerisinde rakam kullanamazsın!");
                }
                _ad = value;
            }
            get
            {
                string son = string.Empty;
                string[] isimler = _ad.Split(' ');
                foreach (string isim in isimler)
                {
                    son += isim.Substring(0, 1).ToUpper() + isim.Substring(1) + " ";
                }
                return son.Remove(son.Length - 1);

                //string.Join(' ', isimler);

                //return son + "\b";
            }
        }
        public string Soyad { get; set; }
        public DateTime DogumTarihi
        {
            set { _dogumTarihi = value; }
        }
        public int Yas //readonly prop
        {
            get
            {
                return DateTime.Now.Year - _dogumTarihi.Year;
            }
        }

        private string _telefon;

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    _email = value.ToLower().Trim();
                }
                else
                    throw new Exception("Email formatınız hatalıdır");

            }
        }
        // 234234
        // 123123.101.104
    }
    class Deneme
    {
        public string A { get; set; }
        public int B { get; set; }
        public long Logn { get; set; }
    }
}