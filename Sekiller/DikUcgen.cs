﻿namespace Sekiller
{
    public class DikUcgen : Dikdortgen
    {
        public DikUcgen(double x, double y) : base(x, y)
        {
        }

        public override double AlanHesapla()
        {
            return base.AlanHesapla()/2;
        }

        public override double CevreHesapla()
        {
            return X+Y+base.KosegenHesapla();
        }
    }
}
