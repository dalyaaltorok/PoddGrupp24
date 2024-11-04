using System.ComponentModel;
using System.DirectoryServices;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
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
        ValidationPL categoryValidator;
        ValidationPL feedValidator;
        Serializer<Feed> serializer;
        Feed selectedFeed;
        public Poddbibliotek()
        {
            catController = new CategoryController("Category.xml");
            categoryValidator = new ValidationPL("Category.xml");
            feedController = new FeedController("Feed.xml");
            feedValidator = new("Feed.xml");
            selectedFeed = null;
            InitializeComponent();
            populateCategories();
            populateListView();
        }

        private void populateCategories()
        {
            cbChangeFeedCategory.Items.Clear(); //Rensar CB:n (listan) och fyller p� den p� nytt. Anv�ndbart n�r anv�ndare g�r en f�r�ndring i kategorilistan efter instansiering av ett formul�r.
            cbFilterCategory.Items.Clear();
            cbAssignFeedCategory.Items.Clear();
            List<Category> list = catController.GetAll();
            foreach (Category category in list)
            {
                checkedListBoxUserCategories.Items.Add(category.Name, false); //L�gger till en item i kategoriboxen. "false" inneb�r att ett item inte ska vara iklickat efter att det skapats.  
                cbChangeFeedCategory.Items.Add(category);
                cbFilterCategory.Items.Add(category);
                cbAssignFeedCategory.Items.Add(category);
            }
            //Settar DisplayMember s� att namnen p� kategorierna syns och inte "Models.Category", vilket det hade gjort annars.
            cbChangeFeedCategory.DisplayMember = "Name";
            cbFilterCategory.DisplayMember = "Name";
            cbAssignFeedCategory.DisplayMember = "Name";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1LaggTillKat_Click(object sender, EventArgs e)
        {
            String name = tbNewCategoryName.Text.Trim(); //Ser till att ta bort on�diga spaces i b�rjan och slutet av kategorinamnf�ltet.

            if (categoryValidator.isDuplicate(name, "category"))
            {
                string test = null;
                MessageBox.Show($"Kategorinamnet du angav finns redan, eller  �r tomt. F�rs�k igen med ett annat namn!", "Valideringsfel");
                return;
            }

            catController.Add(name);
            checkedListBoxUserCategories.Items.Clear(); //Rensar boxen innan den populeras p� nytt i nedan metod.
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
                MessageBox.Show("V�nligen v�lj en kategori som du vill ta bort");
                return;
            }

            string message = "�r du s�ker p� att du vill ta bort denna kategori?";
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
            try
            {
                if (feedValidator.isDuplicate(name, "feed"))
                {
                    MessageBox.Show("Ett fl�de med detta namn existerar redan. V�nligen ange ett annat namn.", "Duplicerat fl�de");
                    return;
                }

                bool isURLValid = await feedValidator.ValidateRSSUrlAsync(url);
                if (!isURLValid)
                {
                    MessageBox.Show("Denna URL �r inte ett giltigt RSS-fl�de. V�nligen ange en giltig URL.", "Valideringsfel");
                    return;
                }

                if (cbAssignFeedCategory.SelectedItem == null)
                {
                    MessageBox.Show("V�nligen v�lj en kategori f�r podcasten. Du kan skapa en kategori under 'Hantera Kategori'", "Valideringsfel");
                    return;
                }

                Serializer<Feed> serializer = new Serializer<Feed>();
                SyndicationFeed rssFeed = await serializer.DeserializeRSS(url);

                if (rssFeed == null)
                {
                    MessageBox.Show("Misslyckades med att h�mta RSS-fl�de. V�nligen ange en giltig URL.", "Valideringsfel");
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

                await feedController.CreateFeed(name, url, newFeed.Category);
                MessageBox.Show($"Podcasten {newFeed.Title} har lagts till!", "Ny podcast tillagd!");
                populateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod n�r podcasten skulle l�ggas till: '{ex.Message}'", "Ok�nt fel");
            }
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
            if (listViewPodd.SelectedItems.Count > 0)
            {
                DisplayEpisodes();
            }

            else
            {
                listBoxEpisodes.Items.Clear();
                richTextBoxEpisodeDescription.Clear();
            }
            
            if(listViewPodd.SelectedItems.Count > 0)
{
                //selectedItem h�mtar ut items i listView, d�r det f�rsta itemet i listan f�r index 0 eftersom det blir det f�rsta i listan
                var selectedItem = listViewPodd.SelectedItems[0];

                //hittar feedet (podden) genom namnet
                string feedName = selectedItem.Text;
                selectedFeed = feedController.getFeed(feedName);
            }
else
            {
                //om ingenting �r i-klickat s� blir det null
                selectedFeed = null;
            }
        }
        private async void DisplayEpisodes()
        {
            string podcastFeedName = listViewPodd.SelectedItems[0].SubItems[0].Text;
            Feed feed = feedController.getFeed(podcastFeedName);

            List<Episode> episodes = feed.Episodes;

            listBoxEpisodes.Items.Clear();
            foreach (Episode episode in episodes)
            {
                //listBoxEpisodes.Items.Add(episode.Name);
                ListViewItem item = new ListViewItem(episode.Name);
                listBoxEpisodes.Items.Add(item);

            }
        }
        private void DisplayDescription()
        {
            //h�mta det valda avsnittets name fr�n listviewn (listBoxEpisodes orkade inte �ndra namn)
            string selectedEPName = listBoxEpisodes.SelectedItems[0].Text;

            //h�mtar aktuella poddens name fr�n listViewPodd
            string feedName = listViewPodd.SelectedItems[0].SubItems[0].Text;
            Feed feed = feedController.getFeed(feedName);

            //hittar avsnittet i feedet som matchar det valda namnet
            Episode selectedEp = feed.Episodes.FirstOrDefault(ep => ep.Name == selectedEPName);

            if (selectedEp != null)
            {
                richTextBoxEpisodeDescription.Text = Regex.Replace(selectedEp.Description, "<.*?>", String.Empty);
            }
            else
            {
                richTextBoxEpisodeDescription.Clear();
            }

        }

        private void listBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEpisodes.SelectedItems.Count > 0)
            {
                DisplayDescription();
            }
            else
            {
                richTextBoxEpisodeDescription.Clear();
            }
        }
    }
}

