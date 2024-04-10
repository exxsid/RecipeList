namespace RecipeList.View
{
    partial class RecipeformForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeformForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ingerdientsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proceduresTextBox = new System.Windows.Forms.TextBox();
            this.imageSelectorBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filenameTextbox = new System.Windows.Forms.TextBox();
            this.saveRecipeBtn = new System.Windows.Forms.Button();
            this.cancenlBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(131, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Appetizer",
            "First Course",
            "Main Course",
            "Dessert"});
            this.categoryComboBox.Location = new System.Drawing.Point(131, 43);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(209, 22);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 71);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(209, 67);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingredients";
            // 
            // ingerdientsTextBox
            // 
            this.ingerdientsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ingerdientsTextBox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingerdientsTextBox.Location = new System.Drawing.Point(131, 179);
            this.ingerdientsTextBox.Multiline = true;
            this.ingerdientsTextBox.Name = "ingerdientsTextBox";
            this.ingerdientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingerdientsTextBox.Size = new System.Drawing.Size(209, 78);
            this.ingerdientsTextBox.TabIndex = 7;
            this.ingerdientsTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrainsMono NF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Procedures";
            // 
            // proceduresTextBox
            // 
            this.proceduresTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proceduresTextBox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceduresTextBox.Location = new System.Drawing.Point(131, 263);
            this.proceduresTextBox.Multiline = true;
            this.proceduresTextBox.Name = "proceduresTextBox";
            this.proceduresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proceduresTextBox.Size = new System.Drawing.Size(209, 78);
            this.proceduresTextBox.TabIndex = 9;
            this.proceduresTextBox.TabStop = false;
            // 
            // imageSelectorBtn
            // 
            this.imageSelectorBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageSelectorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.imageSelectorBtn.FlatAppearance.BorderSize = 0;
            this.imageSelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageSelectorBtn.Location = new System.Drawing.Point(4, 349);
            this.imageSelectorBtn.Name = "imageSelectorBtn";
            this.imageSelectorBtn.Size = new System.Drawing.Size(121, 23);
            this.imageSelectorBtn.TabIndex = 10;
            this.imageSelectorBtn.Text = "Select Image";
            this.imageSelectorBtn.UseVisualStyleBackColor = false;
            this.imageSelectorBtn.Click += new System.EventHandler(this.imageSelectorBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // filenameTextbox
            // 
            this.filenameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenameTextbox.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameTextbox.Location = new System.Drawing.Point(131, 347);
            this.filenameTextbox.Name = "filenameTextbox";
            this.filenameTextbox.ReadOnly = true;
            this.filenameTextbox.Size = new System.Drawing.Size(209, 22);
            this.filenameTextbox.TabIndex = 12;
            // 
            // saveRecipeBtn
            // 
            this.saveRecipeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveRecipeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.saveRecipeBtn.FlatAppearance.BorderSize = 0;
            this.saveRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRecipeBtn.Location = new System.Drawing.Point(264, 482);
            this.saveRecipeBtn.Name = "saveRecipeBtn";
            this.saveRecipeBtn.Size = new System.Drawing.Size(75, 23);
            this.saveRecipeBtn.TabIndex = 13;
            this.saveRecipeBtn.Text = "Save";
            this.saveRecipeBtn.UseVisualStyleBackColor = false;
            this.saveRecipeBtn.Click += new System.EventHandler(this.saveRecipeBtn_Click);
            // 
            // cancenlBtn
            // 
            this.cancenlBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancenlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancenlBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancenlBtn.Location = new System.Drawing.Point(173, 482);
            this.cancenlBtn.Name = "cancenlBtn";
            this.cancenlBtn.Size = new System.Drawing.Size(75, 23);
            this.cancenlBtn.TabIndex = 14;
            this.cancenlBtn.Text = "Cancel";
            this.cancenlBtn.UseVisualStyleBackColor = true;
            this.cancenlBtn.Click += new System.EventHandler(this.cancenlBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter the ingredients and procedures one per line";
            // 
            // RecipeformForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(367, 587);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancenlBtn);
            this.Controls.Add(this.saveRecipeBtn);
            this.Controls.Add(this.filenameTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageSelectorBtn);
            this.Controls.Add(this.proceduresTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingerdientsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RecipeformForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "RecipeformForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ingerdientsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox proceduresTextBox;
        private System.Windows.Forms.Button imageSelectorBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox filenameTextbox;
        private System.Windows.Forms.Button saveRecipeBtn;
        private System.Windows.Forms.Button cancenlBtn;
        private System.Windows.Forms.Label label6;
    }
}