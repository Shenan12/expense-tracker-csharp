namespace NibmFinalProjectExpenseTracker
{
    partial class BoardTotExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardTotExpenses));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllExp = new System.Windows.Forms.Button();
            this.txtPrimaryKey = new System.Windows.Forms.TextBox();
            this.btnDupli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBatchBudget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExpDelRank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpDelName = new System.Windows.Forms.TextBox();
            this.btnSecificMemberBudget = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxanswerDisplay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxExpDelComit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(178, 736);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "ExpID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(178, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 69);
            this.label4.TabIndex = 67;
            this.label4.Text = "Use The \"See Member Withdrawals\" \r\nButton to access the ExpID\r\nof the Duplicate E" +
    "ntry\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(35, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Your Result (Rs)";
            // 
            // btnAllExp
            // 
            this.btnAllExp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllExp.BackgroundImage")));
            this.btnAllExp.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllExp.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAllExp.Location = new System.Drawing.Point(945, 48);
            this.btnAllExp.Name = "btnAllExp";
            this.btnAllExp.Size = new System.Drawing.Size(280, 42);
            this.btnAllExp.TabIndex = 65;
            this.btnAllExp.Text = "See All Expense Entries";
            this.btnAllExp.UseVisualStyleBackColor = false;
            this.btnAllExp.Click += new System.EventHandler(this.btnAllExp_Click);
            // 
            // txtPrimaryKey
            // 
            this.txtPrimaryKey.Location = new System.Drawing.Point(316, 740);
            this.txtPrimaryKey.Name = "txtPrimaryKey";
            this.txtPrimaryKey.Size = new System.Drawing.Size(100, 22);
            this.txtPrimaryKey.TabIndex = 64;
            // 
            // btnDupli
            // 
            this.btnDupli.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDupli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDupli.BackgroundImage")));
            this.btnDupli.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDupli.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDupli.Location = new System.Drawing.Point(184, 776);
            this.btnDupli.Name = "btnDupli";
            this.btnDupli.Size = new System.Drawing.Size(280, 42);
            this.btnDupli.TabIndex = 63;
            this.btnDupli.Text = "Delete a Duplicate Entry";
            this.btnDupli.UseVisualStyleBackColor = false;
            this.btnDupli.Click += new System.EventHandler(this.btnDupli_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(669, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 707);
            this.dataGridView1.TabIndex = 62;
            // 
            // btnBatchBudget
            // 
            this.btnBatchBudget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBatchBudget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBatchBudget.BackgroundImage")));
            this.btnBatchBudget.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchBudget.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnBatchBudget.Location = new System.Drawing.Point(184, 574);
            this.btnBatchBudget.Name = "btnBatchBudget";
            this.btnBatchBudget.Size = new System.Drawing.Size(280, 42);
            this.btnBatchBudget.TabIndex = 61;
            this.btnBatchBudget.Text = "See Committee Expenses";
            this.btnBatchBudget.UseVisualStyleBackColor = false;
            this.btnBatchBudget.Click += new System.EventHandler(this.btnBatchBudget_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(35, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Select Your Rank";
            // 
            // comboBoxExpDelRank
            // 
            this.comboBoxExpDelRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpDelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxExpDelRank.FormattingEnabled = true;
            this.comboBoxExpDelRank.Items.AddRange(new object[] {
            "Junior Steward",
            "Senior Steward",
            "Senior Prefect",
            "Board Member"});
            this.comboBoxExpDelRank.Location = new System.Drawing.Point(372, 16);
            this.comboBoxExpDelRank.Name = "comboBoxExpDelRank";
            this.comboBoxExpDelRank.Size = new System.Drawing.Size(238, 33);
            this.comboBoxExpDelRank.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Name";
            // 
            // txtExpDelName
            // 
            this.txtExpDelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtExpDelName.Location = new System.Drawing.Point(372, 76);
            this.txtExpDelName.Name = "txtExpDelName";
            this.txtExpDelName.Size = new System.Drawing.Size(238, 30);
            this.txtExpDelName.TabIndex = 57;
            // 
            // btnSecificMemberBudget
            // 
            this.btnSecificMemberBudget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSecificMemberBudget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecificMemberBudget.BackgroundImage")));
            this.btnSecificMemberBudget.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecificMemberBudget.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSecificMemberBudget.Location = new System.Drawing.Point(184, 468);
            this.btnSecificMemberBudget.Name = "btnSecificMemberBudget";
            this.btnSecificMemberBudget.Size = new System.Drawing.Size(280, 42);
            this.btnSecificMemberBudget.TabIndex = 56;
            this.btnSecificMemberBudget.Text = "See Members Withdrawals";
            this.btnSecificMemberBudget.UseVisualStyleBackColor = false;
            this.btnSecificMemberBudget.Click += new System.EventHandler(this.btnSecificMemberBudget_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LimeGreen;
            this.button2.Location = new System.Drawing.Point(184, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 42);
            this.button2.TabIndex = 55;
            this.button2.Text = "See Total Expenses";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxanswerDisplay
            // 
            this.textBoxanswerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxanswerDisplay.Location = new System.Drawing.Point(372, 195);
            this.textBoxanswerDisplay.Name = "textBoxanswerDisplay";
            this.textBoxanswerDisplay.ReadOnly = true;
            this.textBoxanswerDisplay.Size = new System.Drawing.Size(238, 30);
            this.textBoxanswerDisplay.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(35, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Select Your Committee";
            // 
            // comboBoxExpDelComit
            // 
            this.comboBoxExpDelComit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpDelComit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxExpDelComit.FormattingEnabled = true;
            this.comboBoxExpDelComit.Items.AddRange(new object[] {
            "Formal",
            "Informal",
            "Media",
            "Editorial"});
            this.comboBoxExpDelComit.Location = new System.Drawing.Point(372, 136);
            this.comboBoxExpDelComit.Name = "comboBoxExpDelComit";
            this.comboBoxExpDelComit.Size = new System.Drawing.Size(238, 33);
            this.comboBoxExpDelComit.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(180, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 23);
            this.label6.TabIndex = 71;
            this.label6.Text = "Enter Member Name And Rank to;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(180, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Click here to;";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(180, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 23);
            this.label9.TabIndex = 73;
            this.label9.Text = "Enter a Committee to;";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(941, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 74;
            this.label10.Text = "Click here to;";
            // 
            // BoardTotExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1569, 964);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxExpDelComit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAllExp);
            this.Controls.Add(this.txtPrimaryKey);
            this.Controls.Add(this.btnDupli);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBatchBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxExpDelRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpDelName);
            this.Controls.Add(this.btnSecificMemberBudget);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxanswerDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BoardTotExpenses";
            this.Text = "Expenses Access Portal";
            this.Load += new System.EventHandler(this.BoardTotExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllExp;
        private System.Windows.Forms.TextBox txtPrimaryKey;
        private System.Windows.Forms.Button btnDupli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBatchBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExpDelRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpDelName;
        private System.Windows.Forms.Button btnSecificMemberBudget;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxanswerDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxExpDelComit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}