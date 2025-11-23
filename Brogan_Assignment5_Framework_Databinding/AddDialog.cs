
using System;
using System.Windows.Forms;

namespace Brogan_Assignment5_Framework_Databinding
{
    public partial class AddDialog : Form
    {
        public string NewName { get; private set; }
        public string NewPhone { get; private set; }

        public AddDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newNameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewName = newNameTextBox.Text.Trim();
            NewPhone = newPhoneTextBox.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
