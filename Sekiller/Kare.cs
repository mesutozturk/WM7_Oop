using System;

namespace Sekiller
{
    public class Kare : Sekil
    {
        public Kare(double x) : base(x)
        {
            OlusturmaZamani = DateTime.UtcNow;
        }
        public override double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
