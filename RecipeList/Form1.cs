using RecipeList.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            recipesView.RecioeVewReload();
            panel1.Show();
            panel2.Hide();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            categoriesView1.CategoriesViewReload();
            panel2.Show();
            panel1.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }


        private void ListButton_MouseLeave(object sender, EventArgs e)
        {
            ListButton.BackColor = Color.FromArgb(196, 223, 223);
        }

        private void ListButton_MouseEnter(object sender, EventArgs e)
        {
            ListButton.BackColor = Color.AliceBlue;
        }

    }
}
