namespace NibmFinalProjectExpenseTracker
{
    partial class ExpenseTrackHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseTrackHome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormal = new System.Windows.Forms.Button();
            this.btnRemoveExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(156, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select What Is Required";
            // 
            // btnFormal
            // 
            this.btnFormal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormal.BackgroundImage")));
            this.btnFormal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormal.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnFormal.Location = new System.Drawing.Point(292, 133);
            this.btnFormal.Name = "btnFormal";
            this.btnFormal.Size = new System.Drawing.Size(215, 42);
            this.btnFormal.TabIndex = 6;
            this.btnFormal.Text = "Add An Entry";
            this.btnFormal.UseVisualStyleBackColor = false;
            this.btnFormal.Click += new System.EventHandler(this.btnFormal_Click);
            // 
            // btnRemoveExpense
            // 
            this.btnRemoveExpense.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveExpense.BackgroundImage")));
            this.btnRemoveExpense.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveExpense.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveExpense.Location = new System.Drawing.Point(292, 344);
            this.btnRemoveExpense.Name = "btnRemoveExpense";
            this.btnRemoveExpense.Size = new System.Drawing.Size(215, 42);
            this.btnRemoveExpense.TabIndex = 8;
            this.btnRemoveExpense.Text = "Remove An Entry";
            this.btnRemoveExpense.UseVisualStyleBackColor = false;
            this.btnRemoveExpense.Click += new System.EventHandler(this.btnRemoveExpense_Click);
            // 
            // ExpenseTrackHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnRemoveExpense);
            this.Controls.Add(this.btnFormal);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExpenseTrackHome";
            this.Text = "Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormal;
        private System.Windows.Forms.Button btnRemoveExpense;
    }
}