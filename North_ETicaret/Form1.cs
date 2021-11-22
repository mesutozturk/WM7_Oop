using North_ETicaret.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_ETicaret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            lstCategory.DataSource = _dbContext.Categories.ToList();
            lstCategory.DisplayMember = "CategoryName";
        }
    }
}
