using System.ComponentModel;
using System.DirectoryServices;
using System.ServiceModel.Syndication;
using BusinessLayer;
using DataAccessLayer;
using Models;
using PresentationLayer;

namespace PoddprojektGrupp24
{
    public partial class Poddbibliotek : Form
    {
        CategoryController catController;
        FeedController feedController;
        ValidationPL validator;
        Serializer<Feed> serializer;
        public Poddbibliotek()
        {
            catController = new CategoryController("Category.xml");
            validator = new ValidationPL("Category.xml");
            feedController = new FeedController("Feed.xml");
            InitializeComponent();
            populateCategories();
            populateListView();
        }

        private void populateCategories()
        {
            cbChangeFeedCategory.Items.Clear(); //Rensar CB:n (listan) och fyller på den på nytt. Användbart när användare gör en förändring i kategorilistan efter instansiering av ett formulär.
            cbFilterCategory.Items.Clear();
            cbAssignFeedCategory.Items.Clear();
            List<Category> list = catController.GetAll();
            foreach (Category category in list)
            {
                checkedListBoxUserCategories.Items.Add(category.Name, false); //Lägger till en item i kategoriboxen. "false" innebär att ett item inte ska vara iklickat efter att det skapats.  
                cbChangeFeedCategory.Items.Add(category);
                cbFilterCategory.Items.Add(category);
                cbAssignFeedCategory.Items.Add(category);
            }
            //Settar DisplayMember så att namnen på kategorierna syns och inte "Models.Category", vilket det hade gjort annars.
            cbChangeFeedCategory.DisplayMember = "Name";
            cbFilterCategory.DisplayMember = "Name";
            cbAssignFeedCategory.DisplayMember = "Name";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1LaggTillKat_Click(object sender, EventArgs e)
        {
            String name = tbNewCategoryName.Text.Trim(); //Ser till att ta bort onädiga spaces i början och slutet av kategorinamnfältet.

            if (validator.isDuplicate(name, "category"))
            {
                string test = null;
                MessageBox.Show($"Kategorinamnet du angav finns redan, eller  är tomt. Försök igen med ett annat namn!", "Valideringsfel");
                return;
            }

            catController.Add(name);
            checkedListBoxUserCategories.Items.Clear(); //Rensar boxen innan den populeras på nytt i nedan metod.
            populateCategories();
            tbNewCategoryName.Clear();
            MessageBox.Show("Kategorin " + name + " har lagts till!", "Ny kategori tillagd");

        }

        private void button2AndraKat_Click(object sender, EventArgs e)
        {
            int index = checkedListBoxUserCategories.SelectedIndex;
            if (index >= 0)
            {
                string newName = tbNewCategoryName.Text.Trim();
                if (!string.IsNullOrEmpty(newName))
                {
                    catController.UpdateItem(newName, index);
                    checkedListBoxUserCategories.Items[index] = newName;
                    checkedListBoxUserCategories.Items.Clear();
                    populateCategories();

                }
            }

        }

        private void button3TaBortKat_Click(object sender, EventArgs e)
        {
            int index = checkedListBoxUserCategories.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Vänligen välj en kategori som du vill ta bort");
                return;
            }

            string message = "Är du säker på att du vill ta bort denna kategori?";
            string title = "Kategori";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);

            if (dialog == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    catController.RemoveItem(index);

                    checkedListBoxUserCategories.Items.Remove(index);

                    MessageBox.Show("Du har tagit bort kategorin!");
                }
            }
            checkedListBoxUserCategories.Items.Clear();
            populateCategories();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rubrik_Click(object sender, EventArgs e)
        {

        }

        private void buttonAterstall_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMinuter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void NamnLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lbUppdateringsfrekv_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void lbFiltreraKategori_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cbFilterCategory.SelectedIndex = -1;
            cbUpdateFrequencyDataGridViewItems.SelectedIndex = -1;
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnAddNewFeed_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text.Trim();
            string name = textBoxFeedName.Text.Trim();
            bool isURLValid = await validator.ValidateRSSUrlAsync(url);
            if (!isURLValid)
            {
                MessageBox.Show("Denna URL är inte ett giltigt RSS-flöde. Vänligen ange en giltig URL.");
                return;
            }
            if (validator.isDuplicate(name, "feed"))
            {
                MessageBox.Show("Ett flöde med detta namn existerar redan. Vänligen ange ett annat namn.");
                return;
            }

            Serializer<Feed> serializer = new Serializer<Feed>();
            SyndicationFeed rssFeed = await serializer.DeserializeRSS(url);

            if (rssFeed == null)
            {
                MessageBox.Show("Misslyckades med att hämta RSS-flöde. Vänligen ange en giltig URL.");
                return;
            }

            string rssTitle = rssFeed.Title.Text ?? "Inget namn";

            var newFeed = new Feed();
            {
                newFeed.Name = name;
                newFeed.Title = rssTitle;
                newFeed.Category = (Category)cbAssignFeedCategory.SelectedItem;
                newFeed.Episodes = new List<Episode>();
            }

            feedController.CreateFeed(name, url, newFeed.Category);
            MessageBox.Show("Podcasten " + newFeed.Title + " har lagts till!");
            populateListView();
        }

        private void populateListView()
        {
            listViewPodd.Items.Clear();
            var feeds = feedController.GetFeeds();

            foreach (Feed feed in feeds)
            {
                ListViewItem listViewItem = new ListViewItem(feed.Name);
                listViewItem.SubItems.Add(feed.Title);
                listViewItem.SubItems.Add(feed.Episodes.Count.ToString());
                listViewItem.SubItems.Add(feed.Category.Name);

                listViewPodd.Items.Add(listViewItem);
            }
            {

            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewPodd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

