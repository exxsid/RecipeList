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
    public partial class CategoriesView : UserControl
    {

        public CategoriesView()
        {
            InitializeComponent();
        }

        private void GenerateCategoryCard()
        {
            CategoriesLayoutPanel.Controls.Clear();

            CategoryCard[] cards = new CategoryCard[5];

            string[] title = new string[] { "Appetizer", "First Course", "Main Course", "Dessert", "Tangina" };
            for(int i = 0; i < cards.Length; i++)
            {
                cards[i] = new CategoryCard();
                cards[i].SetTitle(title[i]);

                CategoriesLayoutPanel.Controls.Add(cards[i]);
                cards[i].Enabled = true;
                cards[i].GetTitleLabel().Click += CategoryCard_Click;
            }
        }

        private void CategoryCard_Click(object sender, EventArgs e)
        {
            Label title = (Label)sender;
            MessageBox.Show(title.Text);
        }


        private void CategoriesView_Load(object sender, EventArgs e)
        {
            GenerateCategoryCard();
        }
    }
}
