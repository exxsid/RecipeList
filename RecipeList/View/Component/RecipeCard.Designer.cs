namespace RecipeList.View.Component
{
    partial class RecipeCard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cardTitle = new System.Windows.Forms.Label();
            this.cardPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cardTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cardPhoto, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.54298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.45701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 221);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cardTitle
            // 
            this.cardTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardTitle.AutoSize = true;
            this.cardTitle.Font = new System.Drawing.Font("JetBrainsMono NF", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitle.Location = new System.Drawing.Point(47, 191);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(53, 17);
            this.cardTitle.TabIndex = 1;
            this.cardTitle.Text = "Title";
            // 
            // cardPhoto
            // 
            this.cardPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPhoto.Location = new System.Drawing.Point(8, 5);
            this.cardPhoto.Name = "cardPhoto";
            this.cardPhoto.Size = new System.Drawing.Size(131, 167);
            this.cardPhoto.TabIndex = 2;
            this.cardPhoto.TabStop = false;
            // 
            // RecipeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecipeCard";
            this.Size = new System.Drawing.Size(148, 221);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cardTitle;
        private System.Windows.Forms.PictureBox cardPhoto;
    }
}
