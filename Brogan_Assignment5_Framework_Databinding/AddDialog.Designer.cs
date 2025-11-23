namespace Brogan_Assignment5_Framework_Databinding
{
    partial class AddDialog
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
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.newPhoneLabel = new System.Windows.Forms.Label();
            this.newPhoneTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(12, 103);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(185, 26);
            this.newNameTextBox.TabIndex = 0;
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Location = new System.Drawing.Point(80, 80);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(51, 20);
            this.newNameLabel.TabIndex = 1;
            this.newNameLabel.Text = "&Name";
            // 
            // newPhoneLabel
            // 
            this.newPhoneLabel.AutoSize = true;
            this.newPhoneLabel.Location = new System.Drawing.Point(306, 80);
            this.newPhoneLabel.Name = "newPhoneLabel";
            this.newPhoneLabel.Size = new System.Drawing.Size(55, 20);
            this.newPhoneLabel.TabIndex = 2;
            this.newPhoneLabel.Text = "&Phone";
            // 
            // newPhoneTextBox
            // 
            this.newPhoneTextBox.Location = new System.Drawing.Point(245, 103);
            this.newPhoneTextBox.Name = "newPhoneTextBox";
            this.newPhoneTextBox.Size = new System.Drawing.Size(185, 26);
            this.newPhoneTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(286, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 50);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(53, 169);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 247);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newPhoneTextBox);
            this.Controls.Add(this.newPhoneLabel);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.newNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDialog";
            this.Text = "Add New Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Label newPhoneLabel;
        private System.Windows.Forms.TextBox newPhoneTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}