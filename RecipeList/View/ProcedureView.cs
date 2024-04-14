using RecipeList.Model;
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
    public partial class ProcedureView : UserControl
    {
        public ProcedureView()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public void SetName(string name )
        {
            this.name.Text = name;
        }

        public void SetCategory(string cat)
        {
            this.category.Text = cat;
        }

        public void SetDescription(string desc)
        {
            this.description.Text = desc;
        }

        public void SetIngredients(List<string> i)
        {
            string text = "";
            foreach(string j in i)
            {
                text += $"- {j} {Environment.NewLine}";
            }

            this.ingredients.Text = text;
        }

        public void SetProcedure(List<string> p)
        {
            string text = "";
            foreach (string j in p)
            {
                text += $"- {j} {Environment.NewLine}";
            }

            this.procedures.Text = text;
        }

        public void SetImage(Image image)
        {
            this.procedurePhoto.Image = image;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditDialogBox editDialog = new EditDialogBox();
            editDialog.ShowDialog();
            if (!editDialog.DialogResult)
            {
                return;
            }
            RecipeformForm form = new RecipeformForm();
            form.SetName(name.Text);
            form.SetCategory(category.Text);
            form.SetDescription(description.Text);
            form.SetIngridients(ingredients.Text);
            form.SetProcedures(procedures.Text);
            form.Text = "Edit";
            form.Tag = this.Id;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteDialogBox deleteDialogBox = new DeleteDialogBox(this.Id);
            deleteDialogBox.Show();
        }
    }
}
