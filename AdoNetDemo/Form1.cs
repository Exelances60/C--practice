using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void clearTextBoxes(string method)
        {
          if(method == "update")
            {
                tbxUpdateId.Clear();
                tbxUpdateName.Clear();
                tbxUpdateStockAmount.Clear();
                tbxUpdateUnitPrice.Clear();
            }
          if(method == "add")
            {
                tbxName.Clear();
                tbxStockAmount.Clear();
                tbxUnitPrice.Clear();
            }
        }
        private void showCustomMessage(string message)
        {
            customMessage customMessage = new customMessage
            {
                message = message
            };
            customMessage.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            clearTextBoxes("add");
            showCustomMessage("Product Added!");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = this.dgwProducts.Rows[e.RowIndex];
                tbxUpdateId.Text = row.Cells["Id"].Value.ToString();
                tbxUpdateId.ReadOnly = true;
                tbxUpdateName.Text = row.Cells["Name"].Value.ToString();
                tbxUpdateUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                tbxUpdateStockAmount.Text = row.Cells["StockAmount"].Value.ToString();
            }  

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(tbxUpdateId.Text),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text)
            });
            LoadProducts();
            clearTextBoxes("update");
            MessageBox.Show("Product Updated!");

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxUpdateId.Text);
            _productDal.Delete(id);
            LoadProducts();
            clearTextBoxes("update");
            MessageBox.Show("Product Deleted!");

       
        }
    }
}
