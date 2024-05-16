using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpthyShopDesk.Data;
using HelpthyShopDesk.Models;
using Microsoft.VisualBasic.ApplicationServices;
namespace HelpthyShopDesk
{
    public partial class CreateProductForm : Form
    {
        ApplicationDbContext _context;
        Dictionary<int, int> companyIndex = new Dictionary<int, int>();
        Dictionary<int, int> categoryIndex = new Dictionary<int, int>();
        bool update = false;
        byte[]? _data;
        Product prev;
        public CreateProductForm()
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
            var arr_com = _context.Company.ToArray();
            for (int i = 0; i < arr_com.Length; i++)
            {
                companyComboBox.Items.Add(arr_com[i].Name);
                companyIndex.Add(i, arr_com[i].Id);
            }
            var arr_cat = _context.Categores.ToArray();
            for (int i = 0; i < arr_cat.Length; i++)
            {
                categoryComboBox.Items.Add(arr_cat[i].Name);
                categoryIndex.Add(i, arr_cat[i].Id);
            }
        }

        public CreateProductForm(Product product) : this()
        {
            prev = product;
            _data = product.Photo;

            nameTextBox.Text = product.Name;
            descriptionRichTextBox.Text = product.Description;
            costNumberUpDown.Value = product.Price;
            countComboBox.Text = product.Count.ToString();
            foreach (int key in categoryIndex.Keys)
            {
                if (categoryIndex[key] == product.Category_id)
                {
                    categoryComboBox.SelectedIndex = key;
                    break;
                }
            }
            foreach (int key in companyIndex.Keys)
            {
                if (companyIndex[key] == product.Company_id)
                {
                    companyComboBox.SelectedIndex = key;
                    break;
                }
            }
            if (product.Photo != null)
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    mStream.Write(product.Photo, 0, product.Photo.Length);
                    mStream.Seek(0, SeekOrigin.Begin);
                    Bitmap bm = new Bitmap(mStream);
                    productPictureBox.Image = bm;
                }
                _data = product.Photo;
            }
            update = true;

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле названия продукта пустое");
                return;
            }
            if (nameTextBox.Text.Length > 30)
            {
                MessageBox.Show("Название продукта не должно превышать 30 символов");
                return;
            }

            if (descriptionRichTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле описание продукта пустое");
                return;
            }
            if (descriptionRichTextBox.Text.Length > 150)
            {
                MessageBox.Show("Описание продукта не должно превышать 150 символов");
                return;
            }
            try
            {
                if (update)
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var entity = context.Products.FirstOrDefault(p => p.Id == prev.Id);


                        if (entity != null)
                        {
                            entity.Name = nameTextBox.Text;
                            entity.Description = descriptionRichTextBox.Text;
                            entity.Company_id = companyIndex[companyComboBox.SelectedIndex];
                            entity.Category_id = categoryIndex[categoryComboBox.SelectedIndex];
                            entity.Photo = _data;
                            context.Products.Update(entity);
                        }
                        context.SaveChanges();

                    }
                    Close();
                    
                    return;
                }
                Product product = new Product()
                {
                    Name = nameTextBox.Text,
                    Description = descriptionRichTextBox.Text,
                    Category_id = categoryIndex[categoryComboBox.SelectedIndex],
                    Company_id = companyIndex[companyComboBox.SelectedIndex],
                    Count = 0,
                    Price = costNumberUpDown.Value
                };
                _context.Products.Add(product);
                Close();
                _context.SaveChanges();
                return;
            }

            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                productPictureBox.Image = bitmap;
            }
        }
    }
}
