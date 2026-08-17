namespace NibmFinalProjectExpenseTracker
{
    partial class AdvertsHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertsHome));
            this.btnRemoveBudget = new System.Windows.Forms.Button();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveBudget
            // 
            this.btnRemoveBudget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveBudget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveBudget.BackgroundImage")));
            this.btnRemoveBudget.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBudget.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveBudget.Location = new System.Drawing.Point(289, 311);
            this.btnRemoveBudget.Name = "btnRemoveBudget";
            this.btnRemoveBudget.Size = new System.Drawing.Size(215, 42);
            this.btnRemoveBudget.TabIndex = 10;
            this.btnRemoveBudget.Text = "Remove An Entry";
            this.btnRemoveBudget.UseVisualStyleBackColor = false;
            this.btnRemoveBudget.Click += new System.EventHandler(this.btnRemoveBudget_Click);
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBudget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBudget.BackgroundImage")));
            this.btnAddBudget.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBudget.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAddBudget.Location = new System.Drawing.Point(289, 100);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(215, 42);
            this.btnAddBudget.TabIndex = 9;
            this.btnAddBudget.Text = "Add An Entry";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(168, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select What Is Required";
            // 
            // AdvertsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveBudget);
            this.Controls.Add(this.btnAddBudget);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdvertsHome";
            this.Text = "Advertisements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveBudget;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.Label label1;
    }
}