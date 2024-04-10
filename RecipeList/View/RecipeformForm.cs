using Microsoft.Win32;
using MySql.Data.MySqlClient;
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
    public partial class RecipeformForm : Form
    {
        public RecipeformForm()
        {
            InitializeComponent();
        }

        private void imageSelectorBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                var image = new Bitmap(filePath);
                pictureBox1.Image = image;

                filenameTextbox.Text = filePath;
            }
        }

        private void cancenlBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to cancel?", 
                                        "Cancel", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) this.Close();

        }

        private void saveRecipeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if all forms is filled
                if (
                    string.IsNullOrEmpty(ingerdientsTextBox.Text.Trim())
                    || string.IsNullOrEmpty(proceduresTextBox.Text.Trim())
                    || string.IsNullOrEmpty(descriptionTextBox.Text.Trim())
                    || string.IsNullOrEmpty(nameTextBox.Text.Trim())
                    || categoryComboBox.SelectedIndex < 0
                    )
                {
                    throw new Exception();
                }

                // convert image to byte array
                byte[] imageData = File.ReadAllBytes(openFileDialog1.FileName);

                List<string> ingredients = ingerdientsTextBox.Text.Split('\n').ToList();
                
                List<string> procedures = proceduresTextBox.Text.Split('\n').ToList();
               
                string descriptionText = descriptionTextBox.Text;

                string nameText = nameTextBox.Text;

                int category = categoryComboBox.SelectedIndex + 1;


                Recipe obj = new Recipe
                {
                    Id = 0,
                    Name = nameText,
                    Description = descriptionText,
                    Ingredients = ingredients,
                    Procedures = procedures,
                    Image = imageData,
                    Category = category.ToString(),
                };

                RecipeDAO recipeDAO = new RecipeDAO();
                recipeDAO.PostRecipe(obj);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Fill all forms");
            }
            this.Close();
        }
    }
}
