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
            this.OptionPanel = new System.Windows.Forms.Label();
            this.ListButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.NavigationPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
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
            this.NavigationPanel.Size = new System.Drawing.Size(799, 50);
            this.NavigationPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.Controls.Add(this.OptionPanel);
            this.MenuPanel.Controls.Add(this.ListButton);
            this.MenuPanel.Location = new System.Drawing.Point(289, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(220, 44);
            this.MenuPanel.TabIndex = 2;
            // 
            // OptionPanel
            // 
            this.OptionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptionPanel.AutoSize = true;
            this.OptionPanel.Font = new System.Drawing.Font("JetBrainsMono NF", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionPanel.Location = new System.Drawing.Point(125, 14);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(72, 18);
            this.OptionPanel.TabIndex = 2;
            this.OptionPanel.Text = "Category";
            // 
            // ListButton
            // 
            this.ListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListButton.AutoSize = true;
            this.ListButton.Font = new System.Drawing.Font("JetBrainsMono NF", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListButton.Location = new System.Drawing.Point(26, 14);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(64, 18);
            this.ListButton.TabIndex = 1;
            this.ListButton.Text = "Recipes";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NavigationPanel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Recipe List";
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ListButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label OptionPanel;
    }
}

