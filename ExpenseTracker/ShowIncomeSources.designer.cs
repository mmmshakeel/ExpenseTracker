
namespace ExpenseTracker
{
    partial class ShowIncomeSources
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIncomeSource = new System.Windows.Forms.TextBox();
            this.buttonDiscardIncomeSource = new System.Windows.Forms.Button();
            this.buttonSaveIncomeSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income Sources";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 365);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add/Edit Income Source";
            // 
            // textBoxIncomeSource
            // 
            this.textBoxIncomeSource.Location = new System.Drawing.Point(10, 429);
            this.textBoxIncomeSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxIncomeSource.Name = "textBoxIncomeSource";
            this.textBoxIncomeSource.Size = new System.Drawing.Size(222, 20);
            this.textBoxIncomeSource.TabIndex = 2;
            // 
            // buttonDiscardIncomeSource
            // 
            this.buttonDiscardIncomeSource.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscardIncomeSource.Location = new System.Drawing.Point(251, 423);
            this.buttonDiscardIncomeSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDiscardIncomeSource.Name = "buttonDiscardIncomeSource";
            this.buttonDiscardIncomeSource.Size = new System.Drawing.Size(70, 32);
            this.buttonDiscardIncomeSource.TabIndex = 0;
            this.buttonDiscardIncomeSource.Text = "Discard";
            this.buttonDiscardIncomeSource.UseVisualStyleBackColor = true;
            this.buttonDiscardIncomeSource.Click += new System.EventHandler(this.DiscardIncomeSource);
            // 
            // buttonSaveIncomeSource
            // 
            this.buttonSaveIncomeSource.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveIncomeSource.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveIncomeSource.Location = new System.Drawing.Point(340, 423);
            this.buttonSaveIncomeSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSaveIncomeSource.Name = "buttonSaveIncomeSource";
            this.buttonSaveIncomeSource.Size = new System.Drawing.Size(70, 32);
            this.buttonSaveIncomeSource.TabIndex = 3;
            this.buttonSaveIncomeSource.Text = "Save";
            this.buttonSaveIncomeSource.UseVisualStyleBackColor = false;
            this.buttonSaveIncomeSource.Click += new System.EventHandler(this.AddIncomeSource);
            // 
            // ShowIncomeSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.buttonSaveIncomeSource);
            this.Controls.Add(this.buttonDiscardIncomeSource);
            this.Controls.Add(this.textBoxIncomeSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowIncomeSources";
            this.Text = "Show Income Sources";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIncomeSource;
        private System.Windows.Forms.Button buttonDiscardIncomeSource;
        private System.Windows.Forms.Button buttonSaveIncomeSource;
    }
}