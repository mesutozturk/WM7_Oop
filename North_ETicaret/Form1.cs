using Microsoft.EntityFrameworkCore;
using North_ETicaret.Models;
using System;
using System.Linq;
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
            lstCategory.DataSource = _dbContext.Categories.Include(x => x.Products).ToList();
            lstCategory.DisplayMember = "CategoryName";
        }

        Category _selectedCategory;
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItem == null) return;

            _selectedCategory = (Category)lstCategory.SelectedItem;


            lstProduct.DataSource = _selectedCategory.Products.ToList();
            //lstProduct.DataSource = _dbContext.Products
            //    .Where(x => x.CategoryId == _selectedCategory.CategoryId)
            //    .ToList();
            lstProduct.DisplayMember = "ProductName";
        }
    }
}
