using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        protected void clearTheTextBox(string method)
        {
            if (method == "add")
            {
                tbxName.Clear();
                tbxStockAmount.Clear();
                tbxUnitPrice.Clear();
            }
            else if (method == "update")
            {
                tbxIdUpdate.Clear();
                tbxNameUpdate.Clear();
                tbxStockAmountUpdate.Clear();
                tbxUnitPriceUpdate.Clear();
            }
        }

        protected void LoadTheDataGrid()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dispose direkt bellekten siler. using ile kullanılır.
            //using (EtradeContext context = new EtradeContext())
            //{
            //    dgwProducts.DataSource = context.Products.Add(new Product { Name = "Samsung S6", UnitPrice = 2000, StockAmount = 100 });
            //    context.SaveChanges();
            //    dgwProducts.DataSource = context.Products.ToList();

            //}

            LoadTheDataGrid();

        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = dgwProducts.Rows[e.RowIndex];
            tbxIdUpdate.Text = row.Cells["Id"].Value.ToString();
            tbxIdUpdate.ReadOnly = true;
            tbxNameUpdate.Text = row.Cells["Name"].Value.ToString();
            tbxStockAmountUpdate.Text = row.Cells["StockAmount"].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells["UnitPrice"].Value.ToString();


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            clearTheTextBox("add");
            LoadTheDataGrid();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             _productDal.Update(new Product
             {
                 Id = Convert.ToInt32(tbxIdUpdate.Text),
                 Name = tbxNameUpdate.Text,
                 UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                 StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
             });
            clearTheTextBox("update");
            LoadTheDataGrid();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(tbxIdUpdate.Text)
            });
            clearTheTextBox("update");
            LoadTheDataGrid();
            MessageBox.Show("Deleted!");

        }
    }
}
