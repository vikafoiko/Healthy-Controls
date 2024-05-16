using HelpthyShopDesk.Data;
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
using HelpthyShopDesk.Models;
namespace HelpthyShopDesk
{
    public partial class AdminFormcs : Form
    {
        ApplicationDbContext _context;
        public AdminFormcs(int userid)
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
            UsersDataGridView.DataSource = _context.Users.ToArray();
            UsersDataGridView.Columns[0].Visible = false;
            UsersDataGridView.Columns["Photo"].Visible = false;
        }

        private void InstrumentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UsersDataGridView.DataSource = _context.Users.Where(p => p.Login.Contains(searchTextBox.Text)).ToArray();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count == 1)
            {
                _context.Users.Where(p => p.Id.ToString() == UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ExecuteDelete();

                UsersDataGridView.DataSource = _context.Users.ToArray();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new CreateUserForm();
            form.ShowDialog();
            Show();
            UsersDataGridView.DataSource = _context.Users.ToArray();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count == 1)
            {
               User user=_context.Users.Where(p => p.Id.ToString() == UsersDataGridView.SelectedRows[0].Cells[0].Value.ToString()).ToArray()[0];
                _context.Dispose();
                var form = new CreateUserForm(user);
                Hide();
                form.ShowDialog();
                Show();
                _context =new  ApplicationDbContext();
              
                UsersDataGridView.DataSource = _context.Users.ToArray();
            }
        }
    }
}
