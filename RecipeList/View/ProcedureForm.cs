using RecipeList.Model;
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
    public partial class ProcedureForm : Form
    {
        private RecipeDAO recipeDAO;
        public ProcedureForm(int id)
        {
            InitializeComponent();
            this.Id = id;
            recipeDAO = new RecipeDAO();
        }

        public int Id { set; get; }

        private void ProcedureForm_Load(object sender, EventArgs e)
        {
            Recipe recipe = recipeDAO.GetRecipeById(Id);

            procedureView1.SetName(recipe.Name);
            procedureView1.SetCategory(recipe.Category);
            procedureView1.SetDescription(recipe.Description);
            procedureView1.SetIngredients(recipe.Ingredients);
            procedureView1.SetProcedure(recipe.Procedures);
            procedureView1.Id = this.Id;

            Image image = ByteArrayToImage(recipe.Image);
            procedureView1.SetImage(image);
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
