namespace ProjectEventMeals
{
    partial class ProjectHost
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listCategories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(277, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "מארח - הזן קטגוריות";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(282, 88);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(213, 26);
            this.txtCategory.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(311, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(154, 46);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "הכנס";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listCategories
            // 
            this.listCategories.FormattingEnabled = true;
            this.listCategories.ItemHeight = 20;
            this.listCategories.Location = new System.Drawing.Point(282, 203);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(213, 204);
            this.listCategories.TabIndex = 3;
            // 
            // ProjectHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "ProjectHost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ProjectHost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listCategories;
    }
}