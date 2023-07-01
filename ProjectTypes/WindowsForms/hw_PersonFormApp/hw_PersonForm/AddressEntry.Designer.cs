namespace hw_PersonForm
{
    partial class AddressEntry
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
            this.cityText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.addressEntryLabel = new System.Windows.Forms.Label();
            this.saveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(174, 148);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(311, 30);
            this.cityText.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(127, 153);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(41, 25);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "city";
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(174, 94);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(311, 30);
            this.streetAddressText.TabIndex = 5;
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(33, 99);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(135, 25);
            this.streetAddressLabel.TabIndex = 4;
            this.streetAddressLabel.Text = "street address";
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(174, 266);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(311, 30);
            this.zipCodeText.TabIndex = 10;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(83, 271);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(85, 25);
            this.zipCodeLabel.TabIndex = 7;
            this.zipCodeLabel.Text = "zip code";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(174, 212);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(311, 30);
            this.stateText.TabIndex = 9;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(114, 217);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(54, 25);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "state";
            // 
            // addressEntryLabel
            // 
            this.addressEntryLabel.AutoSize = true;
            this.addressEntryLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressEntryLabel.Location = new System.Drawing.Point(167, 21);
            this.addressEntryLabel.Name = "addressEntryLabel";
            this.addressEntryLabel.Size = new System.Drawing.Size(279, 42);
            this.addressEntryLabel.TabIndex = 11;
            this.addressEntryLabel.Text = "ADDRESS ENTRY";
            // 
            // saveRecord
            // 
            this.saveRecord.Location = new System.Drawing.Point(252, 312);
            this.saveRecord.Name = "saveRecord";
            this.saveRecord.Size = new System.Drawing.Size(129, 63);
            this.saveRecord.TabIndex = 12;
            this.saveRecord.Text = "save";
            this.saveRecord.UseVisualStyleBackColor = true;
            this.saveRecord.Click += new System.EventHandler(this.saveRecord_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 387);
            this.Controls.Add(this.saveRecord);
            this.Controls.Add(this.addressEntryLabel);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.streetAddressLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetAddressText;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.TextBox zipCodeText;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label addressEntryLabel;
        private System.Windows.Forms.Button saveRecord;
    }
}