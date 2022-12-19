namespace ProjectGuest
{
    partial class GuestsUI
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btInsertItem = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCategory.Location = new System.Drawing.Point(226, 19);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(134, 29);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "שם קטגוריה";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuestName.Location = new System.Drawing.Point(543, 19);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(103, 29);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "שם אורח";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(719, 167);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(332, 243);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(225, 26);
            this.txtItem.TabIndex = 2;
            this.txtItem.Visible = false;
            // 
            // btInsertItem
            // 
            this.btInsertItem.Location = new System.Drawing.Point(614, 239);
            this.btInsertItem.Name = "btInsertItem";
            this.btInsertItem.Size = new System.Drawing.Size(145, 35);
            this.btInsertItem.TabIndex = 3;
            this.btInsertItem.Text = "הכנסת פריט";
            this.btInsertItem.UseVisualStyleBackColor = true;
            this.btInsertItem.Click += new System.EventHandler(this.btInsertItem_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(131, 239);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(145, 34);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "אישור";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Visible = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(91, 289);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(719, 167);
            this.dataGridView2.TabIndex = 1;
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(614, 480);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(145, 36);
            this.btPrev.TabIndex = 3;
            this.btPrev.Text = "<<<<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(131, 480);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(145, 36);
            this.btNext.TabIndex = 3;
            this.btNext.Text = ">>>>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // GuestsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 535);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btInsertItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblCategory);
            this.Name = "GuestsUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "GuestsUI";
            this.Load += new System.EventHandler(this.GuestsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btInsertItem;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
    }
}