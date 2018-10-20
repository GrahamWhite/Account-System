namespace AccountSystem
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.accountStateBox = new System.Windows.Forms.ComboBox();
            this.accountStateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountCreationTrueLabel = new System.Windows.Forms.Label();
            this.encryptBox = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 347);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(845, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit Button";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 375);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(66, 398);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Padding = new System.Windows.Forms.Padding(2);
            this.refreshButton.Size = new System.Drawing.Size(136, 40);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(399, 87);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(121, 22);
            this.firstNameBox.TabIndex = 8;
            this.firstNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(6, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(84, 14);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.Location = new System.Drawing.Point(6, 66);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(91, 14);
            this.middleNameLabel.TabIndex = 11;
            this.middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(399, 115);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(121, 22);
            this.middleNameBox.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(6, 97);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 14);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(399, 143);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(121, 22);
            this.lastNameBox.TabIndex = 12;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(6, 143);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(77, 14);
            this.accountNumberLabel.TabIndex = 15;
            this.accountNumberLabel.Text = "Account #:";
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(399, 189);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(121, 22);
            this.accountNumberBox.TabIndex = 14;
            this.accountNumberBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(6, 168);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(63, 14);
            this.balanceLabel.TabIndex = 17;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(399, 217);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(121, 22);
            this.balanceBox.TabIndex = 16;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(268, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 14);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "date";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // accountStateBox
            // 
            this.accountStateBox.FormattingEnabled = true;
            this.accountStateBox.Items.AddRange(new object[] {
            "New,",
            "Active,",
            "Closed,",
            "Under Audit,",
            "Overdraft"});
            this.accountStateBox.Location = new System.Drawing.Point(399, 264);
            this.accountStateBox.Name = "accountStateBox";
            this.accountStateBox.Size = new System.Drawing.Size(121, 24);
            this.accountStateBox.TabIndex = 19;
            // 
            // accountStateLabel
            // 
            this.accountStateLabel.AutoSize = true;
            this.accountStateLabel.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStateLabel.Location = new System.Drawing.Point(6, 220);
            this.accountStateLabel.Name = "accountStateLabel";
            this.accountStateLabel.Size = new System.Drawing.Size(105, 14);
            this.accountStateLabel.TabIndex = 20;
            this.accountStateLabel.Text = "Account State:";
            this.accountStateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountStateLabel);
            this.groupBox1.Controls.Add(this.encryptBox);
            this.groupBox1.Controls.Add(this.balanceLabel);
            this.groupBox1.Controls.Add(this.accountNumberLabel);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Controls.Add(this.middleNameLabel);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(271, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 286);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Account Details";
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = global::AccountSystem.Properties.Resources.cashImgSmall;
            this.logoBox.Location = new System.Drawing.Point(817, 6);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(94, 95);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 22;
            this.logoBox.TabStop = false;
            // 
            // detailsBox
            // 
            this.detailsBox.Location = new System.Drawing.Point(592, 115);
            this.detailsBox.Multiline = true;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(319, 220);
            this.detailsBox.TabIndex = 23;
            this.detailsBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account Details";
            // 
            // accountCreationTrueLabel
            // 
            this.accountCreationTrueLabel.AutoSize = true;
            this.accountCreationTrueLabel.Location = new System.Drawing.Point(344, 410);
            this.accountCreationTrueLabel.Name = "accountCreationTrueLabel";
            this.accountCreationTrueLabel.Size = new System.Drawing.Size(0, 17);
            this.accountCreationTrueLabel.TabIndex = 25;
            // 
            // encryptBox
            // 
            this.encryptBox.AutoSize = true;
            this.encryptBox.Location = new System.Drawing.Point(128, 259);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(78, 18);
            this.encryptBox.TabIndex = 26;
            this.encryptBox.Text = "Encrypt";
            this.encryptBox.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("NSimSun", 7.8F);
            this.updateButton.Location = new System.Drawing.Point(660, 347);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(206, 45);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Decrypt";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.accountCreationTrueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.accountStateBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.accountNumberBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox accountStateBox;
        private System.Windows.Forms.Label accountStateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountCreationTrueLabel;
        private System.Windows.Forms.CheckBox encryptBox;
        private System.Windows.Forms.Button updateButton;
    }
}

