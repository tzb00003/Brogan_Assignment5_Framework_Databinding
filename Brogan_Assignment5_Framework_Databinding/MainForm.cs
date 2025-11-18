using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brogan_Assignment5_Framework_Databinding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.projectDatabaseDataSet.Person);
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.projectDatabaseDataSet.Person);

        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDatabaseDataSet);

        }
    }
}
