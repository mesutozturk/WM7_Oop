using System;

namespace KisiEnvanter.Lib
{
    public class Kisi
    {

        /*
         * Access Modifier 
         * Private
         * Public
         * Internal
         * *Protected
         * *Protected Internal
         */
        private string _ad;
        private string _soyad;
        private int _yas;

        //Encapsulation
        //Property
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

    }
}