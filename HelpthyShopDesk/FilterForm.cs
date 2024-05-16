using HelpthyShopDesk.Data;
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
using System.Collections.Immutable;
namespace HelpthyShopDesk
{
    public partial class FilterForm : Form
    {
        ApplicationDbContext _context;
        List<int> cat;
        List<int> comp;
        public FilterForm(List<int> categoryWhiteList, List<int> compnayWhiteList)
        {
            _context = new ApplicationDbContext();
            cat = categoryWhiteList;
            comp = compnayWhiteList;
            InitializeComponent();
            
            List<Category> categories = _context.Categores.ToList();
            List<Company> companies=_context.Company.ToList();
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            categoryDataGridView.Columns.Add(checkColumn);
            checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
    
            CompanyDataGridView.Columns.Add(checkColumn);

            categoryDataGridView.Columns.Insert(0, new DataGridViewTextBoxColumn());
            categoryDataGridView.Columns[0].Name = "Название";
            categoryDataGridView.Columns[0].ReadOnly= true;

            CompanyDataGridView.Columns.Insert(0, new DataGridViewTextBoxColumn());
   
            CompanyDataGridView.Columns[0].Name = "Название";
            CompanyDataGridView.Columns[0].ReadOnly = true;


            categoryDataGridView.Columns.Insert(0, new DataGridViewTextBoxColumn());

            categoryDataGridView.Columns[0].Name = "Id";
            categoryDataGridView.Columns[0].ReadOnly = true;
            categoryDataGridView.Columns[0].Visible = false;

            CompanyDataGridView.Columns.Insert(0, new DataGridViewTextBoxColumn());

            CompanyDataGridView.Columns[0].Name = "Id";
            CompanyDataGridView.Columns[0].ReadOnly = true;
            CompanyDataGridView.Columns[0].Visible = false;
      

            for (int i=0;i<categories.Count;i++)
            {
                int row = categoryDataGridView.Rows.Add();
                categoryDataGridView.Rows[row].Cells["Название"].Value = categories[i].Name;
                categoryDataGridView.Rows[row].Cells["Id"].Value = categories[i].Id;
                if (cat.Contains(categories[i].Id))
                {
                    categoryDataGridView.Rows[row].Cells["X"].Value = true;
                }
                else
                {
                    categoryDataGridView.Rows[row].Cells["X"].Value = true;
                }

            }
            for (int i = 0; i < companies.Count; i++)
            {
                int row = CompanyDataGridView.Rows.Add();
                CompanyDataGridView.Rows[row].Cells["Название"].Value = companies[i].Name;
                CompanyDataGridView.Rows[row].Cells["Id"].Value = companies[i].Id;
                if (comp.Contains(companies[i].Id))
                {
                    CompanyDataGridView.Rows[row].Cells["X"].Value = true;
                }
                else
                {
                    CompanyDataGridView.Rows[row].Cells["X"].Value = true;
                }

            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < categoryDataGridView.Rows.Count; i++)
            {
                if (cat.Contains((int)categoryDataGridView.Rows[i].Cells["Id"].Value)&& !(bool)categoryDataGridView.Rows[i].Cells["X"].Value )
                {
                    cat.Remove((int)categoryDataGridView.Rows[i].Cells["Id"].Value);
                }
                if(!cat.Contains((int)categoryDataGridView.Rows[i].Cells["Id"].Value) && (bool)categoryDataGridView.Rows[i].Cells["X"].Value)
                {
                    cat.Add((int)categoryDataGridView.Rows[i].Cells["Id"].Value);
                }
            }
            for (int i = 0; i < CompanyDataGridView.Rows.Count; i++)
            {
                if (comp.Contains((int)CompanyDataGridView.Rows[i].Cells["Id"].Value) && !(bool)CompanyDataGridView.Rows[i].Cells["X"].Value)
                {
                    comp.Remove((int)CompanyDataGridView.Rows[i].Cells["Id"].Value);
                }
                if (!comp.Contains((int)CompanyDataGridView.Rows[i].Cells["Id"].Value) && (bool)CompanyDataGridView.Rows[i].Cells["X"].Value)
                {
                    comp.Add((int)CompanyDataGridView.Rows[i].Cells["Id"].Value);
                }
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
