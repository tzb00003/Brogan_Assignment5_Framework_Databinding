using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brogan_Assignment5_Framework_Databinding
{
    public partial class AddDialog : Form
    {
        public string NewName = "";
        public string NewPhone = "";
        private BindingSource _bindingSource;
        public AddDialog(BindingSource binding)
        {
            _bindingSource = binding;
            newNameTextBox.DataBindings.Add("Text", _bindingSource, "Name");
            newPhoneTextBox.DataBindings.Add("Text", _bindingSource, "Phone");
            InitializeComponent();
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
            _bindingSource.AddNew();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            NewName = newNameTextBox.Text;
            NewPhone = newPhoneTextBox.Text;
            _bindingSource.EndEdit();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
