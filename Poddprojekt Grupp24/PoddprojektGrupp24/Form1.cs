using System.ComponentModel;
using BusinessLayer;
using Models;

namespace PoddprojektGrupp24
{
    public partial class Poddbibliotek : Form
    {
        CategeoryController catController;
        public Poddbibliotek()
        {
            catController = new CategeoryController("Category.xml");
            InitializeComponent();
            populateCategories();
        }

        private void populateCategories()
        {
            List<Category> list = catController.GetAll();
            foreach (Category category in list)
            {
                KategoriListaListBox.AppendText(category.Name + "\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1LaggTillKat_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim();
            catController.Add(name);
            KategoriListaListBox.Clear();
            populateCategories();
        }

        private void button2AndraKat_Click(object sender, EventArgs e)
        {

        }

        private void button3TaBortKat_Click(object sender, EventArgs e)
        {

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
    }
}

