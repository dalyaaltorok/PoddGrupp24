﻿namespace PoddprojektGrupp24
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
            Rubrik = new Label();
            lbKategori = new Label();
            tbNewCategoryName = new TextBox();
            btnLaggTillKat = new Button();
            btnAndraKat = new Button();
            btnTaBortKat = new Button();
            richTextBoxEpisodeDescription = new RichTextBox();
            lbAvsnitt = new Label();
            lbLaggTillPoddcast = new Label();
            textBoxFeedName = new TextBox();
            cbAssignFeedCategory = new ComboBox();
            textBoxURL = new TextBox();
            btnAddNewFeed = new Button();
            btnChangeFeedName = new Button();
            cbChangeFeedCategory = new ComboBox();
            checkedListBoxUserCategories = new CheckedListBox();
            lbTilldelaKategori = new Label();
            lbFiltreraKategori = new Label();
            lbAndraFiltrera = new Label();
            tbChangeFeedName = new TextBox();
            btnRemoveSelectedFeed = new Button();
            btnResetFilters = new Button();
            btnChangeCategory = new Button();
            toolTipRemoveSelectedFeed = new ToolTip(components);
            cbFilterCategory = new ComboBox();
            lbAvsnittsbeskrivning = new Label();
            toolTipChangeFeedName = new ToolTip(components);
            lbKategoriLabel = new Label();
            lbAvsnittsbesk = new Label();
            listViewPodd = new ListView();
            Namn = new ColumnHeader();
            Titel = new ColumnHeader();
            Antalavsnitt = new ColumnHeader();
            Kategori = new ColumnHeader();
            listBoxEpisodes = new ListView();
            columnHeader1 = new ColumnHeader();
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
            // cbAssignFeedCategory
            // 
            cbAssignFeedCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAssignFeedCategory.FormattingEnabled = true;
            resources.ApplyResources(cbAssignFeedCategory, "cbAssignFeedCategory");
            cbAssignFeedCategory.Name = "cbAssignFeedCategory";
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
            btnChangeFeedName.Click += btnChangeFeedName_Click;
            // 
            // cbChangeFeedCategory
            // 
            cbChangeFeedCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangeFeedCategory.FormattingEnabled = true;
            resources.ApplyResources(cbChangeFeedCategory, "cbChangeFeedCategory");
            cbChangeFeedCategory.Name = "cbChangeFeedCategory";
            cbChangeFeedCategory.SelectedIndexChanged += comboBoxKat_SelectedIndexChanged;
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
            // btnRemoveSelectedFeed
            // 
            btnRemoveSelectedFeed.BackColor = Color.LightCoral;
            btnRemoveSelectedFeed.FlatAppearance.BorderColor = Color.LightCoral;
            btnRemoveSelectedFeed.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRemoveSelectedFeed, "btnRemoveSelectedFeed");
            btnRemoveSelectedFeed.ForeColor = Color.FromArgb(64, 0, 0);
            btnRemoveSelectedFeed.Name = "btnRemoveSelectedFeed";
            toolTipRemoveSelectedFeed.SetToolTip(btnRemoveSelectedFeed, resources.GetString("btnRemoveSelectedFeed.ToolTip"));
            btnRemoveSelectedFeed.UseVisualStyleBackColor = false;
            btnRemoveSelectedFeed.Click += btnRemoveSelectedFeed_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.LightCoral;
            btnResetFilters.FlatAppearance.BorderColor = Color.LightCoral;
            btnResetFilters.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnResetFilters, "btnResetFilters");
            btnResetFilters.ForeColor = Color.FromArgb(64, 0, 0);
            btnResetFilters.Name = "btnResetFilters";
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
            btnChangeCategory.Click += btnChangeCategory_Click;
            // 
            // toolTipRemoveSelectedFeed
            // 
            toolTipRemoveSelectedFeed.AutoPopDelay = 5000;
            toolTipRemoveSelectedFeed.InitialDelay = 50;
            toolTipRemoveSelectedFeed.ReshowDelay = 100;
            // 
            // cbFilterCategory
            // 
            cbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
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
            // toolTipChangeFeedName
            // 
            toolTipChangeFeedName.AutoPopDelay = 5000;
            toolTipChangeFeedName.InitialDelay = 50;
            toolTipChangeFeedName.ReshowDelay = 100;
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
            // listViewPodd
            // 
            listViewPodd.Columns.AddRange(new ColumnHeader[] { Namn, Titel, Antalavsnitt, Kategori });
            listViewPodd.FullRowSelect = true;
            resources.ApplyResources(listViewPodd, "listViewPodd");
            listViewPodd.Name = "listViewPodd";
            listViewPodd.UseCompatibleStateImageBehavior = false;
            listViewPodd.View = View.Details;
            listViewPodd.SelectedIndexChanged += listViewPodd_SelectedIndexChanged;
            // 
            // Namn
            // 
            resources.ApplyResources(Namn, "Namn");
            // 
            // Titel
            // 
            resources.ApplyResources(Titel, "Titel");
            // 
            // Antalavsnitt
            // 
            resources.ApplyResources(Antalavsnitt, "Antalavsnitt");
            // 
            // Kategori
            // 
            resources.ApplyResources(Kategori, "Kategori");
            // 
            // listBoxEpisodes
            // 
            listBoxEpisodes.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listBoxEpisodes.FullRowSelect = true;
            listBoxEpisodes.GridLines = true;
            resources.ApplyResources(listBoxEpisodes, "listBoxEpisodes");
            listBoxEpisodes.Name = "listBoxEpisodes";
            listBoxEpisodes.UseCompatibleStateImageBehavior = false;
            listBoxEpisodes.View = View.Details;
            listBoxEpisodes.SelectedIndexChanged += listBoxEpisodes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // Poddbibliotek
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(listBoxEpisodes);
            Controls.Add(listViewPodd);
            Controls.Add(lbAvsnittsbesk);
            Controls.Add(lbKategoriLabel);
            Controls.Add(btnResetFilters);
            Controls.Add(lbAvsnittsbeskrivning);
            Controls.Add(lbFiltreraKategori);
            Controls.Add(cbFilterCategory);
            Controls.Add(btnRemoveSelectedFeed);
            Controls.Add(btnChangeCategory);
            Controls.Add(tbChangeFeedName);
            Controls.Add(lbAndraFiltrera);
            Controls.Add(lbTilldelaKategori);
            Controls.Add(checkedListBoxUserCategories);
            Controls.Add(cbChangeFeedCategory);
            Controls.Add(btnChangeFeedName);
            Controls.Add(btnAddNewFeed);
            Controls.Add(textBoxURL);
            Controls.Add(cbAssignFeedCategory);
            Controls.Add(textBoxFeedName);
            Controls.Add(lbLaggTillPoddcast);
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
        private Label lbLaggTillPoddcast;
        private TextBox textBoxFeedName;
        private ComboBox cbAssignFeedCategory;
        private TextBox textBoxURL;
        private Button btnAddNewFeed;
        private Button btnChangeFeedName;
        private ComboBox cbChangeFeedCategory;
        private CheckedListBox checkedListBoxUserCategories;
        private Label lbTilldelaKategori;
        private Label lbAndraFiltrera;
        private TextBox tbChangeFeedName;
        private Button btnChangeCategory;
        private Button btnRemoveSelectedFeed;
        private ToolTip toolTipRemoveSelectedFeed;
        private ComboBox cbFilterCategory;
        private Label lbFiltreraKategori;
        private Label lbAvsnittsbeskrivning;
        private Button btnResetFilters;
        private ToolTip toolTipChangeFeedName;
        private Label lbKategoriLabel;
        private Label lbAvsnittsbesk;
        private ListView listViewPodd;
        private ColumnHeader Namn;
        private ColumnHeader Titel;
        private ColumnHeader Antalavsnitt;
        private ColumnHeader Kategori;
        private ListView listBoxEpisodes;
        private ColumnHeader columnHeader1;
    }
}
