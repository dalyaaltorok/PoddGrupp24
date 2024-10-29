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
                checkedListBoxCat.Items.Add(category.Name, false); //Lägger till en item i kategoriboxen. "false" innebär att ett item inte ska vara iklickat efter att det skapats.  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1LaggTillKat_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim(); //Ser till att ta bort onädiga spaces i början och slutet av kategorinamnfältet.
            catController.Add(name);
            checkedListBoxCat.Items.Clear(); //Rensar boxen innan den populeras på nytt i nedan metod.
            populateCategories();
        }

        private void button2AndraKat_Click(object sender, EventArgs e)
        {

        }

        private void button3TaBortKat_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to remove this category?";
            string title = "Category";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show(message, title, buttons);
            int index = checkedListBoxCat.SelectedIndex;

            if (dialog == DialogResult.Yes)
            { 
                if (index >= 0)
                {
                    catController.RemoveItem(index);

                    checkedListBoxCat.Items.Remove(index);

                    MessageBox.Show("You have successfully removed this category!");
                }
            }
            else
            {
                MessageBox.Show("Please select a category to remove");
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
    }
}

