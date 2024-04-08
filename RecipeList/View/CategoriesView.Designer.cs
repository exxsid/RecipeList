namespace RecipeList.View
{
    partial class CategoriesView
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
            this.CategoriesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryCard1 = new RecipeList.View.Component.CategoryCard();
            this.categoryCard2 = new RecipeList.View.Component.CategoryCard();
            this.CategoriesLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesLayoutPanel
            // 
            this.CategoriesLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriesLayoutPanel.AutoSize = true;
            this.CategoriesLayoutPanel.Controls.Add(this.categoryCard1);
            this.CategoriesLayoutPanel.Controls.Add(this.categoryCard2);
            this.CategoriesLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.CategoriesLayoutPanel.Name = "CategoriesLayoutPanel";
            this.CategoriesLayoutPanel.Size = new System.Drawing.Size(536, 324);
            this.CategoriesLayoutPanel.TabIndex = 0;
            // 
            // categoryCard1
            // 
            this.categoryCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.categoryCard1.Location = new System.Drawing.Point(5, 5);
            this.categoryCard1.Margin = new System.Windows.Forms.Padding(5);
            this.categoryCard1.Name = "categoryCard1";
            this.categoryCard1.Padding = new System.Windows.Forms.Padding(8);
            this.categoryCard1.Size = new System.Drawing.Size(130, 60);
            this.categoryCard1.TabIndex = 0;
            // 
            // categoryCard2
            // 
            this.categoryCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.categoryCard2.Location = new System.Drawing.Point(145, 5);
            this.categoryCard2.Margin = new System.Windows.Forms.Padding(5);
            this.categoryCard2.Name = "categoryCard2";
            this.categoryCard2.Padding = new System.Windows.Forms.Padding(8);
            this.categoryCard2.Size = new System.Drawing.Size(130, 60);
            this.categoryCard2.TabIndex = 1;
            // 
            // CategoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.CategoriesLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "CategoriesView";
            this.Size = new System.Drawing.Size(560, 350);
            this.CategoriesLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoriesLayoutPanel;
        private Component.CategoryCard categoryCard1;
        private Component.CategoryCard categoryCard2;
    }
}
