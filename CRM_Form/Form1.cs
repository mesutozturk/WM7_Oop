using System;
using System.Windows.Forms;

namespace CRM_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public EmployeeContext Context { get; set; }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            Context = new EmployeeContext();
            var list = Context.EmployeList;
            EmployeeContext.Generate(ref list, 100);
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstEmployee.Items.Clear();
            foreach (var item in Context.EmployeList)
            {
                lstEmployee.Items.Add(item);
            }
        }

        Employee _selectedEmployee;
        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedItem == null) return;

            _selectedEmployee = (Employee)lstEmployee.SelectedItem;
            this.Text = _selectedEmployee.ToString();

        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            var frm = new EmployeeDetailForm();
            frm.SelectedEmployee = _selectedEmployee;
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                ListeyiDoldur();
            }
        }
    }
}