namespace RecipeList.View.Component
{
    partial class CategoryCard
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
            this.CardTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardTitle
            // 
            this.CardTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardTitle.AutoSize = true;
            this.CardTitle.Font = new System.Drawing.Font("JetBrainsMono NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTitle.Location = new System.Drawing.Point(56, 25);
            this.CardTitle.Name = "CardTitle";
            this.CardTitle.Size = new System.Drawing.Size(109, 21);
            this.CardTitle.TabIndex = 1;
            this.CardTitle.Text = "CardTitle";
            this.CardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.CardTitle);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CategoryCard";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(220, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardTitle;
    }
}
