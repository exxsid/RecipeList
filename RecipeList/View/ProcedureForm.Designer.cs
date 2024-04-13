namespace RecipeList.View
{
    partial class ProcedureForm
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
            this.procedureView1 = new RecipeList.View.ProcedureView();
            this.SuspendLayout();
            // 
            // procedureView1
            // 
            this.procedureView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.procedureView1.AutoScroll = true;
            this.procedureView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.procedureView1.Id = 0;
            this.procedureView1.Location = new System.Drawing.Point(0, -1);
            this.procedureView1.Name = "procedureView1";
            this.procedureView1.Size = new System.Drawing.Size(730, 762);
            this.procedureView1.TabIndex = 0;
            // 
            // ProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.procedureView1);
            this.Name = "ProcedureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedures";
            this.Activated += new System.EventHandler(this.ProcedureForm_Activated);
            this.Load += new System.EventHandler(this.ProcedureForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProcedureView procedureView1;
    }
}