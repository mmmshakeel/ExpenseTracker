
namespace ExpenseTracker
{
    partial class ExpenseCategoryRow
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
            this.labelExpenseCategoryName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDeleteCategory = new ExpenseTracker.CustomElements.CategoryButton();
            this.buttonEditCategory = new ExpenseTracker.CustomElements.CategoryButton();
            this.SuspendLayout();
            // 
            // labelExpenseCategoryName
            // 
            this.labelExpenseCategoryName.AutoSize = true;
            this.labelExpenseCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenseCategoryName.Location = new System.Drawing.Point(5, 8);
            this.labelExpenseCategoryName.Name = "labelExpenseCategoryName";
            this.labelExpenseCategoryName.Size = new System.Drawing.Size(38, 15);
            this.labelExpenseCategoryName.TabIndex = 0;
            this.labelExpenseCategoryName.Text = "label1";
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDeleteCategory.Id = 0;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(512, 4);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(75, 22);
            this.buttonDeleteCategory.TabIndex = 2;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Id = 0;
            this.buttonEditCategory.Location = new System.Drawing.Point(413, 4);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(75, 22);
            this.buttonEditCategory.TabIndex = 1;
            this.buttonEditCategory.Text = "Edit";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            // 
            // ExpenseCategoryRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.labelExpenseCategoryName);
            this.Name = "ExpenseCategoryRow";
            this.Size = new System.Drawing.Size(600, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExpenseCategoryName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomElements.CategoryButton buttonEditCategory;
        private CustomElements.CategoryButton buttonDeleteCategory;
    }
}
