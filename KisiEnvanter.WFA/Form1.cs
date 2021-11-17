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
                yeniKisi.Ad = "s";
                //yeniKisi.Soyad = "Fıdıl";
                //yeniKisi.Yas = 30;

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
    }
}
