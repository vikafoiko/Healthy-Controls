using HelpthyShopDesk.Data;
using HelpthyShopDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpthyShopDesk
{
    public partial class ManagerForm : Form
    {
        ApplicationDbContext _context;
        List<int> catWhite=new List<int>();
        List<int> compWhite=new List<int>();
        public ManagerForm(int userId)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            catWhite = (from e in _context.Categores select e.Id).ToList();
            compWhite = (from e in _context.Company select e.Id).ToList();
            setTable();
            
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            _context.Dispose();
            var form = new CreateProductForm();
            Hide();
            form.ShowDialog();
            Show();

            setTable();
        }
        void setTable()
        {
            _context = new();
            var Products = from p in _context.Products
                           join cat in _context.Categores on p.Category_id equals cat.Id
                           join com in _context.Company on p.Company_id equals com.Id
                           where (p.Name.Contains(searchTextBox.Text) && catWhite.Contains(p.Category_id) && compWhite.Contains(p.Company_id))
                           select new
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Count=p.Count,
                               Category = cat.Name,
                               Company = com.Name,
                               Desctirprion = p.Description
                           };
            productDataGridView.DataSource = Products.ToArray();
            productDataGridView.Columns[0].Visible = false;
        }
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == 1)
            {
                
                _context.Products.Where(p => p.Id.ToString() == productDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ExecuteDelete();

              
                _context.Dispose();
                setTable();
            }
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count == 1)
            {
                Product prod = _context.Products.Where(p => p.Id.ToString() == productDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ToArray()[0];
                _context.Dispose();
                var form = new CreateProductForm(prod);
                Hide();
                form.ShowDialog();
                Show();

                setTable();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var Products = from p in _context.Products
                           join cat in _context.Categores on p.Category_id equals cat.Id
                           join com in _context.Company on p.Company_id equals com.Id
                           where p.Name.Contains(searchTextBox.Text)
                           select new
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Category = cat.Name,
                               Company = com.Name,
                               Desctirprion = p.Description
                           };
            productDataGridView.DataSource = Products.ToArray();
            productDataGridView.Columns[0].Visible = false;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new FilterForm(catWhite, compWhite);
            form.ShowDialog();
            Show();
            setTable();
        }
    }
}
