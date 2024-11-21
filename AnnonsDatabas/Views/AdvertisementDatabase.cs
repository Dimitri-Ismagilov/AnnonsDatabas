using AnnonsDatabas.Repository;
using AnnonsDatabas.Repository.Entities;

namespace AnnonsDatabas.Views
{
    public partial class AdvertisementDatabase : Form
    {
        public DataContext advertisements = new();

        public AdvertisementDatabase()
        {
            InitializeComponent();
            UpdateListViewResult();
            PopulateCategoryComboBox();
            this.AcceptButton = buttonSearch;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValueTitle = textBoxSearchTitle.Text;
            int? searchValueCategory = (int?)comboBoxSearchCategory.SelectedValue;
            UpdateListViewResult(searchValueTitle, searchValueCategory);
        }

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

            comboBoxSearchCategory.Items.Clear();
            comboBoxSearchCategory.DataSource = categoryList;
            comboBoxSearchCategory.DisplayMember = "CategoryName";
            comboBoxSearchCategory.ValueMember = "CategoryID";
            //Standardval
            comboBoxSearchCategory.SelectedIndex = 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchValueTitle = textBoxSearchTitle.Text;
            int? searchValueCategoryID = (int?)comboBoxSearchCategory.SelectedValue;

            UpdateListViewResult(searchValueTitle, searchValueCategoryID, comboBoxOrderBy.SelectedIndex);
        }
        public void UpdateListViewResult(string searchValueTitle = "", int? searchValueCategoryID = null, int orderBy = 0)
        {

            // Hämta alla annonser
            var advertisementList = advertisements.GetAdvertisements();

            // Filtrera annonser baserat på titel
            if (!string.IsNullOrEmpty(searchValueTitle))
            {
                advertisementList = advertisementList
                    .Where(ad => ad.AdvertisementTitle.Contains(searchValueTitle, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Filtrera annonser på Category
            if (searchValueCategoryID.HasValue)
            {
                advertisementList = advertisementList
                    .Where(ad => ad.CategoryID == searchValueCategoryID.Value)
                    .ToList();
            }

            //Sats som styr storteringen
            switch (orderBy)
            {
                case 1:
                    advertisementList = advertisementList.OrderBy(ad => ad.PublishedTime).ToList();
                    break;
                case 2:
                    advertisementList = advertisementList.OrderByDescending(ad => ad.PublishedTime).ToList();
                    break;
                case 3:
                    advertisementList = advertisementList.OrderBy(ad => ad.Price).ToList();
                    break;
                case 4:
                    advertisementList = advertisementList.OrderByDescending(ad => ad.Price).ToList();
                    break;
            }
            listViewResult.Items.Clear();

            // Lägg till de filtrerade annonserna i ListView
            foreach (var advertisement in advertisementList)
            {
                var item = CreateListViewItem(advertisement);
                listViewResult.Items.Add(item);
            }
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

            return item;
        }

        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewResult.SelectedItems[0];
                textBoxTitle.Text = item.SubItems[1].Text;
                textBoxCategory.Text = item.SubItems[2].Text;
                textBoxPrice.Text = item.SubItems[3].Text;
                textBoxDate.Text = item.SubItems[4].Text;
                textBoxDescription.Text = item.SubItems[5].Text;

            }
            
        }
    }
}
