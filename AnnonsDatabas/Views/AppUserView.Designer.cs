namespace AnnonsDatabas.Views
{
    partial class AppUserView
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
            textBoxTitle = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            comboBoxCategory = new ComboBox();
            labelAdvertisement = new Label();
            labelCreateNewAdvertisement = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonLogOut = new Button();
            listViewResult = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(54, 154);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Titel";
            textBoxTitle.Size = new Size(555, 35);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(54, 230);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Pris";
            textBoxPrice.Size = new Size(218, 35);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(54, 317);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Beskrivning";
            textBoxDescription.Size = new Size(555, 378);
            textBoxDescription.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Möbler & heminredning", "Datorer & TV-spel", "Ljud & bild", "Telefoner & tillbehör", "Accessoarer & klockor", "Verktyg", "Cyklar" });
            comboBoxCategory.Location = new Point(338, 227);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(271, 38);
            comboBoxCategory.TabIndex = 3;
            // 
            // labelAdvertisement
            // 
            labelAdvertisement.AutoSize = true;
            labelAdvertisement.Location = new Point(1404, 85);
            labelAdvertisement.Name = "labelAdvertisement";
            labelAdvertisement.Size = new Size(148, 30);
            labelAdvertisement.TabIndex = 10;
            labelAdvertisement.Text = "Dina annonser";
            // 
            // labelCreateNewAdvertisement
            // 
            labelCreateNewAdvertisement.AutoSize = true;
            labelCreateNewAdvertisement.Location = new Point(52, 108);
            labelCreateNewAdvertisement.Name = "labelCreateNewAdvertisement";
            labelCreateNewAdvertisement.Size = new Size(199, 30);
            labelCreateNewAdvertisement.TabIndex = 0;
            labelCreateNewAdvertisement.Text = "Skapa en ny annons";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1261, 501);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(435, 40);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Lägg till";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(1261, 564);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(435, 40);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1261, 630);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(435, 40);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(1261, 755);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(435, 40);
            buttonLogOut.TabIndex = 8;
            buttonLogOut.Text = "Logga ut";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // listViewResult
            // 
            listViewResult.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeaderTitle, columnHeaderDate });
            listViewResult.FullRowSelect = true;
            listViewResult.GridLines = true;
            listViewResult.Location = new Point(1261, 118);
            listViewResult.Name = "listViewResult";
            listViewResult.Size = new Size(435, 377);
            listViewResult.TabIndex = 9;
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
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Datum";
            columnHeaderDate.Width = 200;
            // 
            // AppUserView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1812, 863);
            Controls.Add(listViewResult);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(labelCreateNewAdvertisement);
            Controls.Add(labelAdvertisement);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxTitle);
            Name = "AppUserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private ComboBox comboBoxCategory;
        private Label labelAdvertisement;
        private Label labelCreateNewAdvertisement;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonLogOut;
        private ListView listViewResult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderDate;
    }
}