namespace AnnonsDatabas.Views
{
    partial class AdvertisementDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSearch = new GroupBox();
            buttonSearch = new Button();
            comboBoxSearchCategory = new ComboBox();
            textBoxSearchTitle = new TextBox();
            buttonLogin = new Button();
            listViewResult = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderCategory = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            comboBoxOrderBy = new ComboBox();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            textBoxCategory = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDate = new TextBox();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Controls.Add(comboBoxSearchCategory);
            groupBoxSearch.Controls.Add(textBoxSearchTitle);
            groupBoxSearch.Location = new Point(27, 20);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(492, 146);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Sök";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(351, 84);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 40);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Location = new Point(6, 86);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(317, 38);
            comboBoxSearchCategory.TabIndex = 3;
            // 
            // textBoxSearchTitle
            // 
            textBoxSearchTitle.Location = new Point(6, 34);
            textBoxSearchTitle.Name = "textBoxSearchTitle";
            textBoxSearchTitle.PlaceholderText = "Sök på Titel";
            textBoxSearchTitle.Size = new Size(476, 35);
            textBoxSearchTitle.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(1612, 766);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(131, 40);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Logga in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // listViewResult
            // 
            listViewResult.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeaderTitle, columnHeaderCategory, columnHeaderPrice, columnHeaderDate });
            listViewResult.FullRowSelect = true;
            listViewResult.GridLines = true;
            listViewResult.Location = new Point(27, 251);
            listViewResult.Name = "listViewResult";
            listViewResult.Size = new Size(796, 459);
            listViewResult.TabIndex = 6;
            listViewResult.UseCompatibleStateImageBehavior = false;
            listViewResult.View = View.Details;
            listViewResult.SelectedIndexChanged += listViewResult_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 0;
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Titel";
            columnHeaderTitle.Width = 230;
            // 
            // columnHeaderCategory
            // 
            columnHeaderCategory.Text = "Kategori";
            columnHeaderCategory.Width = 270;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Pris";
            columnHeaderPrice.Width = 70;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Datum";
            columnHeaderDate.Width = 190;
            // 
            // comboBoxOrderBy
            // 
            comboBoxOrderBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderBy.FormattingEnabled = true;
            comboBoxOrderBy.Items.AddRange(new object[] { "", "Senaste", "Äldst", "Billigast", "Dyrast" });
            comboBoxOrderBy.Location = new Point(27, 188);
            comboBoxOrderBy.Name = "comboBoxOrderBy";
            comboBoxOrderBy.Size = new Size(212, 38);
            comboBoxOrderBy.TabIndex = 4;
            comboBoxOrderBy.SelectedIndexChanged += comboBoxOrderBy_SelectedIndexChanged;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = SystemColors.Control;
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Location = new Point(1055, 251);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(688, 459);
            textBoxDescription.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = SystemColors.Control;
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxTitle.Location = new Point(1055, 54);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(688, 28);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BackColor = SystemColors.Control;
            textBoxCategory.BorderStyle = BorderStyle.None;
            textBoxCategory.Location = new Point(1055, 109);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.ReadOnly = true;
            textBoxCategory.Size = new Size(688, 28);
            textBoxCategory.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.Control;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Location = new Point(1055, 177);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(341, 28);
            textBoxPrice.TabIndex = 9;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = SystemColors.Control;
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Location = new Point(1402, 177);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(341, 28);
            textBoxDate.TabIndex = 10;
            // 
            // AdvertisementDatabase
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1812, 863);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxDescription);
            Controls.Add(comboBoxOrderBy);
            Controls.Add(listViewResult);
            Controls.Add(buttonLogin);
            Controls.Add(groupBoxSearch);
            Name = "AdvertisementDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Annons Databas";
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxSearch;
        private TextBox textBoxSearchTitle;
        private Button buttonSearch;
        private ComboBox comboBoxSearchCategory;
        private Button buttonLogin;
        private ListView listViewResult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderCategory;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderDate;
        private ComboBox comboBoxOrderBy;
        private TextBox textBoxDescription;
        private TextBox textBoxTitle;
        private TextBox textBoxCategory;
        private TextBox textBoxPrice;
        private TextBox textBoxDate;
    }
}
