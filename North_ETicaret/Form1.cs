using Microsoft.EntityFrameworkCore;
using North_ETicaret.Models;
using North_ETicaret.Repository;
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
        CategoryRepo _categoryRepo = new CategoryRepo();
        private void Form1_Load(object sender, EventArgs e)
        {
            var query = _categoryRepo.Table.Include("Products.Supplier").ToList();

            lstCategory.DataSource = _dbContext.Categories
                .Include(x => x.Products)
                .ThenInclude(x => x.OrderDetails)
                .ToList();
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
        Product _selectedProduct;
        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItem == null) return;

            _selectedProduct = (Product)lstProduct.SelectedItem;
            txtUrunAdi.Text = _selectedProduct.ProductName;
            if (_selectedProduct.UnitPrice.HasValue)
                nUrunFiyati.Value = _selectedProduct.UnitPrice.Value;

            nUrunFiyati.Value = _selectedProduct.UnitPrice.GetValueOrDefault();

            //Supplier productSupplier = _dbContext.Suppliers.FirstOrDefault(x => x.SupplierId == _selectedProduct.SupplierId);
            Supplier productSupplier = _dbContext.Suppliers.Find(_selectedProduct.SupplierId);

            if (productSupplier != null)
            {
                this.Text = productSupplier.CompanyName;
            }

            lstOrderDetails.DataSource = _selectedProduct.OrderDetails.ToList();
            lstOrderDetails.DisplayMember = "OrderId";
        }

        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                CategoryId = _selectedCategory.CategoryId,
                ProductName = txtUrunAdi.Text,
                UnitPrice = nUrunFiyati.Value
            };
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _selectedProduct.ProductName = txtUrunAdi.Text;
            _selectedProduct.UnitPrice = nUrunFiyati.Value;

            _dbContext.SaveChanges();
        }

        private void txtCategoryAra_TextChanged(object sender, EventArgs e)
        {
            var txt = txtCategoryAra.Text.ToLower();
            var result = _dbContext.Categories
                //.Where(x => x.CategoryName.ToLower().Contains(txt) || x.Description.ToLower().Contains(txt))
                .Where(x => x.CategoryName.ToLower().Contains(txt))
                .ToList();
            lstCategory.DataSource = result;
        }
    }
}
