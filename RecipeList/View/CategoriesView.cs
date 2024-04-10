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
using RecipeList.Model;

namespace RecipeList.View
{
    public partial class CategoriesView : UserControl
    {
        private CategoryDAO categoryDao;

        public CategoriesView()
        {
            InitializeComponent();
            categoryDao = new CategoryDAO();
        }

        // generate category card inside the category view
        private void GenerateCategoryCard()
        {
            // clear any control inside the flowlayout
            CategoriesLayoutPanel.Controls.Clear();

            // get categories in the database
            List<Category> categories = categoryDao.GetCategories();

            CategoryCard[] cards = new CategoryCard[categories.Count];

            for(int i = 0; i < cards.Length; i++)
            {
                cards[i] = new CategoryCard();
                cards[i].SetTitle(categories[i].Name.ToUpper());
                cards[i].GetTitleLabel().Tag = categories[i].Id;

                CategoriesLayoutPanel.Controls.Add(cards[i]);
                cards[i].Enabled = true;
                cards[i].GetTitleLabel().Click += CategoryCard_Click;
            }
        }

        // listener for when the category card is clicked
        public void CategoryCard_Click(object sender, EventArgs e)
        {
            Label title = (Label)sender;
            CategoryRecipesView obj = new CategoryRecipesView(title.Text.ToLower());
            obj.Text = $"Category: {title.Text}";
            obj.Show();
        }


        private void CategoriesView_Load(object sender, EventArgs e)
        {
            GenerateCategoryCard();
        }

        public void CategoriesViewReload()
        {
            GenerateCategoryCard();
        }
    }
}
