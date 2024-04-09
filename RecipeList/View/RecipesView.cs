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

namespace RecipeList.View
{
    public partial class RecipesView : UserControl
    {
        public RecipesView()
        {
            InitializeComponent();
        }

        public void GenerateRecipeCard()
        {
            recipeFlowLayout.Controls.Clear();

            RecipeCard[] card = new RecipeCard[4];

            string[] titles = new string[] { "Adobo", "Pakbet", "Denengdeng", "Chicken" };

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new RecipeCard();

                card[i].CardTitle = titles[i];

                recipeFlowLayout.Controls.Add(card[i]);

                card[i].GetCardTitleLabel().Click += RecipeCard_Click;
            }
        }

        private void RecipeCard_Click(object sender, EventArgs e)
        {
            Label title = (Label)sender;

            MessageBox.Show(title.Text);
        }

        private void RecipesView_Load(object sender, EventArgs e)
        {
            GenerateRecipeCard();
        }
    }
}
