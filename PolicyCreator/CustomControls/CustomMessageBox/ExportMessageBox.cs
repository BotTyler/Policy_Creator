using System;
using System.IO;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    public partial class ExportMessageBox : Form
    {

        public string templatePath { get; set; }
        public string documentpath { get; set; }
        public ExportMessageBox()
        {
            InitializeComponent();

            this.templatePath = "";
            this.documentpath = "";
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            if (this.templatePath == null || this.templatePath.Equals(""))
            {
                MessageBox.Show("Please Select a File Template.");
                return;
            }

            if(this.documentpath == null || this.documentpath.Equals(""))
            {
                MessageBox.Show("Please select a save location.");
                return;
            }

            if (string.Equals(templatePath, documentpath, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The Template and the save location cannot be the same.");
                return;
            }

            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Cannot open the template path please choose another.");
            }


            this.DialogResult = DialogResult.OK;


        }


        private void BroseFileTemplateButton_Click(object sender, EventArgs e)
        {
            if (this.BrowseTemplateDialog.ShowDialog() == DialogResult.OK)
            {
                this.templatePath = this.BrowseTemplateDialog.FileName;
                this.textTextBox.Text = this.templatePath;
            }
        }

        private void BrowseSaveLocation_Click(object sender, EventArgs e)
        {
            if (this.SaveWordDocumentDIalog.ShowDialog() == DialogResult.OK)
            {
                this.documentpath = this.SaveWordDocumentDIalog.FileName;
                this.saveProposalToTextBox.Text = this.documentpath;
            }
        }
    }
}
