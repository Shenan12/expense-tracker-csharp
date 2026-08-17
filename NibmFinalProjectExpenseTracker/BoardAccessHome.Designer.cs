namespace NibmFinalProjectExpenseTracker
{
    partial class BoardAccessHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardAccessHome));
            this.btnTotExp = new System.Windows.Forms.Button();
            this.btnCashAtHand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCashInHand = new System.Windows.Forms.Button();
            this.txtBoxCashInHand = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTotExp
            // 
            this.btnTotExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotExp.BackgroundImage")));
            this.btnTotExp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotExp.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnTotExp.Location = new System.Drawing.Point(519, 223);
            this.btnTotExp.Name = "btnTotExp";
            this.btnTotExp.Size = new System.Drawing.Size(247, 74);
            this.btnTotExp.TabIndex = 7;
            this.btnTotExp.Text = "Click Here";
            this.btnTotExp.UseVisualStyleBackColor = true;
            this.btnTotExp.Click += new System.EventHandler(this.btnTotExp_Click);
            // 
            // btnCashAtHand
            // 
            this.btnCashAtHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCashAtHand.BackgroundImage")));
            this.btnCashAtHand.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashAtHand.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCashAtHand.Location = new System.Drawing.Point(102, 223);
            this.btnCashAtHand.Name = "btnCashAtHand";
            this.btnCashAtHand.Size = new System.Drawing.Size(247, 74);
            this.btnCashAtHand.TabIndex = 6;
            this.btnCashAtHand.Text = "Click Here";
            this.btnCashAtHand.UseVisualStyleBackColor = true;
            this.btnCashAtHand.Click += new System.EventHandler(this.btnCashAtHand_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(84, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 54);
            this.label4.TabIndex = 51;
            this.label4.Text = "See Cash In Hand, Budget Status \r\nand to delete duplicate entries\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(515, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 54);
            this.label1.TabIndex = 52;
            this.label1.Text = "See Expenses,\r\n and delete duplicate entries";
            // 
            // btnCashInHand
            // 
            this.btnCashInHand.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCashInHand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCashInHand.BackgroundImage")));
            this.btnCashInHand.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashInHand.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCashInHand.Location = new System.Drawing.Point(304, 447);
            this.btnCashInHand.Name = "btnCashInHand";
            this.btnCashInHand.Size = new System.Drawing.Size(280, 42);
            this.btnCashInHand.TabIndex = 53;
            this.btnCashInHand.Text = "See Total Cash In Hand";
            this.btnCashInHand.UseVisualStyleBackColor = false;
            this.btnCashInHand.Click += new System.EventHandler(this.btnCashInHand_Click);
            // 
            // txtBoxCashInHand
            // 
            this.txtBoxCashInHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBoxCashInHand.Location = new System.Drawing.Point(304, 377);
            this.txtBoxCashInHand.Name = "txtBoxCashInHand";
            this.txtBoxCashInHand.Size = new System.Drawing.Size(280, 41);
            this.txtBoxCashInHand.TabIndex = 54;
            // 
            // BoardAccessHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 528);
            this.Controls.Add(this.txtBoxCashInHand);
            this.Controls.Add(this.btnCashInHand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTotExp);
            this.Controls.Add(this.btnCashAtHand);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BoardAccessHome";
            this.Text = "Board Access";
            this.Load += new System.EventHandler(this.BoardAccessHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotExp;
        private System.Windows.Forms.Button btnCashAtHand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCashInHand;
        private System.Windows.Forms.TextBox txtBoxCashInHand;
    }
}