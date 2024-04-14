using RecipeList.Model;
using RecipeList.View;
using RecipeList.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            panel3.Hide();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            categoriesView1.CategoriesViewReload();
            panel2.Show();
            panel1.Hide();
            panel3.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel3.Hide();
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

        private void MainForm_Enter(object sender, EventArgs e)
        {
            categoriesView1.CategoriesViewReload();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //MainForm obj = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            //if (obj != null)
            //{
            //}
            recipesView.RecioeVewReload();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchFlowLayoutPanel.Controls.Clear();
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            RecipeDAO recipeDAO = new RecipeDAO();
            string query = searchTextBox.Text;
            List<Recipe> recipes = recipeDAO.GetRecipeByString(query);

            RecipeCard[] card = new RecipeCard[recipes.Count];

            for(int i = 0; i < recipes.Count; i++)
            {
                card[i] = new RecipeCard();

                card[i].CardTitle = recipes[i].Name;

                Image image = ByteArrayToImage(recipes[i].Image);

                card[i].SetPhoto(image);

                searchFlowLayoutPanel.Controls.Add(card[i]);
                card[i].GetCardTitleLabel().Tag = recipes[i].Id;
                card[i].GetCardTitleLabel().Click += RecipeCard_Click;
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void RecipeCard_Click(object sender, EventArgs e)
        {
            Label title = (Label)sender;

            ProcedureForm procedureForm = new ProcedureForm((int)title.Tag);
            procedureForm.Show();
        }
    }
}
