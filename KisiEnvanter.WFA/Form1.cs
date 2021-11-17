using KisiEnvanter.Lib;
using System;
using System.Windows.Forms;

namespace KisiEnvanter.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.Ad = "ahmet ++++nur çebi";
            //yeniKisi.Soyad = "Fıdıl";
            //yeniKisi.Yas = 30;

            this.Text = yeniKisi.Ad;

        }
    }
}
