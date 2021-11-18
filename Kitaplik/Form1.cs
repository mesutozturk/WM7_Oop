using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Kitap> _kitaplar = new();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap()
                {
                    Ad = txtAd.Text,
                    YazarAdSoyad = txtYazarAdSoyad.Text,
                    Baski = int.Parse(txtBasim.Text),
                    Yil = int.Parse(txtBasim.Text)
                };
                _kitaplar.Add(kitap);
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void ListeyiDoldur()
        {
            lstKitaplar.Items.Clear();
            foreach (Kitap kitap in _kitaplar)
            {
                lstKitaplar.Items.Add(kitap);
            }
        }
        //Create Read Update Delete
        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            int index = lstKitaplar.SelectedIndex;
            Kitap seciliKitap2 = _kitaplar[index];

            Kitap seciliKitap = lstKitaplar.SelectedItem as Kitap;

            txtAd.Text = seciliKitap.Ad;
            txtBasim.Text = seciliKitap.Baski.ToString();
            txtYil.Text = seciliKitap.Yil.ToString();
            txtYazarAdSoyad.Text = seciliKitap.YazarAdSoyad;
            this.Text = $"{seciliKitap.Ad} - {seciliKitap.EklenmeZamani:g}";

        }
    }
}
