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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poddbibliotek));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Rubrik = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1LaggTillKat = new Button();
            button2AndraKat = new Button();
            button3TaBortKat = new Button();
            KategoriListaListBox = new ListBox();
            richTextBoxBeskrivning = new RichTextBox();
            AvsnittLabel = new Label();
            listBoxAvsnitt = new ListBox();
            NamnLabel = new Label();
            textBoxNamn = new TextBox();
            comboBoxMinuter = new ComboBox();
            comboBoxKategori = new ComboBox();
            LabelURL = new Label();
            textBoxURL = new TextBox();
            buttonLaggTillNamn = new Button();
            buttonAndraNamn = new Button();
            buttonTaBortNamn = new Button();
            buttonAterstall = new Button();
            comboBoxKat = new ComboBox();
            dataGridViewPodd = new DataGridView();
            LabelSenast = new Label();
            LabelSenastChange = new Label();
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
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1LaggTillKat
            // 
            button1LaggTillKat.BackColor = Color.LightCoral;
            button1LaggTillKat.FlatAppearance.BorderColor = Color.LightCoral;
            button1LaggTillKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button1LaggTillKat, "button1LaggTillKat");
            button1LaggTillKat.ForeColor = Color.FromArgb(64, 0, 0);
            button1LaggTillKat.Name = "button1LaggTillKat";
            button1LaggTillKat.UseVisualStyleBackColor = false;
            button1LaggTillKat.Click += button1LaggTillKat_Click;
            // 
            // button2AndraKat
            // 
            button2AndraKat.BackColor = Color.LightCoral;
            button2AndraKat.FlatAppearance.BorderColor = Color.LightCoral;
            button2AndraKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button2AndraKat, "button2AndraKat");
            button2AndraKat.ForeColor = Color.FromArgb(64, 0, 0);
            button2AndraKat.Name = "button2AndraKat";
            button2AndraKat.UseVisualStyleBackColor = false;
            button2AndraKat.Click += button2AndraKat_Click;
            // 
            // button3TaBortKat
            // 
            button3TaBortKat.BackColor = Color.LightCoral;
            button3TaBortKat.FlatAppearance.BorderColor = Color.LightCoral;
            button3TaBortKat.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button3TaBortKat, "button3TaBortKat");
            button3TaBortKat.ForeColor = Color.FromArgb(64, 0, 0);
            button3TaBortKat.Name = "button3TaBortKat";
            button3TaBortKat.UseVisualStyleBackColor = false;
            button3TaBortKat.Click += button3TaBortKat_Click;
            // 
            // KategoriListaListBox
            // 
            KategoriListaListBox.FormattingEnabled = true;
            resources.ApplyResources(KategoriListaListBox, "KategoriListaListBox");
            KategoriListaListBox.Name = "KategoriListaListBox";
            KategoriListaListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // richTextBoxBeskrivning
            // 
            resources.ApplyResources(richTextBoxBeskrivning, "richTextBoxBeskrivning");
            richTextBoxBeskrivning.Name = "richTextBoxBeskrivning";
            // 
            // AvsnittLabel
            // 
            resources.ApplyResources(AvsnittLabel, "AvsnittLabel");
            AvsnittLabel.ForeColor = Color.Firebrick;
            AvsnittLabel.Name = "AvsnittLabel";
            AvsnittLabel.Click += label2_Click;
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            resources.ApplyResources(listBoxAvsnitt, "listBoxAvsnitt");
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            // 
            // NamnLabel
            // 
            resources.ApplyResources(NamnLabel, "NamnLabel");
            NamnLabel.ForeColor = Color.Firebrick;
            NamnLabel.Name = "NamnLabel";
            // 
            // textBoxNamn
            // 
            resources.ApplyResources(textBoxNamn, "textBoxNamn");
            textBoxNamn.Name = "textBoxNamn";
            // 
            // comboBoxMinuter
            // 
            comboBoxMinuter.FormattingEnabled = true;
            resources.ApplyResources(comboBoxMinuter, "comboBoxMinuter");
            comboBoxMinuter.Name = "comboBoxMinuter";
            comboBoxMinuter.SelectedIndexChanged += comboBoxMinuter_SelectedIndexChanged;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            resources.ApplyResources(comboBoxKategori, "comboBoxKategori");
            comboBoxKategori.Name = "comboBoxKategori";
            // 
            // LabelURL
            // 
            resources.ApplyResources(LabelURL, "LabelURL");
            LabelURL.ForeColor = Color.Firebrick;
            LabelURL.Name = "LabelURL";
            // 
            // textBoxURL
            // 
            resources.ApplyResources(textBoxURL, "textBoxURL");
            textBoxURL.Name = "textBoxURL";
            // 
            // buttonLaggTillNamn
            // 
            buttonLaggTillNamn.BackColor = Color.LightCoral;
            buttonLaggTillNamn.FlatAppearance.BorderColor = Color.LightCoral;
            buttonLaggTillNamn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonLaggTillNamn, "buttonLaggTillNamn");
            buttonLaggTillNamn.ForeColor = Color.FromArgb(64, 0, 0);
            buttonLaggTillNamn.Name = "buttonLaggTillNamn";
            buttonLaggTillNamn.UseVisualStyleBackColor = false;
            // 
            // buttonAndraNamn
            // 
            buttonAndraNamn.BackColor = Color.LightCoral;
            buttonAndraNamn.FlatAppearance.BorderColor = Color.LightCoral;
            buttonAndraNamn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonAndraNamn, "buttonAndraNamn");
            buttonAndraNamn.ForeColor = Color.FromArgb(64, 0, 0);
            buttonAndraNamn.Name = "buttonAndraNamn";
            buttonAndraNamn.UseVisualStyleBackColor = false;
            // 
            // buttonTaBortNamn
            // 
            buttonTaBortNamn.BackColor = Color.LightCoral;
            buttonTaBortNamn.FlatAppearance.BorderColor = Color.LightCoral;
            buttonTaBortNamn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonTaBortNamn, "buttonTaBortNamn");
            buttonTaBortNamn.ForeColor = Color.FromArgb(64, 0, 0);
            buttonTaBortNamn.Name = "buttonTaBortNamn";
            buttonTaBortNamn.UseVisualStyleBackColor = false;
            // 
            // buttonAterstall
            // 
            buttonAterstall.BackColor = Color.LightCoral;
            buttonAterstall.FlatAppearance.BorderColor = Color.LightCoral;
            buttonAterstall.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonAterstall, "buttonAterstall");
            buttonAterstall.ForeColor = Color.FromArgb(64, 0, 0);
            buttonAterstall.Name = "buttonAterstall";
            buttonAterstall.UseVisualStyleBackColor = false;
            buttonAterstall.Click += buttonAterstall_Click;
            // 
            // comboBoxKat
            // 
            comboBoxKat.FormattingEnabled = true;
            resources.ApplyResources(comboBoxKat, "comboBoxKat");
            comboBoxKat.Name = "comboBoxKat";
            // 
            // dataGridViewPodd
            // 
            resources.ApplyResources(dataGridViewPodd, "dataGridViewPodd");
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
            // LabelSenast
            // 
            resources.ApplyResources(LabelSenast, "LabelSenast");
            LabelSenast.ForeColor = Color.Firebrick;
            LabelSenast.Name = "LabelSenast";
            // 
            // LabelSenastChange
            // 
            resources.ApplyResources(LabelSenastChange, "LabelSenastChange");
            LabelSenastChange.ForeColor = Color.Firebrick;
            LabelSenastChange.Name = "LabelSenastChange";
            // 
            // Poddbibliotek
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(LabelSenastChange);
            Controls.Add(LabelSenast);
            Controls.Add(dataGridViewPodd);
            Controls.Add(comboBoxKat);
            Controls.Add(buttonAterstall);
            Controls.Add(buttonTaBortNamn);
            Controls.Add(buttonAndraNamn);
            Controls.Add(buttonLaggTillNamn);
            Controls.Add(textBoxURL);
            Controls.Add(LabelURL);
            Controls.Add(comboBoxKategori);
            Controls.Add(comboBoxMinuter);
            Controls.Add(textBoxNamn);
            Controls.Add(NamnLabel);
            Controls.Add(listBoxAvsnitt);
            Controls.Add(AvsnittLabel);
            Controls.Add(richTextBoxBeskrivning);
            Controls.Add(KategoriListaListBox);
            Controls.Add(button3TaBortKat);
            Controls.Add(button2AndraKat);
            Controls.Add(button1LaggTillKat);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1LaggTillKat;
        private Button button2AndraKat;
        private Button button3TaBortKat;
        private ListBox KategoriListaListBox;
        private RichTextBox richTextBoxBeskrivning;
        private Label AvsnittLabel;
        private ListBox listBoxAvsnitt;
        private Label NamnLabel;
        private TextBox textBoxNamn;
        private ComboBox comboBoxMinuter;
        private ComboBox comboBoxKategori;
        private Label LabelURL;
        private TextBox textBoxURL;
        private Button buttonLaggTillNamn;
        private Button buttonAndraNamn;
        private Button buttonTaBortNamn;
        private Button buttonAterstall;
        private ComboBox comboBoxKat;
        private DataGridView dataGridViewPodd;
        private Label LabelSenast;
        private Label LabelSenastChange;
    }
}
