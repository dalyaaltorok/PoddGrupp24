namespace PoddprojektGrupp24
{
    partial class Poddbibliotek
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poddbibliotek));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Rubrik = new Label();
            lbKategori = new Label();
            tbNewCategoryName = new TextBox();
            btnLaggTillKat = new Button();
            btnAndraKat = new Button();
            btnTaBortKat = new Button();
            richTextBoxEpisodeDescription = new RichTextBox();
            lbAvsnitt = new Label();
            listBoxEpisodes = new ListBox();
            lbLaggTillPoddcast = new Label();
            textBoxFeedName = new TextBox();
            cbUpdateFrequencyDataGridViewItems = new ComboBox();
            cbAssignFeedCategory = new ComboBox();
            textBoxURL = new TextBox();
            btnAddNewFeed = new Button();
            btnChangeFeedName = new Button();
            cbChangeFeedCategory = new ComboBox();
            dataGridViewPodcastList = new DataGridView();
            checkedListBoxUserCategories = new CheckedListBox();
            lbTilldelaKategori = new Label();
            lbUpdateringsfrekv = new Label();
            lbFiltreraKategori = new Label();
            lbAndraFiltrera = new Label();
            tbChangeFeedName = new TextBox();
            toolTipChangeFeedCategory = new ToolTip(components);
            btnRemoveSelectedFeed = new Button();
            btnResetFilters = new Button();
            btnChangeCategory = new Button();
            toolTipRemoveSelectedFeed = new ToolTip(components);
            cbFilterCategory = new ComboBox();
            lbAvsnittsbeskrivning = new Label();
            toolTipFrivilligKategori = new ToolTip(components);
            toolTipChangeFeedName = new ToolTip(components);
            toolTipResetFilters = new ToolTip(components);
            lbKategoriLabel = new Label();
            lbAvsnittsbesk = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodcastList).BeginInit();
            SuspendLayout();
            // 
            // Rubrik
            // 
            resources.ApplyResources(Rubrik, "Rubrik");
            Rubrik.ForeColor = Color.LightCoral;
            Rubrik.Name = "Rubrik";
            Rubrik.Click += Rubrik_Click;
            // 
            // lbKategori
            // 
            lbKategori.ForeColor = Color.Firebrick;
            resources.ApplyResources(lbKategori, "lbKategori");
            lbKategori.Name = "lbKategori";
            lbKategori.Click += label1_Click;
            // 
            // tbNewCategoryName
            // 
            resources.ApplyResources(tbNewCategoryName, "tbNewCategoryName");
            tbNewCategoryName.Name = "tbNewCategoryName";
            tbNewCategoryName.TextChanged += textBox1_TextChanged;
            // 
            // btnLaggTillKat
            // 
            btnLaggTillKat.BackColor = Color.LightCoral;
            btnLaggTillKat.FlatAppearance.BorderColor = Color.LightCoral;
            btnLaggTillKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLaggTillKat, "btnLaggTillKat");
            btnLaggTillKat.ForeColor = Color.FromArgb(64, 0, 0);
            btnLaggTillKat.Name = "btnLaggTillKat";
            btnLaggTillKat.UseVisualStyleBackColor = false;
            btnLaggTillKat.Click += button1LaggTillKat_Click;
            // 
            // btnAndraKat
            // 
            btnAndraKat.BackColor = Color.LightCoral;
            btnAndraKat.FlatAppearance.BorderColor = Color.LightCoral;
            btnAndraKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAndraKat, "btnAndraKat");
            btnAndraKat.ForeColor = Color.FromArgb(64, 0, 0);
            btnAndraKat.Name = "btnAndraKat";
            btnAndraKat.UseVisualStyleBackColor = false;
            btnAndraKat.Click += button2AndraKat_Click;
            // 
            // btnTaBortKat
            // 
            btnTaBortKat.BackColor = Color.LightCoral;
            btnTaBortKat.FlatAppearance.BorderColor = Color.LightCoral;
            btnTaBortKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTaBortKat, "btnTaBortKat");
            btnTaBortKat.ForeColor = Color.FromArgb(64, 0, 0);
            btnTaBortKat.Name = "btnTaBortKat";
            btnTaBortKat.UseVisualStyleBackColor = false;
            btnTaBortKat.Click += button3TaBortKat_Click;
            // 
            // richTextBoxEpisodeDescription
            // 
            resources.ApplyResources(richTextBoxEpisodeDescription, "richTextBoxEpisodeDescription");
            richTextBoxEpisodeDescription.Name = "richTextBoxEpisodeDescription";
            // 
            // lbAvsnitt
            // 
            resources.ApplyResources(lbAvsnitt, "lbAvsnitt");
            lbAvsnitt.ForeColor = Color.Firebrick;
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Click += label2_Click;
            // 
            // listBoxEpisodes
            // 
            listBoxEpisodes.FormattingEnabled = true;
            resources.ApplyResources(listBoxEpisodes, "listBoxEpisodes");
            listBoxEpisodes.Name = "listBoxEpisodes";
            listBoxEpisodes.SelectedIndexChanged += listBoxAvsnitt_SelectedIndexChanged;
            // 
            // lbLaggTillPoddcast
            // 
            resources.ApplyResources(lbLaggTillPoddcast, "lbLaggTillPoddcast");
            lbLaggTillPoddcast.ForeColor = Color.Firebrick;
            lbLaggTillPoddcast.Name = "lbLaggTillPoddcast";
            lbLaggTillPoddcast.Click += NamnLabel_Click;
            // 
            // textBoxFeedName
            // 
            resources.ApplyResources(textBoxFeedName, "textBoxFeedName");
            textBoxFeedName.Name = "textBoxFeedName";
            textBoxFeedName.TextChanged += textBoxNamn_TextChanged;
            // 
            // cbUpdateFrequencyDataGridViewItems
            // 
            cbUpdateFrequencyDataGridViewItems.FormattingEnabled = true;
            cbUpdateFrequencyDataGridViewItems.Items.AddRange(new object[] { resources.GetString("cbUpdateFrequencyDataGridViewItems.Items"), resources.GetString("cbUpdateFrequencyDataGridViewItems.Items1"), resources.GetString("cbUpdateFrequencyDataGridViewItems.Items2") });
            resources.ApplyResources(cbUpdateFrequencyDataGridViewItems, "cbUpdateFrequencyDataGridViewItems");
            cbUpdateFrequencyDataGridViewItems.Name = "cbUpdateFrequencyDataGridViewItems";
            cbUpdateFrequencyDataGridViewItems.SelectedIndexChanged += comboBoxMinuter_SelectedIndexChanged;
            // 
            // cbAssignFeedCategory
            // 
            cbAssignFeedCategory.FormattingEnabled = true;
            resources.ApplyResources(cbAssignFeedCategory, "cbAssignFeedCategory");
            cbAssignFeedCategory.Name = "cbAssignFeedCategory";
            toolTipFrivilligKategori.SetToolTip(cbAssignFeedCategory, resources.GetString("cbAssignFeedCategory.ToolTip"));
            cbAssignFeedCategory.SelectedIndexChanged += comboBoxKategori_SelectedIndexChanged;
            // 
            // textBoxURL
            // 
            resources.ApplyResources(textBoxURL, "textBoxURL");
            textBoxURL.Name = "textBoxURL";
            textBoxURL.TextChanged += textBoxURL_TextChanged;
            // 
            // btnAddNewFeed
            // 
            btnAddNewFeed.BackColor = Color.LightCoral;
            btnAddNewFeed.FlatAppearance.BorderColor = Color.LightCoral;
            btnAddNewFeed.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddNewFeed, "btnAddNewFeed");
            btnAddNewFeed.ForeColor = Color.FromArgb(64, 0, 0);
            btnAddNewFeed.Name = "btnAddNewFeed";
            btnAddNewFeed.UseVisualStyleBackColor = false;
            btnAddNewFeed.Click += btnAddNewFeed_Click;
            // 
            // btnChangeFeedName
            // 
            btnChangeFeedName.BackColor = Color.LightCoral;
            btnChangeFeedName.FlatAppearance.BorderColor = Color.LightCoral;
            btnChangeFeedName.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnChangeFeedName, "btnChangeFeedName");
            btnChangeFeedName.ForeColor = Color.FromArgb(64, 0, 0);
            btnChangeFeedName.Name = "btnChangeFeedName";
            btnChangeFeedName.UseVisualStyleBackColor = false;
            // 
            // cbChangeFeedCategory
            // 
            cbChangeFeedCategory.FormattingEnabled = true;
            resources.ApplyResources(cbChangeFeedCategory, "cbChangeFeedCategory");
            cbChangeFeedCategory.Name = "cbChangeFeedCategory";
            toolTipChangeFeedCategory.SetToolTip(cbChangeFeedCategory, resources.GetString("cbChangeFeedCategory.ToolTip"));
            cbChangeFeedCategory.SelectedIndexChanged += comboBoxKat_SelectedIndexChanged;
            // 
            // dataGridViewPodcastList
            // 
            dataGridViewPodcastList.AllowUserToAddRows = false;
            dataGridViewPodcastList.AllowUserToDeleteRows = false;
            dataGridViewPodcastList.AllowUserToResizeRows = false;
            dataGridViewPodcastList.BackgroundColor = Color.White;
            dataGridViewPodcastList.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPodcastList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPodcastList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPodcastList.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPodcastList.GridColor = Color.White;
            resources.ApplyResources(dataGridViewPodcastList, "dataGridViewPodcastList");
            dataGridViewPodcastList.Name = "dataGridViewPodcastList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPodcastList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // checkedListBoxUserCategories
            // 
            checkedListBoxUserCategories.CheckOnClick = true;
            checkedListBoxUserCategories.FormattingEnabled = true;
            resources.ApplyResources(checkedListBoxUserCategories, "checkedListBoxUserCategories");
            checkedListBoxUserCategories.Name = "checkedListBoxUserCategories";
            checkedListBoxUserCategories.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lbTilldelaKategori
            // 
            resources.ApplyResources(lbTilldelaKategori, "lbTilldelaKategori");
            lbTilldelaKategori.ForeColor = Color.Firebrick;
            lbTilldelaKategori.Name = "lbTilldelaKategori";
            lbTilldelaKategori.Click += label3_Click;
            // 
            // lbUpdateringsfrekv
            // 
            resources.ApplyResources(lbUpdateringsfrekv, "lbUpdateringsfrekv");
            lbUpdateringsfrekv.ForeColor = Color.Firebrick;
            lbUpdateringsfrekv.Name = "lbUpdateringsfrekv";
            lbUpdateringsfrekv.Click += label3_Click_2;
            // 
            // lbFiltreraKategori
            // 
            resources.ApplyResources(lbFiltreraKategori, "lbFiltreraKategori");
            lbFiltreraKategori.ForeColor = Color.Firebrick;
            lbFiltreraKategori.Name = "lbFiltreraKategori";
            lbFiltreraKategori.Click += lbFiltreraKategori_Click;
            // 
            // lbAndraFiltrera
            // 
            resources.ApplyResources(lbAndraFiltrera, "lbAndraFiltrera");
            lbAndraFiltrera.ForeColor = Color.Firebrick;
            lbAndraFiltrera.Name = "lbAndraFiltrera";
            lbAndraFiltrera.Click += label3_Click_1;
            // 
            // tbChangeFeedName
            // 
            resources.ApplyResources(tbChangeFeedName, "tbChangeFeedName");
            tbChangeFeedName.Name = "tbChangeFeedName";
            // 
            // toolTipChangeFeedCategory
            // 
            toolTipChangeFeedCategory.AutoPopDelay = 5000;
            toolTipChangeFeedCategory.InitialDelay = 50;
            toolTipChangeFeedCategory.ReshowDelay = 100;
            // 
            // btnRemoveSelectedFeed
            // 
            btnRemoveSelectedFeed.BackColor = Color.LightCoral;
            btnRemoveSelectedFeed.FlatAppearance.BorderColor = Color.LightCoral;
            btnRemoveSelectedFeed.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRemoveSelectedFeed, "btnRemoveSelectedFeed");
            btnRemoveSelectedFeed.ForeColor = Color.FromArgb(64, 0, 0);
            btnRemoveSelectedFeed.Name = "btnRemoveSelectedFeed";
            toolTipRemoveSelectedFeed.SetToolTip(btnRemoveSelectedFeed, resources.GetString("btnRemoveSelectedFeed.ToolTip"));
            toolTipChangeFeedCategory.SetToolTip(btnRemoveSelectedFeed, resources.GetString("btnRemoveSelectedFeed.ToolTip1"));
            btnRemoveSelectedFeed.UseVisualStyleBackColor = false;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.LightCoral;
            btnResetFilters.FlatAppearance.BorderColor = Color.LightCoral;
            btnResetFilters.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnResetFilters, "btnResetFilters");
            btnResetFilters.ForeColor = Color.FromArgb(64, 0, 0);
            btnResetFilters.Name = "btnResetFilters";
            toolTipChangeFeedCategory.SetToolTip(btnResetFilters, resources.GetString("btnResetFilters.ToolTip"));
            toolTipResetFilters.SetToolTip(btnResetFilters, resources.GetString("btnResetFilters.ToolTip1"));
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // btnChangeCategory
            // 
            btnChangeCategory.BackColor = Color.LightCoral;
            btnChangeCategory.FlatAppearance.BorderColor = Color.LightCoral;
            btnChangeCategory.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnChangeCategory, "btnChangeCategory");
            btnChangeCategory.ForeColor = Color.FromArgb(64, 0, 0);
            btnChangeCategory.Name = "btnChangeCategory";
            btnChangeCategory.UseVisualStyleBackColor = false;
            // 
            // toolTipRemoveSelectedFeed
            // 
            toolTipRemoveSelectedFeed.AutoPopDelay = 5000;
            toolTipRemoveSelectedFeed.InitialDelay = 50;
            toolTipRemoveSelectedFeed.ReshowDelay = 100;
            // 
            // cbFilterCategory
            // 
            cbFilterCategory.FormattingEnabled = true;
            resources.ApplyResources(cbFilterCategory, "cbFilterCategory");
            cbFilterCategory.Name = "cbFilterCategory";
            cbFilterCategory.SelectedIndexChanged += cbFilterCategory_SelectedIndexChanged;
            // 
            // lbAvsnittsbeskrivning
            // 
            lbAvsnittsbeskrivning.ForeColor = Color.Firebrick;
            resources.ApplyResources(lbAvsnittsbeskrivning, "lbAvsnittsbeskrivning");
            lbAvsnittsbeskrivning.Name = "lbAvsnittsbeskrivning";
            // 
            // toolTipFrivilligKategori
            // 
            toolTipFrivilligKategori.AutoPopDelay = 5000;
            toolTipFrivilligKategori.InitialDelay = 50;
            toolTipFrivilligKategori.ReshowDelay = 100;
            // 
            // toolTipChangeFeedName
            // 
            toolTipChangeFeedName.AutoPopDelay = 5000;
            toolTipChangeFeedName.InitialDelay = 50;
            toolTipChangeFeedName.ReshowDelay = 100;
            // 
            // toolTipResetFilters
            // 
            toolTipResetFilters.AutoPopDelay = 5000;
            toolTipResetFilters.InitialDelay = 50;
            toolTipResetFilters.ReshowDelay = 100;
            // 
            // lbKategoriLabel
            // 
            resources.ApplyResources(lbKategoriLabel, "lbKategoriLabel");
            lbKategoriLabel.ForeColor = Color.Firebrick;
            lbKategoriLabel.Name = "lbKategoriLabel";
            lbKategoriLabel.Click += label1_Click_1;
            // 
            // lbAvsnittsbesk
            // 
            resources.ApplyResources(lbAvsnittsbesk, "lbAvsnittsbesk");
            lbAvsnittsbesk.ForeColor = Color.Firebrick;
            lbAvsnittsbesk.Name = "lbAvsnittsbesk";
            // 
            // Poddbibliotek
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(lbAvsnittsbesk);
            Controls.Add(lbKategoriLabel);
            Controls.Add(btnResetFilters);
            Controls.Add(lbAvsnittsbeskrivning);
            Controls.Add(lbFiltreraKategori);
            Controls.Add(cbFilterCategory);
            Controls.Add(lbUpdateringsfrekv);
            Controls.Add(btnRemoveSelectedFeed);
            Controls.Add(btnChangeCategory);
            Controls.Add(tbChangeFeedName);
            Controls.Add(lbAndraFiltrera);
            Controls.Add(lbTilldelaKategori);
            Controls.Add(checkedListBoxUserCategories);
            Controls.Add(dataGridViewPodcastList);
            Controls.Add(cbChangeFeedCategory);
            Controls.Add(btnChangeFeedName);
            Controls.Add(btnAddNewFeed);
            Controls.Add(textBoxURL);
            Controls.Add(cbAssignFeedCategory);
            Controls.Add(cbUpdateFrequencyDataGridViewItems);
            Controls.Add(textBoxFeedName);
            Controls.Add(lbLaggTillPoddcast);
            Controls.Add(listBoxEpisodes);
            Controls.Add(lbAvsnitt);
            Controls.Add(richTextBoxEpisodeDescription);
            Controls.Add(btnTaBortKat);
            Controls.Add(btnAndraKat);
            Controls.Add(btnLaggTillKat);
            Controls.Add(tbNewCategoryName);
            Controls.Add(lbKategori);
            Controls.Add(Rubrik);
            Name = "Poddbibliotek";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodcastList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Rubrik;
        private Label lbKategori;
        private TextBox tbNewCategoryName;
        private Button btnLaggTillKat;
        private Button btnAndraKat;
        private Button btnTaBortKat;
        private RichTextBox richTextBoxEpisodeDescription;
        private Label lbAvsnitt;
        private ListBox listBoxEpisodes;
        private Label lbLaggTillPoddcast;
        private TextBox textBoxFeedName;
        private ComboBox cbUpdateFrequencyDataGridViewItems;
        private ComboBox cbAssignFeedCategory;
        private TextBox textBoxURL;
        private Button btnAddNewFeed;
        private Button btnChangeFeedName;
        private ComboBox cbChangeFeedCategory;
        private DataGridView dataGridViewPodcastList;
        private CheckedListBox checkedListBoxUserCategories;
        private Label lbTilldelaKategori;
        private Label lbAndraFiltrera;
        private TextBox tbChangeFeedName;
        private ToolTip toolTipChangeFeedCategory;
        private Button btnChangeCategory;
        private Button btnRemoveSelectedFeed;
        private ToolTip toolTipRemoveSelectedFeed;
        private Label lbUpdateringsfrekv;
        private ComboBox cbFilterCategory;
        private Label lbFiltreraKategori;
        private Label lbAvsnittsbeskrivning;
        private Button btnResetFilters;
        private ToolTip toolTipFrivilligKategori;
        private ToolTip toolTipChangeFeedName;
        private ToolTip toolTipResetFilters;
        private Label lbKategoriLabel;
        private Label lbAvsnittsbesk;
    }
}
