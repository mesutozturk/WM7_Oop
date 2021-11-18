using KisiEnvanter.Lib;
using System;
using System.Net.Mime;
using System.Windows.Forms;

namespace KisiEnvanter.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();

            /*
             * try-catch 
             * kullanıcı veri girişlerinde
             * tip dönüşümlerinde
             * db işlemlerinde
             * dosya işlemlerinde
             * sunucu isteklerinde
             */
            try
            {
                yeniKisi.Ad = "sdfds";
                //yeniKisi.Soyad = "Fıdıl";
                //yeniKisi.Yas = 30;
                yeniKisi.Email = "mesutozturk@wissenakademie.com";
                this.Text = yeniKisi.Ad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '@')
            {
                txtEmail.Text += e.KeyChar.ToString().ToLower();
                e.Handled = true;
            }
            else if (e.KeyChar == 8 && txtEmail.Text.Length > 1)
            {
                txtEmail.Text = txtEmail.Text.Remove(txtEmail.Text.Length - 1, 1);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSihir_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            a = b;
            b = 20;
            //a 10 - 5
            Console.WriteLine(a);

            Sihir s1 = new Sihir();
            Sihir s2 = new Sihir();
            s1.A = 5;
            s2.A = 10;
            s1 = s2;
            s2.A = 20;
            //s1.A ? 20 - 10 - 5
            Console.WriteLine(s1.A);

            //Array.Resize();
            //int sayi = 0;
            if (int.TryParse("1234",out int sayi))
            {
                
            }
        }
    }
}
