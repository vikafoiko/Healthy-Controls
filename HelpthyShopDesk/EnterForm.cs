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

namespace HelpthyShopDesk
{
    public partial class EnterForm : Form
    {
        ApplicationDbContext _context;
        public EnterForm()
        {
            _context = new ();
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            foreach( var user in _context.Users.ToList() ) { 
                if(user.Login==loginTextBox.Text && user.Password==passwordTextBox.Text)
                {
                    if (user.RoleId == 1)
                    {
                        if (!codeLabel.Visible)
                        {
                            codeLabel.Visible = true;
                            codeTextBox.Visible = true;
                            MessageBox.Show("Введите код");
                            return;
                        }
                        else
                        {
                            foreach(var c in _context.AdminCodes)
                            {
                                if(c.Code.ToString()==codeTextBox.Text && c.Id == user.Id)
                                {
                                    Hide();
                                    var form = new AdminFormcs(user.Id);
                                    form.ShowDialog();
                                    Close();
                                    return;
                                }
                            }
                            MessageBox.Show("Код не правильный");
                            return;
                        }
                    }
                    else if(user.RoleId == 2)
                    {
                        Hide();
                        var form = new ManagerForm(user.Id);
                        form.ShowDialog();
                        this.Close();
                        return;
                    }
                    else if(user.RoleId == 3)
                    {
                        this.Hide();
                        var form=new WorkerForm(user.Id);
                        form.ShowDialog();
                        this.Close();
                        return;
                    }

                }
            
            }
            MessageBox.Show("Неправильный логин или пароль");

        }
    }
}
