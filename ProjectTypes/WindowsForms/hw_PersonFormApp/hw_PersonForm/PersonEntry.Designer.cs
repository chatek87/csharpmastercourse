namespace hw_PersonForm
{
    partial class PersonEntry
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.isActiveLabel = new System.Windows.Forms.Label();
            this.addressesList = new System.Windows.Forms.ListBox();
            this.addressesListLabel = new System.Windows.Forms.Label();
            this.addNewAddress = new System.Windows.Forms.Button();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(68, 74);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(96, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "first name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(170, 69);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(311, 30);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(68, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "last name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(170, 123);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(311, 30);
            this.lastNameText.TabIndex = 2;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(137, 194);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(18, 17);
            this.isActive.TabIndex = 3;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            this.isActiveLabel.AutoSize = true;
            this.isActiveLabel.Location = new System.Drawing.Point(68, 189);
            this.isActiveLabel.Name = "isActiveLabel";
            this.isActiveLabel.Size = new System.Drawing.Size(63, 25);
            this.isActiveLabel.TabIndex = 0;
            this.isActiveLabel.Text = "active";
            // 
            // addressesList
            // 
            this.addressesList.FormattingEnabled = true;
            this.addressesList.ItemHeight = 25;
            this.addressesList.Location = new System.Drawing.Point(73, 265);
            this.addressesList.Name = "addressesList";
            this.addressesList.Size = new System.Drawing.Size(408, 229);
            this.addressesList.TabIndex = 3;
            this.addressesList.TabStop = false;
            // 
            // addressesListLabel
            // 
            this.addressesListLabel.AutoSize = true;
            this.addressesListLabel.Location = new System.Drawing.Point(68, 237);
            this.addressesListLabel.Name = "addressesListLabel";
            this.addressesListLabel.Size = new System.Drawing.Size(103, 25);
            this.addressesListLabel.TabIndex = 0;
            this.addressesListLabel.Text = "addresses";
            // 
            // addNewAddress
            // 
            this.addNewAddress.Location = new System.Drawing.Point(406, 212);
            this.addNewAddress.Name = "addNewAddress";
            this.addNewAddress.Size = new System.Drawing.Size(75, 47);
            this.addNewAddress.TabIndex = 4;
            this.addNewAddress.Text = "add";
            this.addNewAddress.UseVisualStyleBackColor = true;
            this.addNewAddress.Click += new System.EventHandler(this.addNewAddress_Click);
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(216, 528);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(129, 63);
            this.saveRecord.TabIndex = 5;
            this.saveRecord.Text = "save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // PersonEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 658);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addNewAddress);
            this.Controls.Add(this.addressesList);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.isActiveLabel);
            this.Controls.Add(this.addressesListLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonEntry";
            this.Text = "Person Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.ListBox addressesList;
        private System.Windows.Forms.Label addressesListLabel;
        private System.Windows.Forms.Button addNewAddress;
        private System.Windows.Forms.Button saveRecord;
    }
}

