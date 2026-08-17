namespace NibmFinalProjectExpenseTracker
{
    partial class ExpenseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseAdd));
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.txtexpty = new System.Windows.Forms.TextBox();
            this.txtRecnum = new System.Windows.Forms.TextBox();
            this.txtexpamt = new System.Windows.Forms.TextBox();
            this.btnFormal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExpenseenter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapprv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxExpenseComittee = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpName
            // 
            this.txtExpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtExpName.Location = new System.Drawing.Point(369, 228);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(238, 30);
            this.txtExpName.TabIndex = 0;
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "Junior Steward",
            "Senior Steward",
            "Senior Prefect",
            "Board Member"});
            this.comboBoxRank.Location = new System.Drawing.Point(369, 95);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(238, 33);
            this.comboBoxRank.TabIndex = 1;
            // 
            // txtexpty
            // 
            this.txtexpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtexpty.Location = new System.Drawing.Point(369, 300);
            this.txtexpty.Name = "txtexpty";
            this.txtexpty.Size = new System.Drawing.Size(238, 30);
            this.txtexpty.TabIndex = 2;
            // 
            // txtRecnum
            // 
            this.txtRecnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRecnum.Location = new System.Drawing.Point(369, 375);
            this.txtRecnum.Name = "txtRecnum";
            this.txtRecnum.Size = new System.Drawing.Size(238, 30);
            this.txtRecnum.TabIndex = 3;
            // 
            // txtexpamt
            // 
            this.txtexpamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtexpamt.Location = new System.Drawing.Point(369, 450);
            this.txtexpamt.Name = "txtexpamt";
            this.txtexpamt.Size = new System.Drawing.Size(238, 30);
            this.txtexpamt.TabIndex = 4;
            // 
            // btnFormal
            // 
            this.btnFormal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormal.BackgroundImage")));
            this.btnFormal.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormal.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnFormal.Location = new System.Drawing.Point(547, 622);
            this.btnFormal.Name = "btnFormal";
            this.btnFormal.Size = new System.Drawing.Size(161, 42);
            this.btnFormal.TabIndex = 7;
            this.btnFormal.Text = "Exit";
            this.btnFormal.UseVisualStyleBackColor = false;
            this.btnFormal.Click += new System.EventHandler(this.btnFormal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(314, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExpenseenter
            // 
            this.btnExpenseenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpenseenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpenseenter.BackgroundImage")));
            this.btnExpenseenter.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseenter.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnExpenseenter.Location = new System.Drawing.Point(90, 622);
            this.btnExpenseenter.Name = "btnExpenseenter";
            this.btnExpenseenter.Size = new System.Drawing.Size(161, 42);
            this.btnExpenseenter.TabIndex = 9;
            this.btnExpenseenter.Text = "Enter Entry";
            this.btnExpenseenter.UseVisualStyleBackColor = false;
            this.btnExpenseenter.Click += new System.EventHandler(this.btnExpenseenter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Your Rank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fill in the following";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(32, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount Withdrawn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(32, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nature Of expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(32, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reciept Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(32, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "approved by";
            // 
            // txtapprv
            // 
            this.txtapprv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtapprv.Location = new System.Drawing.Point(369, 520);
            this.txtapprv.Name = "txtapprv";
            this.txtapprv.Size = new System.Drawing.Size(238, 30);
            this.txtapprv.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(32, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select Your Committee";
            // 
            // comboBoxExpenseComittee
            // 
            this.comboBoxExpenseComittee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpenseComittee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxExpenseComittee.FormattingEnabled = true;
            this.comboBoxExpenseComittee.Items.AddRange(new object[] {
            "Formal",
            "Informal",
            "Media",
            "Editorial"});
            this.comboBoxExpenseComittee.Location = new System.Drawing.Point(369, 156);
            this.comboBoxExpenseComittee.Name = "comboBoxExpenseComittee";
            this.comboBoxExpenseComittee.Size = new System.Drawing.Size(238, 33);
            this.comboBoxExpenseComittee.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(613, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 76;
            this.label11.Text = "(Numerals Only)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(613, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "(Numerals Only)";
            // 
            // ExpenseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 742);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxExpenseComittee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapprv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpenseenter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFormal);
            this.Controls.Add(this.txtexpamt);
            this.Controls.Add(this.txtRecnum);
            this.Controls.Add(this.txtexpty);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.txtExpName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExpenseAdd";
            this.Text = "Add An Expense Entry";
            this.Load += new System.EventHandler(this.ExpenseAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.TextBox txtexpty;
        private System.Windows.Forms.TextBox txtRecnum;
        private System.Windows.Forms.TextBox txtexpamt;
        private System.Windows.Forms.Button btnFormal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExpenseenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapprv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxExpenseComittee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}