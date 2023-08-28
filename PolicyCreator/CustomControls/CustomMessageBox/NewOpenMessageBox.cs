using InsuranceSummaryMaker.Serialization;
using System;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    public partial class NewOpenMessageBox : Form
    {

        public string openpath { get; set; }
        public string fileName { get; set; }
        public NewOpenMessageBox()
        {
            InitializeComponent();
            setFilters();
            this.openpath = "";
            this.fileName = "";

        }
        public void setFilters()
        {
            string filter = "JJ Insurance Policy Creator (*" + PolicyInformationSerializer.fileExtension + ")|*" + PolicyInformationSerializer.fileExtension;
            this.openFileDialog1.Filter = filter;

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.openpath = this.openFileDialog1.FileName;
                this.fileName = this.openFileDialog1.SafeFileName;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
