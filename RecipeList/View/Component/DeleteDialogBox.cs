using RecipeList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeList.View.Component
{
    public partial class DeleteDialogBox : Form
    {
        private int id;
        public DeleteDialogBox(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text.Trim()))
            {
                MessageBox.Show("Fill out the password");
                return;
            }
            if (!passwordTextBox.Text.Trim().Equals("password"))
            {
                MessageBox.Show("Wrong password");
                passwordTextBox.Clear();
                return;
            }

            RecipeDAO obj = new RecipeDAO();
            bool res = obj.DeleteRecipe(this.id);
            if (res)
            {
                MessageBox.Show("Deleted successfully");
                return;
            }
            MessageBox.Show("Deletion failed");
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


