using System;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    public partial class AddCancelMessageBox : Form
    {

        public string text { get; set; }
        public AddCancelMessageBox(string message)
        {
            InitializeComponent();
            this.text = "";
            this.messageLabel.Text = message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.text = this.textTextBox.Text;
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
                this.text = this.textTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
