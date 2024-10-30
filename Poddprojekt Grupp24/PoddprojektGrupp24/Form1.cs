using System.ComponentModel;
using System.DirectoryServices;
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
                checkedListBoxCat.Items.Add(category.Name, false); //L�gger till en item i kategoriboxen. "false" inneb�r att ett item inte ska vara iklickat efter att det skapats.  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1LaggTillKat_Click(object sender, EventArgs e)
        {
            String name = textBoxNyKategori.Text.Trim(); //Ser till att ta bort on�diga spaces i b�rjan och slutet av kategorinamnf�ltet.
            catController.Add(name);
            checkedListBoxCat.Items.Clear(); //Rensar boxen innan den populeras p� nytt i nedan metod.
            populateCategories();
        }

        private void button2AndraKat_Click(object sender, EventArgs e)
        {
            int index = checkedListBoxCat.SelectedIndex;
            if (index >= 0)
            {
                string newName = textBoxNyKategori.Text.Trim();
                if (!string.IsNullOrEmpty(newName))
                {
                    catController.UpdateItem(newName, index);
                    checkedListBoxCat.Items[index] = newName;
                    checkedListBoxCat.Items.Clear();
                    populateCategories();
                }
            }

        }

        private void button3TaBortKat_Click(object sender, EventArgs e)
        {
            int index = checkedListBoxCat.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a category to remove");
                return;
            }

            string message = "Are you sure you want to remove this category?";
            string title = "Category";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);

            if (dialog == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    catController.RemoveItem(index);

                    checkedListBoxCat.Items.Remove(index);

                    MessageBox.Show("You have successfully removed this category!");
                }
            }
            checkedListBoxCat.Items.Clear();
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

        private void toolTipFrivilligKategori_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

