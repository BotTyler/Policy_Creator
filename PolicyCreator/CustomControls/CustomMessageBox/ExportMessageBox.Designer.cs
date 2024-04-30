using System.Drawing;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls.CustomMessageBox
{
    partial class ExportMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportMessageBox));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BrowseSaveLocation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveProposalToTextBox = new System.Windows.Forms.TextBox();
            this.BroseFileTemplateButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BrowseTemplateDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveWordDocumentDIalog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(8, 6);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BrowseSaveLocation);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.saveProposalToTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.BroseFileTemplateButton);
            this.splitContainer1.Panel1.Controls.Add(this.messageLabel);
            this.splitContainer1.Panel1.Controls.Add(this.textTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(458, 211);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // BrowseSaveLocation
            // 
            this.BrowseSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseSaveLocation.AutoSize = true;
            this.BrowseSaveLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseSaveLocation.BackgroundImage")));
            this.BrowseSaveLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrowseSaveLocation.Location = new System.Drawing.Point(420, 105);
            this.BrowseSaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseSaveLocation.Name = "BrowseSaveLocation";
            this.BrowseSaveLocation.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseSaveLocation.Size = new System.Drawing.Size(34, 34);
            this.BrowseSaveLocation.TabIndex = 5;
            this.BrowseSaveLocation.UseVisualStyleBackColor = true;
            this.BrowseSaveLocation.Click += new System.EventHandler(this.BrowseSaveLocation_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Proposal To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveProposalToTextBox
            // 
            this.saveProposalToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProposalToTextBox.Location = new System.Drawing.Point(8, 110);
            this.saveProposalToTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.saveProposalToTextBox.Name = "saveProposalToTextBox";
            this.saveProposalToTextBox.ReadOnly = true;
            this.saveProposalToTextBox.Size = new System.Drawing.Size(407, 26);
            this.saveProposalToTextBox.TabIndex = 3;
            // 
            // BroseFileTemplateButton
            // 
            this.BroseFileTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BroseFileTemplateButton.AutoSize = true;
            this.BroseFileTemplateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BroseFileTemplateButton.BackgroundImage")));
            this.BroseFileTemplateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BroseFileTemplateButton.Location = new System.Drawing.Point(420, 23);
            this.BroseFileTemplateButton.Margin = new System.Windows.Forms.Padding(2);
            this.BroseFileTemplateButton.Name = "BroseFileTemplateButton";
            this.BroseFileTemplateButton.Padding = new System.Windows.Forms.Padding(5);
            this.BroseFileTemplateButton.Size = new System.Drawing.Size(34, 34);
            this.BroseFileTemplateButton.TabIndex = 2;
            this.BroseFileTemplateButton.UseVisualStyleBackColor = true;
            this.BroseFileTemplateButton.Click += new System.EventHandler(this.BroseFileTemplateButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Location = new System.Drawing.Point(4, 0);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(450, 24);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Choose Template:";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTextBox
            // 
            this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextBox.Location = new System.Drawing.Point(7, 28);
            this.textTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ReadOnly = true;
            this.textTextBox.Size = new System.Drawing.Size(409, 26);
            this.textTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ExportButton);
            this.flowLayoutPanel1.Controls.Add(this.CancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSize = true;
            this.ExportButton.Location = new System.Drawing.Point(8, 4);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(8, 4, 90, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Padding = new System.Windows.Forms.Padding(5);
            this.ExportButton.Size = new System.Drawing.Size(184, 40);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Make Word Document";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Location = new System.Drawing.Point(286, 4);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.CancelButton.Size = new System.Drawing.Size(130, 40);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BrowseTemplateDialog
            // 
            this.BrowseTemplateDialog.Filter = "Word Documents|*.doc;*.docx";
            // 
            // SaveWordDocumentDIalog
            // 
            this.SaveWordDocumentDIalog.Filter = "Word Documents|*.docx";
            // 
            // ExportMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 223);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(490, 262);
            this.MinimumSize = new System.Drawing.Size(490, 262);
            this.Name = "ExportMessageBox";
            this.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Text = "Export";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private Button ExportButton;
        private Button CancelButton;
        private Label messageLabel;
        private TextBox textTextBox;
        private Button BroseFileTemplateButton;
        private OpenFileDialog BrowseTemplateDialog;
        private SaveFileDialog SaveWordDocumentDIalog;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BrowseSaveLocation;
        private Label label2;
        private TextBox saveProposalToTextBox;
    }
}