namespace HelpthyShopDesk
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            productDataGridView = new DataGridView();
            panel1 = new Panel();
            buyButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(productDataGridView);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Покупка";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Dock = DockStyle.Fill;
            productDataGridView.Location = new Point(3, 77);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.ReadOnly = true;
            productDataGridView.Size = new Size(786, 342);
            productDataGridView.TabIndex = 1;
            productDataGridView.CellDoubleClick += productDataGridView_CellDoubleClick;
            productDataGridView.DoubleClick += productDataGridView_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(buyButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 74);
            panel1.TabIndex = 0;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(5, 41);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(75, 23);
            buyButton.TabIndex = 2;
            buyButton.Text = "Купить";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(86, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(695, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(5, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 0;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "WorkerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "WorkerForm Healthy Control";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Button searchButton;
        private DataGridView productDataGridView;
        private Button buyButton;
        private TextBox searchTextBox;
    }
}