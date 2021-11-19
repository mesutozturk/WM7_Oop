using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Sekil> sekiller = new List<Sekil>();
        private Sekil seciliSekil;
        private void Form1_Load(object sender, EventArgs e)
        {
            double sonuc = 0;
            Dikdortgen dik1 = new Dikdortgen(3, 4);
            dik1.X = 3;
            dik1.Y = 4;

            sekiller.Add(dik1);
            seciliSekil = dik1;

            sonuc = dik1.AlanHesapla();
            sonuc = dik1.CevreHesapla();
            sonuc = dik1.KosegenHesapla();

            sonuc = seciliSekil.AlanHesapla();
            sonuc = seciliSekil.CevreHesapla();
            sonuc = seciliSekil.KosegenHesapla();

            Kare kare1 = new Kare(5);
            kare1.X = 5;
            seciliSekil = kare1;
            sekiller.Add(kare1);
            sonuc = kare1.AlanHesapla();
            sonuc = kare1.CevreHesapla();
            sonuc = kare1.KosegenHesapla();

            foreach (Sekil sekil in sekiller)
            {
                double kkkkk = sekil.AlanHesapla();
                if (sekil is Dikdortgen dikdortgen)
                {

                }
            }


            //Sekil sekil1 = new Sekil();
            //sekil1.X = 10;

            //sonuc = sekil1.AlanHesapla();
            //sonuc = sekil1.CevreHesapla();
            //sonuc = sekil1.KosegenHesapla();

            Console.WriteLine();
        }

        private Random rnd = new Random();
        private int counter = 0;
        private void btnUret_Click(object sender, EventArgs e)
        {
            Sekil uretilecek;
            if (counter % 3 == 0)
            {
                uretilecek = new Kare(rnd.Next(3, 59));
                uretilecek.X = rnd.Next(3, 59);
            }
            else if (counter % 3 == 1)
            {
                uretilecek = new Dikdortgen(rnd.Next(5, 98), rnd.Next(5, 98))
                {
                    X = rnd.Next(5, 98),
                    Y = rnd.Next(5, 98)
                };
            }
            else
            {
                uretilecek = new DikUcgen(5, 12);
            }
            sekiller.Add(uretilecek);
            counter++;
        }

        /*
         * ad soyad telefon tckn 
         * öğrenci
         * öğretmen
         * personel
         * veli
         * öğretmen ve personel maaş
         * personelin maaşı sabit
         * öğretmen maaşı saat ücreti üzerinden hesaplanacak
         */
    }
}