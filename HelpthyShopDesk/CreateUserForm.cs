using HelpthyShopDesk.Data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using HelpthyShopDesk.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.Logging;

namespace HelpthyShopDesk
{
    public partial class CreateUserForm : Form
    {
        bool update = false;
        ApplicationDbContext _context;
        public CreateUserForm()
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
            typeCombobox.SelectedIndex = 2;
        }
        User previous;
        public CreateUserForm(User user):this()
        {
            
            loginTextBox.Text = user.Login;
            passwordTextBox.Text = user.Password;
            nameTextBox.Text = user.Name;
            secondNameTextBox.Text = user.SecondName;
            typeCombobox.SelectedIndex = user.RoleId - 1;
            if (user.Photo != null)
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    mStream.Write(user.Photo, 0, user.Photo.Length);
                    mStream.Seek(0, SeekOrigin.Begin);
                    Bitmap bm = new Bitmap(mStream);
                    photoPictureBox.Image = bm;
                }
                _data = user.Photo;
            }
            if (user.RoleId == 1)
            {
                codeNumbrercUpDown.Value = _context.AdminCodes.Where(p => p.Id == user.Id).ToArray()[0].Code;
            }
            typeCombobox.Enabled = false;
            previous = user;
            update = true;

        }
        byte[]? _data = null;

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCombobox.SelectedIndex == 0)
            {
                codeLabel.Visible = true;
                codeNumbrercUpDown.Visible = true;

            }
            else
            {
                codeNumbrercUpDown.Visible = false;
                codeLabel.Visible = false;
            }
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Jpeg);
                    _data = stream.ToArray();
                }
                photoPictureBox.Image = bitmap;
            }
        }

        private void cancellationButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length > 30)
            {
                MessageBox.Show("Логин должен быть не более 30 символов");
                return;
            }
            if (loginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Логин должен быть заполненым");
                return;
            }
            if (passwordTextBox.Text.Length > 30)
            {
                MessageBox.Show("Пароль должен быть не более 30 символов");
                return;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пароль должен быть заполненым");
                return;
            }
            if (nameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Имя должено быть не более 30 символов");
                return;
            }
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Имя должен быть заполненым");
                return;
            }
            if (secondNameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Фамилия должена быть не более 30 символов");
                return;
            }
            if (secondNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Фамилия должена быть заполненым");
                return;
            }
            User a = new User() {  Login = loginTextBox.Text, Password = passwordTextBox.Text, Name = nameTextBox.Text, SecondName = secondNameTextBox.Text, Photo = _data, RoleId = typeCombobox.SelectedIndex + 1 };
            int id;
            try
            {
                if (update)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var entity = context.Users.FirstOrDefault(p => p.Id == previous.Id);
                        

                        if (entity != null)
                        {
                            entity.Login = loginTextBox.Text;
                            entity.Password = passwordTextBox.Text;
                            entity.Name = nameTextBox.Text;
                            entity.SecondName = secondNameTextBox.Text;
                            entity.Photo = _data;
                            context.Users.Update(entity);
                        }
                        context.SaveChanges();
                       
                    }
                    Close();
                    return;
                }
                using (var context = new ApplicationDbContext())
                {
                    context.Users.Add(a);
                    context.SaveChanges();
                    id = a.Id; // Yes it's here
                }
                if (codeLabel.Visible)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        context.AdminCodes.Add(new AdminCode() { Id = id, Code = (int)codeNumbrercUpDown.Value });
                        context.SaveChanges();

                    }
                }
                MessageBox.Show("Пользователь сохранен");
                Close();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так попробуйте еще раз");
            }

        }
    }
}
