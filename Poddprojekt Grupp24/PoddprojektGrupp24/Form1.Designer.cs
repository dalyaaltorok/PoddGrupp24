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
            label1 = new Label();
            textBoxNyKategori = new TextBox();
            btnLaggTillKat = new Button();
            btnAndraKat = new Button();
            btnTaBortKat = new Button();
            richTextBoxBeskrivning = new RichTextBox();
            lbAvsnitt = new Label();
            listBoxAvsnitt = new ListBox();
            lbLaggTillPoddcast = new Label();
            textBoxPoddnamn = new TextBox();
            cbUpdateringsfrekvens = new ComboBox();
            comboBoxKategori = new ComboBox();
            textBoxURL = new TextBox();
            btnLaggTillPodd = new Button();
            btnAndraNamn = new Button();
            comboBoxKat = new ComboBox();
            dataGridViewPodd = new DataGridView();
            checkedListBoxCat = new CheckedListBox();
            lbTilldelaKategori = new Label();
            lbUpdateringsfrekv = new Label();
            lbFiltreraKategori = new Label();
            lbAndraFiltrera = new Label();
            textBocAndraPoddNamn = new TextBox();
            toolTipAndraKategori = new ToolTip(components);
            btnTaBortPodd = new Button();
            btnAndraKategori = new Button();
            toolTipTaBortPodd = new ToolTip(components);
            cbFiltreraKategori = new ComboBox();
            label2 = new Label();
            btnAterstallFiltrering = new Button();
            toolTipAterstallFiltering = new ToolTip(components);
            toolTipFrivilligKategori = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodd).BeginInit();
            SuspendLayout();
            // 
            // Rubrik
            // 
            resources.ApplyResources(Rubrik, "Rubrik");
            Rubrik.ForeColor = Color.LightCoral;
            Rubrik.Name = "Rubrik";
            Rubrik.Click += Rubrik_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Firebrick;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // textBoxNyKategori
            // 
            resources.ApplyResources(textBoxNyKategori, "textBoxNyKategori");
            textBoxNyKategori.Name = "textBoxNyKategori";
            textBoxNyKategori.TextChanged += textBox1_TextChanged;
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
            // richTextBoxBeskrivning
            // 
            resources.ApplyResources(richTextBoxBeskrivning, "richTextBoxBeskrivning");
            richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            // 
            // lbAvsnitt
            // 
            resources.ApplyResources(lbAvsnitt, "lbAvsnitt");
            lbAvsnitt.ForeColor = Color.Firebrick;
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Click += label2_Click;
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            resources.ApplyResources(listBoxAvsnitt, "listBoxAvsnitt");
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            listBoxAvsnitt.SelectedIndexChanged += listBoxAvsnitt_SelectedIndexChanged;
            // 
            // lbLaggTillPoddcast
            // 
            resources.ApplyResources(lbLaggTillPoddcast, "lbLaggTillPoddcast");
            lbLaggTillPoddcast.ForeColor = Color.Firebrick;
            lbLaggTillPoddcast.Name = "lbLaggTillPoddcast";
            lbLaggTillPoddcast.Click += NamnLabel_Click;
            // 
            // textBoxPoddnamn
            // 
            resources.ApplyResources(textBoxPoddnamn, "textBoxPoddnamn");
            textBoxPoddnamn.Name = "textBoxPoddnamn";
            textBoxPoddnamn.TextChanged += textBoxNamn_TextChanged;
            // 
            // cbUpdateringsfrekvens
            // 
            cbUpdateringsfrekvens.FormattingEnabled = true;
            resources.ApplyResources(cbUpdateringsfrekvens, "cbUpdateringsfrekvens");
            cbUpdateringsfrekvens.Name = "cbUpdateringsfrekvens";
            cbUpdateringsfrekvens.SelectedIndexChanged += comboBoxMinuter_SelectedIndexChanged;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            resources.ApplyResources(comboBoxKategori, "comboBoxKategori");
            comboBoxKategori.Name = "comboBoxKategori";
            toolTipFrivilligKategori.SetToolTip(comboBoxKategori, resources.GetString("comboBoxKategori.ToolTip"));
            comboBoxKategori.SelectedIndexChanged += comboBoxKategori_SelectedIndexChanged;
            // 
            // textBoxURL
            // 
            resources.ApplyResources(textBoxURL, "textBoxURL");
            textBoxURL.Name = "textBoxURL";
            // 
            // btnLaggTillPodd
            // 
            btnLaggTillPodd.BackColor = Color.LightCoral;
            btnLaggTillPodd.FlatAppearance.BorderColor = Color.LightCoral;
            btnLaggTillPodd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLaggTillPodd, "btnLaggTillPodd");
            btnLaggTillPodd.ForeColor = Color.FromArgb(64, 0, 0);
            btnLaggTillPodd.Name = "btnLaggTillPodd";
            btnLaggTillPodd.UseVisualStyleBackColor = false;
            // 
            // btnAndraNamn
            // 
            btnAndraNamn.BackColor = Color.LightCoral;
            btnAndraNamn.FlatAppearance.BorderColor = Color.LightCoral;
            btnAndraNamn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAndraNamn, "btnAndraNamn");
            btnAndraNamn.ForeColor = Color.FromArgb(64, 0, 0);
            btnAndraNamn.Name = "btnAndraNamn";
            btnAndraNamn.UseVisualStyleBackColor = false;
            // 
            // comboBoxKat
            // 
            comboBoxKat.FormattingEnabled = true;
            resources.ApplyResources(comboBoxKat, "comboBoxKat");
            comboBoxKat.Name = "comboBoxKat";
            toolTipAndraKategori.SetToolTip(comboBoxKat, resources.GetString("comboBoxKat.ToolTip"));
            // 
            // dataGridViewPodd
            // 
            dataGridViewPodd.AllowUserToAddRows = false;
            dataGridViewPodd.AllowUserToDeleteRows = false;
            dataGridViewPodd.AllowUserToResizeRows = false;
            dataGridViewPodd.BackgroundColor = Color.White;
            dataGridViewPodd.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPodd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPodd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPodd.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPodd.GridColor = Color.White;
            resources.ApplyResources(dataGridViewPodd, "dataGridViewPodd");
            dataGridViewPodd.Name = "dataGridViewPodd";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPodd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // checkedListBoxCat
            // 
            checkedListBoxCat.CheckOnClick = true;
            checkedListBoxCat.FormattingEnabled = true;
            resources.ApplyResources(checkedListBoxCat, "checkedListBoxCat");
            checkedListBoxCat.Name = "checkedListBoxCat";
            checkedListBoxCat.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
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
            // textBocAndraPoddNamn
            // 
            resources.ApplyResources(textBocAndraPoddNamn, "textBocAndraPoddNamn");
            textBocAndraPoddNamn.Name = "textBocAndraPoddNamn";
            // 
            // toolTipAndraKategori
            // 
            toolTipAndraKategori.AutoPopDelay = 5000;
            toolTipAndraKategori.InitialDelay = 50;
            toolTipAndraKategori.ReshowDelay = 100;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.BackColor = Color.LightCoral;
            btnTaBortPodd.FlatAppearance.BorderColor = Color.LightCoral;
            btnTaBortPodd.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTaBortPodd, "btnTaBortPodd");
            btnTaBortPodd.ForeColor = Color.FromArgb(64, 0, 0);
            btnTaBortPodd.Name = "btnTaBortPodd";
            toolTipTaBortPodd.SetToolTip(btnTaBortPodd, resources.GetString("btnTaBortPodd.ToolTip"));
            toolTipAndraKategori.SetToolTip(btnTaBortPodd, resources.GetString("btnTaBortPodd.ToolTip1"));
            btnTaBortPodd.UseVisualStyleBackColor = false;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.BackColor = Color.LightCoral;
            btnAndraKategori.FlatAppearance.BorderColor = Color.LightCoral;
            btnAndraKategori.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAndraKategori, "btnAndraKategori");
            btnAndraKategori.ForeColor = Color.FromArgb(64, 0, 0);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.UseVisualStyleBackColor = false;
            // 
            // toolTipTaBortPodd
            // 
            toolTipTaBortPodd.AutoPopDelay = 5000;
            toolTipTaBortPodd.InitialDelay = 50;
            toolTipTaBortPodd.ReshowDelay = 100;
            // 
            // cbFiltreraKategori
            // 
            cbFiltreraKategori.FormattingEnabled = true;
            resources.ApplyResources(cbFiltreraKategori, "cbFiltreraKategori");
            cbFiltreraKategori.Name = "cbFiltreraKategori";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Firebrick;
            label2.Name = "label2";
            // 
            // btnAterstallFiltrering
            // 
            btnAterstallFiltrering.BackColor = Color.LightCoral;
            btnAterstallFiltrering.FlatAppearance.BorderColor = Color.LightCoral;
            btnAterstallFiltrering.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAterstallFiltrering, "btnAterstallFiltrering");
            btnAterstallFiltrering.ForeColor = Color.FromArgb(64, 0, 0);
            btnAterstallFiltrering.Name = "btnAterstallFiltrering";
            toolTipAndraKategori.SetToolTip(btnAterstallFiltrering, resources.GetString("btnAterstallFiltrering.ToolTip"));
            toolTipAterstallFiltering.SetToolTip(btnAterstallFiltrering, resources.GetString("btnAterstallFiltrering.ToolTip1"));
            btnAterstallFiltrering.UseVisualStyleBackColor = false;
            // 
            // toolTipAterstallFiltering
            // 
            toolTipAterstallFiltering.AutoPopDelay = 5000;
            toolTipAterstallFiltering.InitialDelay = 50;
            toolTipAterstallFiltering.ReshowDelay = 100;
            // 
            // toolTipFrivilligKategori
            // 
            toolTipFrivilligKategori.AutoPopDelay = 5000;
            toolTipFrivilligKategori.InitialDelay = 50;
            toolTipFrivilligKategori.ReshowDelay = 100;
            // 
            // Poddbibliotek
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(btnAterstallFiltrering);
            Controls.Add(label2);
            Controls.Add(lbFiltreraKategori);
            Controls.Add(cbFiltreraKategori);
            Controls.Add(lbUpdateringsfrekv);
            Controls.Add(btnTaBortPodd);
            Controls.Add(btnAndraKategori);
            Controls.Add(textBocAndraPoddNamn);
            Controls.Add(lbAndraFiltrera);
            Controls.Add(lbTilldelaKategori);
            Controls.Add(checkedListBoxCat);
            Controls.Add(dataGridViewPodd);
            Controls.Add(comboBoxKat);
            Controls.Add(btnAndraNamn);
            Controls.Add(btnLaggTillPodd);
            Controls.Add(textBoxURL);
            Controls.Add(comboBoxKategori);
            Controls.Add(cbUpdateringsfrekvens);
            Controls.Add(textBoxPoddnamn);
            Controls.Add(lbLaggTillPoddcast);
            Controls.Add(listBoxAvsnitt);
            Controls.Add(lbAvsnitt);
            Controls.Add(richTextBoxBeskrivning);
            Controls.Add(btnTaBortKat);
            Controls.Add(btnAndraKat);
            Controls.Add(btnLaggTillKat);
            Controls.Add(textBoxNyKategori);
            Controls.Add(label1);
            Controls.Add(Rubrik);
            Name = "Poddbibliotek";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Rubrik;
        private Label label1;
        private TextBox textBoxNyKategori;
        private Button btnLaggTillKat;
        private Button btnAndraKat;
        private Button btnTaBortKat;
        private RichTextBox richTextBoxBeskrivning;
        private Label lbAvsnitt;
        private ListBox listBoxAvsnitt;
        private Label lbLaggTillPoddcast;
        private TextBox textBoxPoddnamn;
        private ComboBox cbUpdateringsfrekvens;
        private ComboBox comboBoxKategori;
        private TextBox textBoxURL;
        private Button btnLaggTillPodd;
        private Button btnAndraNamn;
        private ComboBox comboBoxKat;
        private DataGridView dataGridViewPodd;
        private CheckedListBox checkedListBoxCat;
        private Label lbTilldelaKategori;
        private Label lbAndraFiltrera;
        private TextBox textBocAndraPoddNamn;
        private ToolTip toolTipAndraKategori;
        private Button btnAndraKategori;
        private Button btnTaBortPodd;
        private ToolTip toolTipTaBortPodd;
        private Label lbUpdateringsfrekv;
        private ComboBox cbFiltreraKategori;
        private Label lbFiltreraKategori;
        private Label label2;
        private Button btnAterstallFiltrering;
        private ToolTip toolTipAterstallFiltering;
        private ToolTip toolTipFrivilligKategori;
    }
}
