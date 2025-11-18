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
        public AddDialog()
        {
            InitializeComponent();
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            NewName = newNameTextBox.Text;
            NewPhone = newPhoneTextBox.Text;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
