
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
            this.panelIncomeSource = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIncomeSource = new System.Windows.Forms.TextBox();
            this.buttonIncomeSourceDiscard = new System.Windows.Forms.Button();
            this.buttonIncomeSourceSave = new System.Windows.Forms.Button();
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
            // panelIncomeSource
            // 
            this.panelIncomeSource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelIncomeSource.Location = new System.Drawing.Point(10, 31);
            this.panelIncomeSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelIncomeSource.Name = "panelIncomeSource";
            this.panelIncomeSource.Size = new System.Drawing.Size(630, 372);
            this.panelIncomeSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add/Edit Income Source";
            // 
            // textBoxIncomeSource
            // 
            this.textBoxIncomeSource.Location = new System.Drawing.Point(10, 436);
            this.textBoxIncomeSource.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxIncomeSource.Name = "textBoxIncomeSource";
            this.textBoxIncomeSource.Size = new System.Drawing.Size(222, 20);
            this.textBoxIncomeSource.TabIndex = 2;
            // 
            // buttonIncomeSourceDiscard
            // 
            this.buttonIncomeSourceDiscard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncomeSourceDiscard.Location = new System.Drawing.Point(251, 430);
            this.buttonIncomeSourceDiscard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonIncomeSourceDiscard.Name = "buttonIncomeSourceDiscard";
            this.buttonIncomeSourceDiscard.Size = new System.Drawing.Size(70, 32);
            this.buttonIncomeSourceDiscard.TabIndex = 0;
            this.buttonIncomeSourceDiscard.Text = "Discard";
            this.buttonIncomeSourceDiscard.UseVisualStyleBackColor = true;
            this.buttonIncomeSourceDiscard.Click += new System.EventHandler(this.Discard);
            // 
            // buttonIncomeSourceSave
            // 
            this.buttonIncomeSourceSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIncomeSourceSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncomeSourceSave.Location = new System.Drawing.Point(340, 430);
            this.buttonIncomeSourceSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonIncomeSourceSave.Name = "buttonIncomeSourceSave";
            this.buttonIncomeSourceSave.Size = new System.Drawing.Size(70, 32);
            this.buttonIncomeSourceSave.TabIndex = 3;
            this.buttonIncomeSourceSave.Text = "Save";
            this.buttonIncomeSourceSave.UseVisualStyleBackColor = false;
            this.buttonIncomeSourceSave.Click += new System.EventHandler(this.Save);
            // 
            // ShowIncomeSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.buttonIncomeSourceSave);
            this.Controls.Add(this.buttonIncomeSourceDiscard);
            this.Controls.Add(this.textBoxIncomeSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelIncomeSource);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ShowIncomeSources";
            this.Text = "Show Income Sources";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIncomeSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIncomeSource;
        private System.Windows.Forms.Button buttonIncomeSourceDiscard;
        private System.Windows.Forms.Button buttonIncomeSourceSave;
    }
}