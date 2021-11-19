using System;

namespace Sekiller
{
    public class Dikdortgen : Sekil
    {
        //public Dikdortgen()
        //{

        //}

        public Dikdortgen(double x, double y) : base(x)
        {
            this.Y = y;
        }
        public double Y { get; set; }

        public override double AlanHesapla()
        {
            return X * Y;
        }

        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
