namespace RecipeList
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CategoryBtn = new System.Windows.Forms.Label();
            this.ListButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recipesView = new RecipeList.View.RecipesView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.categoriesView1 = new RecipeList.View.CategoriesView();
            this.NavigationPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.NavigationPanel.Controls.Add(this.MenuPanel);
            this.NavigationPanel.Controls.Add(this.Title);
            this.NavigationPanel.Location = new System.Drawing.Point(1, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(883, 50);
            this.NavigationPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.Controls.Add(this.CategoryBtn);
            this.MenuPanel.Controls.Add(this.ListButton);
            this.MenuPanel.Location = new System.Drawing.Point(289, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(304, 44);
            this.MenuPanel.TabIndex = 2;
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryBtn.AutoSize = true;
            this.CategoryBtn.Font = new System.Drawing.Font("JetBrainsMono NF", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBtn.Location = new System.Drawing.Point(167, 14);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(72, 18);
            this.CategoryBtn.TabIndex = 2;
            this.CategoryBtn.Text = "Category";
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // ListButton
            // 
            this.ListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListButton.AutoSize = true;
            this.ListButton.Font = new System.Drawing.Font("JetBrainsMono NF", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListButton.Location = new System.Drawing.Point(68, 14);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(64, 18);
            this.ListButton.TabIndex = 1;
            this.ListButton.Text = "Recipes";
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            this.ListButton.MouseEnter += new System.EventHandler(this.ListButton_MouseEnter);
            this.ListButton.MouseLeave += new System.EventHandler(this.ListButton_MouseLeave);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("JetBrainsMono NF", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Title.Location = new System.Drawing.Point(21, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "SANGKAP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recipesView);
            this.panel1.Location = new System.Drawing.Point(1, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 454);
            this.panel1.TabIndex = 1;
            // 
            // recipesView
            // 
            this.recipesView.AutoScroll = true;
            this.recipesView.AutoSize = true;
            this.recipesView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recipesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.recipesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesView.Location = new System.Drawing.Point(0, 0);
            this.recipesView.Name = "recipesView";
            this.recipesView.Padding = new System.Windows.Forms.Padding(10);
            this.recipesView.Size = new System.Drawing.Size(883, 454);
            this.recipesView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.categoriesView1);
            this.panel2.Location = new System.Drawing.Point(1, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 454);
            this.panel2.TabIndex = 1;
            // 
            // categoriesView1
            // 
            this.categoriesView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.categoriesView1.Location = new System.Drawing.Point(155, 38);
            this.categoriesView1.Margin = new System.Windows.Forms.Padding(10);
            this.categoriesView1.Name = "categoriesView1";
            this.categoriesView1.Size = new System.Drawing.Size(560, 350);
            this.categoriesView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ListButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label CategoryBtn;
        private System.Windows.Forms.Panel panel1;
        private View.RecipesView recipesView;
        private System.Windows.Forms.Panel panel2;
        private View.CategoriesView categoriesView1;
    }
}

