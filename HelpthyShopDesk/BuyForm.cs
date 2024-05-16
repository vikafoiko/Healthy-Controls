using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpthyShopDesk.Data;
using HelpthyShopDesk.Models;
namespace HelpthyShopDesk
{
    public partial class BuyForm : Form
    {
        ApplicationDbContext _context;

        bool update = false;
        byte[]? _data;
        Product prev;
        Func<int, int,int> addFunc;
        public BuyForm(Product product,Func<int,int,int> add)
        {
            InitializeComponent();
            addFunc = add;
            prev = product;
            _data = product.Photo;

            nameTextBox.Text = product.Name;
            descriptionRichTextBox.Text = product.Description;
            costNumberUpDown.Value = product.Price;

            costNumberUpDown.ReadOnly = true;

            nameTextBox.ReadOnly = true;
            descriptionRichTextBox.ReadOnly = true;
            costNumberUpDown.ReadOnly = true;

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
        }

        private void buyButton_Click(object sender, EventArgs e)
        {

            addFunc((int)prev.Id, (int)countNumbericUpDown.Value);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
