using System.Windows.Forms;

namespace CRM_Form
{
    public partial class EmployeeDetailForm : Form
    {
        public Employee SelectedEmployee { get; set; }
        public EmployeeDetailForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailForm_Load(object sender, System.EventArgs e)
        {
            if (SelectedEmployee == null) this.Close();

            txtAd.Text = SelectedEmployee.Name;
            txtFirma.Text = SelectedEmployee.Company;
            txtSoyad.Text = SelectedEmployee.Surname;
            dtpDogumTarihi.Value = SelectedEmployee.BirthDay;
        }

        private void btnVazgeç_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
        {
            SelectedEmployee.Name = txtAd.Text;
            SelectedEmployee.Surname = txtSoyad.Text;
            SelectedEmployee.Company = txtFirma.Text;
            SelectedEmployee.BirthDay = dtpDogumTarihi.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
