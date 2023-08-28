using System;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    public partial class RenameMessageBox : Form
    {

        public string renameValue { get; set; }
        public RenameMessageBox(string message, string renameText)
        {
            InitializeComponent();
            this.renameValue = "";
            this.messageLabel.Text = message;
            this.textTextBox.Text = renameText;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.renameValue = this.textTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.renameValue = this.textTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
