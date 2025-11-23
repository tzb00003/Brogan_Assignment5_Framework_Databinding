
using System;
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
            this.personTableAdapter.Fill(this.projectDBDataSet.Person);
        }

        private void addButton_Click(object sender, EventArgs e)//Improved code with AI
        {
            using (AddDialog addDialog = new AddDialog())
            {
                if (addDialog.ShowDialog() == DialogResult.OK)
                {
                    var newRow = projectDBDataSet.Person.NewPersonRow();
                    newRow.Name = addDialog.NewName;
                    newRow.Phone = addDialog.NewPhone;
                    projectDBDataSet.Person.Rows.Add(newRow);

                    try
                    {
                        personTableAdapter.Update(projectDBDataSet.Person);
                        projectDBDataSet.Person.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                personBindingSource.EndEdit();
                int rowsAffected = personTableAdapter.Update(projectDBDataSet.Person);
                projectDBDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                    personBindingSource.RemoveCurrent();
                    this.personBindingSource.EndEdit();
                    this.personTableAdapter.Update(this.projectDBDataSet.Person);
                    projectDBDataSet.Person.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
