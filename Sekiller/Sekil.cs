using System;

namespace Sekiller
{
    public abstract class Sekil
    {
        //public Sekil()
        //{

        //}
        protected Sekil(double x)
        {
            this.X = x;
        }
        public double X { get; set; }
        protected DateTime OlusturmaZamani { get; set; }
        private string Ad = nameof(Sekil);
        public virtual double AlanHesapla()
        {
            
            return X * X;
        }

        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public abstract double KosegenHesapla();
    }
}
