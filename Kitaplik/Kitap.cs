using System;

namespace Kitaplik
{
    public class Kitap
    {
        public Kitap()
        {
            EklenmeZamani = DateTime.Now;
        }
        public string Ad { get; set; }
        public int Yil { get; set; }
        public int Baski { get; set; }
        public string YazarAdSoyad { get; set; }
        public DateTime EklenmeZamani { get; private set; }
    }
}
