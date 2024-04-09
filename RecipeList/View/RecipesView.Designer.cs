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
            this.AddRecipeBtn = new System.Windows.Forms.Button();
            this.recipeFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddRecipeBtn
            // 
            this.AddRecipeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecipeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRecipeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.AddRecipeBtn.FlatAppearance.BorderSize = 0;
            this.AddRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecipeBtn.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipeBtn.Location = new System.Drawing.Point(421, 310);
            this.AddRecipeBtn.Name = "AddRecipeBtn";
            this.AddRecipeBtn.Size = new System.Drawing.Size(131, 31);
            this.AddRecipeBtn.TabIndex = 1;
            this.AddRecipeBtn.Text = "Add Recipe";
            this.AddRecipeBtn.UseVisualStyleBackColor = false;
            // 
            // recipeFlowLayout
            // 
            this.recipeFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeFlowLayout.Location = new System.Drawing.Point(10, 12);
            this.recipeFlowLayout.Name = "recipeFlowLayout";
            this.recipeFlowLayout.Size = new System.Drawing.Size(539, 292);
            this.recipeFlowLayout.TabIndex = 2;
            // 
            // RecipesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.recipeFlowLayout);
            this.Controls.Add(this.AddRecipeBtn);
            this.Name = "RecipesView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(562, 354);
            this.Load += new System.EventHandler(this.RecipesView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddRecipeBtn;
        private System.Windows.Forms.FlowLayoutPanel recipeFlowLayout;
    }
}
