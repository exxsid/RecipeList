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
using System.IO;

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

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new RecipeCard();

                card[i].CardTitle = recipes[i].Name;

                Image image = ByteArrayToImage(recipes[i].Image);

                card[i].SetPhoto(image);

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

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void RecipesView_Load(object sender, EventArgs e)
        {
            GenerateRecipeCard();
            MessageBox.Show("Recipe loaded");
        }

        public void RecioeVewReload()
        {
            GenerateRecipeCard();
        }

        private void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            RecipeformForm obj = new RecipeformForm();
            obj.Show();
        }
    }
}
