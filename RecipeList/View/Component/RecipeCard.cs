using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeList.View.Component
{
    public partial class RecipeCard : UserControl
    {
        public RecipeCard()
        {
            InitializeComponent();
        }

        public string CardTitle
        {
            get
            {
                return cardTitle.Text;
            }
            set
            {
                cardTitle.Text = value;
            }
        }

        public string CardPhotoLocation
        {
            get
            {
                return cardPhoto.ImageLocation;
            }
            set
            {
                cardPhoto.ImageLocation = value;
            }
        }

        public Label GetCardTitleLabel()
        {
            return cardTitle;
        }
    }
}
