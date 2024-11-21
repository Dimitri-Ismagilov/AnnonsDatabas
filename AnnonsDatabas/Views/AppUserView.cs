using AnnonsDatabas.Repository;
using AnnonsDatabas.Repository.Entities;
using System.Data;

namespace AnnonsDatabas.Views
{
    public partial class AppUserView : Form
    {
        public DataContext advertisements = new();
        public AppUserView(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            UpdateListView();
            PopulateCategoryComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text) || string.IsNullOrEmpty(textBoxPrice.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text) || comboBoxCategory.SelectedIndex == 0  )
            {
                MessageBox.Show("Alla fällt måste vara ifyllda");
                return;
            }

            var advertisement = new Advertisement();
            
            advertisement.AdvertisementTitle = textBoxTitle.Text;
            advertisement.AdvertisementDescription = textBoxDescription.Text;
            decimal price;
            if (decimal.TryParse(textBoxPrice.Text, out price))
            {
                advertisement.Price = price;
            }
            advertisement.PublishedTime = DateTime.Now;
            var selectedCategoryID = (int)comboBoxCategory.SelectedValue;
            advertisement.CategoryID = selectedCategoryID;
            advertisement.UserID = userID;
            advertisements.InsertAdvertisements(advertisement.AdvertisementTitle, advertisement.AdvertisementDescription, advertisement.Price,
                advertisement.PublishedTime, advertisement.CategoryID, advertisement.UserID);
            UpdateListView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text) || string.IsNullOrEmpty(textBoxPrice.Text) ||
                string.IsNullOrEmpty(textBoxPrice.Text) || comboBoxCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Alla fällt måste vara ifyllda");
                return;
            }

            ListViewItem item = listViewResult.SelectedItems[0];
            string advertisementIDText = item.SubItems[6].Text;
            int advertisementID;
            if (int.TryParse(advertisementIDText, out advertisementID))
            {
                advertisementID = Convert.ToInt32(advertisementIDText);
            }

            var advertisement = new Advertisement();

            advertisement.AdvertisementTitle = textBoxTitle.Text;
            advertisement.AdvertisementDescription = textBoxDescription.Text;
            decimal price;
            if (decimal.TryParse(textBoxPrice.Text, out price))
            {
                advertisement.Price = price;
            }
            advertisement.PublishedTime = DateTime.Now;
            var selectedCategoryID = (int)comboBoxCategory.SelectedValue;
            advertisement.CategoryID = selectedCategoryID;
            advertisement.UserID = userID;
            advertisements.UpdateAdvertisement(advertisementID, advertisement.AdvertisementTitle, advertisement.AdvertisementDescription, advertisement.Price,
                advertisement.PublishedTime, advertisement.CategoryID);
           
            UpdateListView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count == 0)
            {
                MessageBox.Show("Du har inte valt någon annons");
                return;
            }
            ListViewItem item = listViewResult.SelectedItems[0];
            string advertisementIDText = item.SubItems[6].Text;
            int advertisementID;
            if (int.TryParse(advertisementIDText, out advertisementID))
            {
                advertisementID = Convert.ToInt32(advertisementIDText);
            }
            advertisements.DeleteAdvertisement(advertisementID);
            UpdateListView();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lagra 
        public int userID;

        private void PopulateCategoryComboBox()
        {
            List<Category> categories = advertisements.GetCategories();

            //Skapar en lista med en tom kategori
            var categoryList = new List<Category>
            {
                new Category { CategoryID = null, CategoryName = "Alla" }
            };
            // Lägger in till de övriga i listan
            categoryList.AddRange(categories);

            comboBoxCategory.Items.Clear();
            comboBoxCategory.DataSource = categoryList;
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
            //Standardval
            comboBoxCategory.SelectedIndex = 0;
        }

        public void UpdateListView()
        {
            var advertisementList = advertisements.GetAdvertisements();
            //Filtrera annonser baserat på UserID
            if (advertisementList != null)
            {
                advertisementList = advertisementList
                    .Where(ad => ad.UserID == userID)
                    .ToList();
            }
            listViewResult.Items.Clear();

            // Lägg till de filtrerade annonserna i ListView
            foreach (var advertisement in advertisementList)
            {
                var item = CreateListViewItem(advertisement);
                listViewResult.Items.Add(item);
            }
            ClearInsert();
        }
        private void ClearInsert()
        {
            textBoxTitle.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
            comboBoxCategory.SelectedIndex = 0;
        }
        private ListViewItem CreateListViewItem(Advertisement advertisement)
        {
            var categories = advertisements.GetCategories();
            var item = new ListViewItem(advertisement.AdvertisementID.ToString());
            item.SubItems.Add(advertisement.AdvertisementTitle);
            item.SubItems.Add(categories
                        .Where(kv => kv.CategoryID == advertisement.CategoryID)
                        .Select(kv => kv.CategoryName)
                        .First());
            item.SubItems.Add(advertisement.Price.ToString());
            item.SubItems.Add(advertisement.PublishedTime.ToString("yyyy-MM-dd HH:mm"));
            item.SubItems.Add(advertisement.AdvertisementDescription);
            item.SubItems.Add(advertisement.AdvertisementID.ToString());

            return item;
        }
        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewResult.SelectedItems[0];
                textBoxTitle.Text = item.SubItems[1].Text;
                comboBoxCategory.Text = item.SubItems[2].Text;
                textBoxPrice.Text = item.SubItems[3].Text;
                textBoxDescription.Text = item.SubItems[5].Text;
            }
        }
    }
}
