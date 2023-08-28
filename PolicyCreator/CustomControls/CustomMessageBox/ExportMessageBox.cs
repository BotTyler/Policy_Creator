using System;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    public partial class ExportMessageBox : Form
    {

        private string tempPath { get; set; }
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

            if (this.tempPath == null)
            {
                MessageBox.Show("Please Select a File Template");
            }
            else
            {
                if (this.SaveWordDocumentDIalog.ShowDialog() == DialogResult.OK)
                {
                    this.templatePath = this.tempPath;
                    this.documentpath = this.SaveWordDocumentDIalog.FileName;
                    this.DialogResult = DialogResult.OK;
                }


            }
        }


        private void BroseFileTemplateButton_Click(object sender, EventArgs e)
        {
            if (this.BrowseTemplateDialog.ShowDialog() == DialogResult.OK)
            {
                this.tempPath = this.BrowseTemplateDialog.FileName;
                this.textTextBox.Text = this.BrowseTemplateDialog.SafeFileName;
            }
        }
    }
}
