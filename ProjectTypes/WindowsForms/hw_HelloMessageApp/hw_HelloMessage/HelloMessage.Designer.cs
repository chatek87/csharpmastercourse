namespace hw_HelloMessage
{
    partial class HelloMessage
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
            this.clickMe = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.useTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.prefixes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clickMe.Location = new System.Drawing.Point(237, 179);
            this.clickMe.Margin = new System.Windows.Forms.Padding(5);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(164, 53);
            this.clickMe.TabIndex = 3;
            this.clickMe.Text = "click me";
            this.clickMe.UseVisualStyleBackColor = false;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(22, 53);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(117, 29);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "first name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(22, 103);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(116, 29);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "last name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(142, 48);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(293, 34);
            this.firstNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(142, 100);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(293, 34);
            this.lastNameBox.TabIndex = 2;
            // 
            // useTitleCheckBox
            // 
            this.useTitleCheckBox.AutoSize = true;
            this.useTitleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useTitleCheckBox.Location = new System.Drawing.Point(27, 169);
            this.useTitleCheckBox.Name = "useTitleCheckBox";
            this.useTitleCheckBox.Size = new System.Drawing.Size(90, 24);
            this.useTitleCheckBox.TabIndex = 4;
            this.useTitleCheckBox.Text = "use title";
            this.useTitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // prefixes
            // 
            this.prefixes.FormattingEnabled = true;
            this.prefixes.ItemHeight = 29;
            this.prefixes.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr.",
            "Sir",
            "Lady",
            "Duke",
            "Captain",
            "Commander",
            "Her Highness"});
            this.prefixes.Location = new System.Drawing.Point(27, 199);
            this.prefixes.Name = "prefixes";
            this.prefixes.Size = new System.Drawing.Size(173, 33);
            this.prefixes.TabIndex = 5;
            // 
            // HelloMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 256);
            this.Controls.Add(this.prefixes);
            this.Controls.Add(this.useTitleCheckBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.clickMe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HelloMessage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.CheckBox useTitleCheckBox;
        private System.Windows.Forms.ListBox prefixes;
    }
}

