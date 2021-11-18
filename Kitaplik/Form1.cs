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
        private Kitap _seciliKitap;
        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItem == null) return;

            int index = lstKitaplar.SelectedIndex;
            Kitap seciliKitap2 = _kitaplar[index];

            _seciliKitap = lstKitaplar.SelectedItem as Kitap;

            txtAd.Text = _seciliKitap.Ad;
            txtBasim.Text = _seciliKitap.Baski.ToString();
            txtYil.Text = _seciliKitap.Yil.ToString();
            txtYazarAdSoyad.Text = _seciliKitap.YazarAdSoyad;
            this.Text = $"{_seciliKitap.Ad} - {_seciliKitap.EklenmeZamani:g}";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _seciliKitap.Ad = txtAd.Text;
            _seciliKitap.Baski = int.Parse(txtBasim.Text);
            _seciliKitap.Yil = int.Parse(txtYil.Text);
            _seciliKitap.YazarAdSoyad = txtYazarAdSoyad.Text;

            ListeyiDoldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_seciliKitap == null) return;

            if (MessageBox.Show($"{_seciliKitap} adlı kitabı silmek istediğinize emin misiniz?", $"Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _kitaplar.Remove(_seciliKitap);
                MessageBox.Show($"{_seciliKitap} silinmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _seciliKitap = null;
                ListeyiDoldur();
            }
        }
    }
}
