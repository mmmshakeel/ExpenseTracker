
namespace ExpenseTracker
{
    partial class ShowExpenseCategories
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
            this.buttonExpenseCategorySave = new System.Windows.Forms.Button();
            this.buttonExpenseCategoryDiscard = new System.Windows.Forms.Button();
            this.textBoxExpenseCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelExpenseCategories = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expense Categories";
            // 
            // buttonExpenseCategorySave
            // 
            this.buttonExpenseCategorySave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExpenseCategorySave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpenseCategorySave.Location = new System.Drawing.Point(355, 435);
            this.buttonExpenseCategorySave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonExpenseCategorySave.Name = "buttonExpenseCategorySave";
            this.buttonExpenseCategorySave.Size = new System.Drawing.Size(70, 32);
            this.buttonExpenseCategorySave.TabIndex = 9;
            this.buttonExpenseCategorySave.Text = global::ExpenseTracker.Properties.Resources.BTN_TXT_SAVE;
            this.buttonExpenseCategorySave.UseVisualStyleBackColor = false;
            this.buttonExpenseCategorySave.Click += new System.EventHandler(this.save);
            // 
            // buttonExpenseCategoryDiscard
            // 
            this.buttonExpenseCategoryDiscard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpenseCategoryDiscard.Location = new System.Drawing.Point(258, 435);
            this.buttonExpenseCategoryDiscard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonExpenseCategoryDiscard.Name = "buttonExpenseCategoryDiscard";
            this.buttonExpenseCategoryDiscard.Size = new System.Drawing.Size(70, 32);
            this.buttonExpenseCategoryDiscard.TabIndex = 8;
            this.buttonExpenseCategoryDiscard.Text = global::ExpenseTracker.Properties.Resources.BTN_TXT_DISCARD;
            this.buttonExpenseCategoryDiscard.UseVisualStyleBackColor = true;
            this.buttonExpenseCategoryDiscard.Click += new System.EventHandler(this.Discard);
            // 
            // textBoxExpenseCategory
            // 
            this.textBoxExpenseCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpenseCategory.Location = new System.Drawing.Point(9, 441);
            this.textBoxExpenseCategory.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxExpenseCategory.Name = "textBoxExpenseCategory";
            this.textBoxExpenseCategory.Size = new System.Drawing.Size(222, 23);
            this.textBoxExpenseCategory.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add/Edit Expense Category";
            // 
            // panelExpenseCategories
            // 
            this.panelExpenseCategories.AutoScroll = true;
            this.panelExpenseCategories.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelExpenseCategories.Location = new System.Drawing.Point(11, 37);
            this.panelExpenseCategories.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelExpenseCategories.Name = "panelExpenseCategories";
            this.panelExpenseCategories.Size = new System.Drawing.Size(620, 372);
            this.panelExpenseCategories.TabIndex = 10;
            // 
            // ShowExpenseCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.buttonExpenseCategorySave);
            this.Controls.Add(this.buttonExpenseCategoryDiscard);
            this.Controls.Add(this.textBoxExpenseCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelExpenseCategories);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowExpenseCategories";
            this.Text = "Show Expense Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExpenseCategorySave;
        private System.Windows.Forms.Button buttonExpenseCategoryDiscard;
        private System.Windows.Forms.TextBox textBoxExpenseCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelExpenseCategories;
    }
}