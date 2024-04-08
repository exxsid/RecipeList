namespace RecipeList.View
{
    partial class RecipesView
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
            this.RecipeListView = new System.Windows.Forms.ListView();
            this.AddRecipeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipeListView
            // 
            this.RecipeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecipeListView.HideSelection = false;
            this.RecipeListView.Location = new System.Drawing.Point(10, 10);
            this.RecipeListView.Name = "RecipeListView";
            this.RecipeListView.Size = new System.Drawing.Size(539, 285);
            this.RecipeListView.TabIndex = 0;
            this.RecipeListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddRecipeBtn
            // 
            this.AddRecipeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecipeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRecipeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.AddRecipeBtn.FlatAppearance.BorderSize = 0;
            this.AddRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecipeBtn.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipeBtn.Location = new System.Drawing.Point(418, 310);
            this.AddRecipeBtn.Name = "AddRecipeBtn";
            this.AddRecipeBtn.Size = new System.Drawing.Size(131, 31);
            this.AddRecipeBtn.TabIndex = 1;
            this.AddRecipeBtn.Text = "Add Recipe";
            this.AddRecipeBtn.UseVisualStyleBackColor = false;
            // 
            // RecipesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.AddRecipeBtn);
            this.Controls.Add(this.RecipeListView);
            this.Name = "RecipesView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(559, 354);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RecipeListView;
        private System.Windows.Forms.Button AddRecipeBtn;
    }
}
