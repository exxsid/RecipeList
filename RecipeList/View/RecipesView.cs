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
    public partial class RecipesView : UserControl
    {
        private RecipeDAO recipeDAO;
        public RecipesView()
        {
            InitializeComponent();
            recipeDAO = new RecipeDAO();
        }

        public void GenerateRecipeCard()
        {
            recipeFlowLayout.Controls.Clear();

            List<Recipe> recipes = recipeDAO.GetRecipes();

            RecipeCard[] card = new RecipeCard[recipes.Count];

            string[] titles = new string[] { "Adobo", "Pakbet", "Denengdeng", "Chicken" };

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new RecipeCard();

                card[i].CardTitle = recipes[i].Name;
                

                recipeFlowLayout.Controls.Add(card[i]);
                card[i].GetCardTitleLabel().Tag = recipes[i].Id;
                card[i].GetCardTitleLabel().Click += RecipeCard_Click;
            }
        }

        private void RecipeCard_Click(object sender, EventArgs e)
        {
            Label title = (Label)sender;

            ProcedureForm procedureForm = new ProcedureForm((int)title.Tag);
            procedureForm.Show();
        }

        private void RecipesView_Load(object sender, EventArgs e)
        {
            GenerateRecipeCard();
        }
    }
}
