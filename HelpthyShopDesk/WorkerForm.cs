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
    public partial class WorkerForm : Form
    {
        ApplicationDbContext _context;
        Dictionary<int,int> shopingList= new Dictionary<int,int>();
        int userid;
        public WorkerForm(int userId)
        {
            userid= userId;
            _context = new ApplicationDbContext();
            InitializeComponent();
            setTable();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _context.Dispose();
            setTable();
        }
        void setTable()
        {
            _context = new();
            var Products = from p in _context.Products
                           join cat in _context.Categores on p.Category_id equals cat.Id
                           join com in _context.Company on p.Company_id equals com.Id
                           where p.Name.Contains(searchTextBox.Text)
                           select new
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Count = p.Count,
                               Category = cat.Name,
                               Company = com.Name,
                               Desctirprion = p.Description
                           };
            productDataGridView.DataSource = Products.ToArray();
            productDataGridView.Columns[0].Visible = false;
            for (int i = 0; i < productDataGridView.Columns.Count; i++)
            {
                productDataGridView.Columns[i].ReadOnly = true;
            }

        }
        int shop(int id,int count)
        {
            shopingList[id] = count;
            return shopingList[id];
        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            Order order=new Order() { WorkerId=userid,Date=DateTime.Now};
            int orderId;
            using (var context = new ApplicationDbContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
                orderId = order.Id; // Yes it's here
            }
            foreach (int a in shopingList.Keys)
            {
                Product prod = _context.Products.FirstOrDefault(p => p.Id == a);
                if (prod != null)
                {
                    prod.Count += shopingList[a];
                    Transaction transaction = new Transaction() { Count = shopingList[a], OrderId = orderId, ProductId = a };
                    _context.Transactions.Add(transaction);
                }
            }
            _context.SaveChanges();
            _context.Dispose();
            setTable();
        }

        private void productDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productDataGridView.CellDoubleClick -= productDataGridView_CellDoubleClick;
         
                int row = e.RowIndex;
                Product prod = _context.Products.Where(p => p.Id.ToString() == productDataGridView[0, row].Value.ToString()).ToArray()[0];
                _context.Dispose();
                var form = new BuyForm(prod, shop);
                Hide();
                form.ShowDialog();
                Show();
                setTable();
            productDataGridView.CellDoubleClick += productDataGridView_CellDoubleClick; 

        }
    }
}
