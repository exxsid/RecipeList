using RecipeList.Model;
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

namespace RecipeList.View
{
    public partial class CategoryRecipesView : Form
    {
        private RecipeDAO recipeDAO;
        public CategoryRecipesView(string category)
        {
            InitializeComponent();
            recipeDAO = new RecipeDAO();
            this.Category = category;
        }

        public string Category
        {
            get; set;
        }

        public void GenerateRecipeCard()
        {
            categoryRecipeFlowLayout.Controls.Clear();

            List<Recipe> recipes = recipeDAO.GetRecipeByCategory(this.Category);

            RecipeCard[] card = new RecipeCard[recipes.Count];

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new RecipeCard();

                card[i].CardTitle = recipes[i].Name;

                Image image = ByteArrayToImage(recipes[i].Image);
                card[i].SetPhoto(image);

                categoryRecipeFlowLayout.Controls.Add(card[i]);
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

        private void CategoryRecipesView_Load(object sender, EventArgs e)
        {
            GenerateRecipeCard();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void CategoryRecipesView_Activated(object sender, EventArgs e)
        {
            GenerateRecipeCard();
        }
    }
}
