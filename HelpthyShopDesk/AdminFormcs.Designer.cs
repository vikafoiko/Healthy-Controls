namespace HelpthyShopDesk
{
    partial class AdminFormcs
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
            InstrumentPanel = new Panel();
            CreateButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            searchTextBox = new TextBox();
            UsersDataGridView = new DataGridView();
            updateButton = new Button();
            InstrumentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InstrumentPanel
            // 
            InstrumentPanel.BackColor = Color.FromArgb(128, 255, 255);
            InstrumentPanel.Controls.Add(updateButton);
            InstrumentPanel.Controls.Add(CreateButton);
            InstrumentPanel.Controls.Add(DeleteButton);
            InstrumentPanel.Controls.Add(SearchButton);
            InstrumentPanel.Controls.Add(searchTextBox);
            InstrumentPanel.Dock = DockStyle.Top;
            InstrumentPanel.Location = new Point(0, 0);
            InstrumentPanel.Name = "InstrumentPanel";
            InstrumentPanel.Size = new Size(544, 75);
            InstrumentPanel.TabIndex = 0;
            InstrumentPanel.Paint += InstrumentPanel_Paint;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(93, 49);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(12, 49);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(12, 11);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(92, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(440, 23);
            searchTextBox.TabIndex = 0;
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Dock = DockStyle.Fill;
            UsersDataGridView.Location = new Point(0, 75);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.ReadOnly = true;
            UsersDataGridView.Size = new Size(544, 386);
            UsersDataGridView.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(174, 49);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 4;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // AdminFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 461);
            Controls.Add(UsersDataGridView);
            Controls.Add(InstrumentPanel);
            MinimumSize = new Size(560, 500);
            Name = "AdminFormcs";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminFormcs Healthy Control";
            InstrumentPanel.ResumeLayout(false);
            InstrumentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel InstrumentPanel;
        private Button SearchButton;
        private TextBox searchTextBox;
        private DataGridView UsersDataGridView;
        private Button CreateButton;
        private Button DeleteButton;
        private Button updateButton;
    }
}