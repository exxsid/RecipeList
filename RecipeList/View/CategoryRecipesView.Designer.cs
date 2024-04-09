namespace RecipeList.View
{
    partial class CategoryRecipesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryRecipeFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // categoryRecipeFlowLayout
            // 
            this.categoryRecipeFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryRecipeFlowLayout.AutoScroll = true;
            this.categoryRecipeFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.categoryRecipeFlowLayout.Name = "categoryRecipeFlowLayout";
            this.categoryRecipeFlowLayout.Size = new System.Drawing.Size(492, 325);
            this.categoryRecipeFlowLayout.TabIndex = 0;
            // 
            // CategoryRecipesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 327);
            this.Controls.Add(this.categoryRecipeFlowLayout);
            this.Name = "CategoryRecipesView";
            this.Load += new System.EventHandler(this.CategoryRecipesView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel categoryRecipeFlowLayout;
    }
}
