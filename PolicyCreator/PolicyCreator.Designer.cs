using InsuranceSummaryMaker.Serialization;
using System.Drawing;
using System.Windows.Forms;

namespace InsuranceSummaryMaker
{
    partial class PolicyCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolicyCreator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BuisnessInformationTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AgentBusinessNameTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AgentWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AgentPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AgentEmailTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AgentPositionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AgentNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseImageLocation = new System.Windows.Forms.Button();
            this.businessPictureBox = new System.Windows.Forms.PictureBox();
            this.BusinessEndDate = new System.Windows.Forms.DateTimePicker();
            this.BusinessStartDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BusinessLegalNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BuisnessNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tables = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.TableCreateGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewTableButton = new System.Windows.Forms.Button();
            this.renameTableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.TableCreatePanelListBox = new InsuranceSummaryMaker.CustomControls.CustomPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.upTableCreateButton = new System.Windows.Forms.Button();
            this.downTableCreateButton = new System.Windows.Forms.Button();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ColumnsCreatePanelListView = new InsuranceSummaryMaker.CustomControls.CustomPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.renameColumnButton = new System.Windows.Forms.Button();
            this.DeleteColumnButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.upColumnsCreateButton = new System.Windows.Forms.Button();
            this.downColumnsCreateButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CarrierRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TableData = new System.Windows.Forms.TabPage();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.RowMoveUpButton = new System.Windows.Forms.Button();
            this.RowMoveDownButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.TableDataViewSelectorBox = new System.Windows.Forms.ComboBox();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.keyprovisions = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.KeyProvisionsDataViewUp = new System.Windows.Forms.Button();
            this.KeyProvisionsDataViewDown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyProvisionsDataViewSelectorBox = new System.Windows.Forms.ComboBox();
            this.KeyProvisionsDataView = new System.Windows.Forms.DataGridView();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appendiciesLabelBox = new InsuranceSummaryMaker.CustomControls.CustomPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.AppendiciesAddButton = new System.Windows.Forms.Button();
            this.AppendiciesDeleteButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.AppendiciesUpButton = new System.Windows.Forms.Button();
            this.AppendiciesDownButton = new System.Windows.Forms.Button();
            this.openWordDocumentFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openMyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateProposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMyFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.BuisnessInformationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessPictureBox)).BeginInit();
            this.Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.TableCreateGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.TableData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.keyprovisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyProvisionsDataView)).BeginInit();
            this.ExportTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BuisnessInformationTab);
            this.tabControl1.Controls.Add(this.Tables);
            this.tabControl1.Controls.Add(this.TableData);
            this.tabControl1.Controls.Add(this.keyprovisions);
            this.tabControl1.Controls.Add(this.ExportTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 433);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // BuisnessInformationTab
            // 
            this.BuisnessInformationTab.BackColor = System.Drawing.Color.Silver;
            this.BuisnessInformationTab.Controls.Add(this.splitContainer2);
            this.BuisnessInformationTab.Location = new System.Drawing.Point(4, 39);
            this.BuisnessInformationTab.Name = "BuisnessInformationTab";
            this.BuisnessInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.BuisnessInformationTab.Size = new System.Drawing.Size(926, 390);
            this.BuisnessInformationTab.TabIndex = 1;
            this.BuisnessInformationTab.Text = "Business Information";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.Controls.Add(this.AgentBusinessNameTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.AgentWebsiteTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.AgentPhoneNumberTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.AgentEmailTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.AgentPositionTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.AgentNameTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.Controls.Add(this.businessPictureBox);
            this.splitContainer2.Panel2.Controls.Add(this.BusinessEndDate);
            this.splitContainer2.Panel2.Controls.Add(this.BusinessStartDate);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.BusinessLegalNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.BuisnessNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Size = new System.Drawing.Size(920, 384);
            this.splitContainer2.SplitterDistance = 428;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            this.splitContainer2.TabStop = false;
            // 
            // AgentBusinessNameTextBox
            // 
            this.AgentBusinessNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentBusinessNameTextBox.Location = new System.Drawing.Point(105, 214);
            this.AgentBusinessNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentBusinessNameTextBox.Name = "AgentBusinessNameTextBox";
            this.AgentBusinessNameTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentBusinessNameTextBox.TabIndex = 12;
            this.AgentBusinessNameTextBox.Text = "JJ Insurance";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label16.Location = new System.Drawing.Point(3, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 22);
            this.label16.TabIndex = 11;
            this.label16.Text = "Business:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentWebsiteTextBox
            // 
            this.AgentWebsiteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentWebsiteTextBox.Location = new System.Drawing.Point(105, 179);
            this.AgentWebsiteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentWebsiteTextBox.Name = "AgentWebsiteTextBox";
            this.AgentWebsiteTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentWebsiteTextBox.TabIndex = 10;
            this.AgentWebsiteTextBox.Text = "www.jj-insurance.com";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label10.Location = new System.Drawing.Point(3, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Website:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentPhoneNumberTextBox
            // 
            this.AgentPhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentPhoneNumberTextBox.Location = new System.Drawing.Point(105, 142);
            this.AgentPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentPhoneNumberTextBox.Name = "AgentPhoneNumberTextBox";
            this.AgentPhoneNumberTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentPhoneNumberTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label9.Location = new System.Drawing.Point(3, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentEmailTextBox
            // 
            this.AgentEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentEmailTextBox.Location = new System.Drawing.Point(105, 106);
            this.AgentEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentEmailTextBox.Name = "AgentEmailTextBox";
            this.AgentEmailTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentEmailTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label8.Location = new System.Drawing.Point(3, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentPositionTextBox
            // 
            this.AgentPositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentPositionTextBox.Location = new System.Drawing.Point(105, 69);
            this.AgentPositionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentPositionTextBox.Name = "AgentPositionTextBox";
            this.AgentPositionTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentPositionTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label7.Location = new System.Drawing.Point(3, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Position:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentNameTextBox
            // 
            this.AgentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentNameTextBox.Location = new System.Drawing.Point(105, 35);
            this.AgentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentNameTextBox.Name = "AgentNameTextBox";
            this.AgentNameTextBox.Size = new System.Drawing.Size(308, 26);
            this.AgentNameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agent Information";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 199);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BrowseImageLocation);
            this.splitContainer1.Size = new System.Drawing.Size(480, 40);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrowseImageLocation
            // 
            this.BrowseImageLocation.AutoSize = true;
            this.BrowseImageLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseImageLocation.BackgroundImage")));
            this.BrowseImageLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrowseImageLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseImageLocation.Location = new System.Drawing.Point(0, 0);
            this.BrowseImageLocation.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseImageLocation.Name = "BrowseImageLocation";
            this.BrowseImageLocation.Padding = new System.Windows.Forms.Padding(5);
            this.BrowseImageLocation.Size = new System.Drawing.Size(45, 40);
            this.BrowseImageLocation.TabIndex = 13;
            this.BrowseImageLocation.UseVisualStyleBackColor = true;
            this.BrowseImageLocation.Click += new System.EventHandler(this.BrowseImageLocation_Click);
            // 
            // businessPictureBox
            // 
            this.businessPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.businessPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.businessPictureBox.Location = new System.Drawing.Point(3, 240);
            this.businessPictureBox.Name = "businessPictureBox";
            this.businessPictureBox.Size = new System.Drawing.Size(492, 142);
            this.businessPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.businessPictureBox.TabIndex = 14;
            this.businessPictureBox.TabStop = false;
            // 
            // BusinessEndDate
            // 
            this.BusinessEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusinessEndDate.CustomFormat = "M / d / yyyy";
            this.BusinessEndDate.Location = new System.Drawing.Point(130, 143);
            this.BusinessEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusinessEndDate.Name = "BusinessEndDate";
            this.BusinessEndDate.Size = new System.Drawing.Size(354, 26);
            this.BusinessEndDate.TabIndex = 11;
            // 
            // BusinessStartDate
            // 
            this.BusinessStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusinessStartDate.CustomFormat = "M/d/yyyy";
            this.BusinessStartDate.Location = new System.Drawing.Point(130, 106);
            this.BusinessStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusinessStartDate.Name = "BusinessStartDate";
            this.BusinessStartDate.Size = new System.Drawing.Size(354, 26);
            this.BusinessStartDate.TabIndex = 10;
            this.BusinessStartDate.ValueChanged += new System.EventHandler(this.BusinessStartDate_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label14.Location = new System.Drawing.Point(10, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 9;
            this.label14.Text = "End Date:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label13.Location = new System.Drawing.Point(10, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Start Date:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusinessLegalNameTextBox
            // 
            this.BusinessLegalNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusinessLegalNameTextBox.Location = new System.Drawing.Point(130, 69);
            this.BusinessLegalNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusinessLegalNameTextBox.Name = "BusinessLegalNameTextBox";
            this.BusinessLegalNameTextBox.Size = new System.Drawing.Size(354, 26);
            this.BusinessLegalNameTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label12.Location = new System.Drawing.Point(10, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Legal Name:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuisnessNameTextBox
            // 
            this.BuisnessNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuisnessNameTextBox.Location = new System.Drawing.Point(130, 35);
            this.BuisnessNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuisnessNameTextBox.Name = "BuisnessNameTextBox";
            this.BuisnessNameTextBox.Size = new System.Drawing.Size(354, 26);
            this.BuisnessNameTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label11.Location = new System.Drawing.Point(10, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(489, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Business Insured";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tables
            // 
            this.Tables.BackColor = System.Drawing.Color.Transparent;
            this.Tables.Controls.Add(this.splitContainer6);
            this.Tables.Location = new System.Drawing.Point(4, 39);
            this.Tables.Name = "Tables";
            this.Tables.Padding = new System.Windows.Forms.Padding(3);
            this.Tables.Size = new System.Drawing.Size(926, 390);
            this.Tables.TabIndex = 4;
            this.Tables.Text = "Tables";
            // 
            // splitContainer6
            // 
            this.splitContainer6.BackColor = System.Drawing.Color.Black;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer6.Panel1.Controls.Add(this.TableCreateGroupBox);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer6.Size = new System.Drawing.Size(920, 384);
            this.splitContainer6.SplitterDistance = 309;
            this.splitContainer6.SplitterWidth = 3;
            this.splitContainer6.TabIndex = 0;
            this.splitContainer6.TabStop = false;
            // 
            // TableCreateGroupBox
            // 
            this.TableCreateGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.TableCreateGroupBox.Controls.Add(this.TableCreatePanelListBox);
            this.TableCreateGroupBox.Controls.Add(this.flowLayoutPanel4);
            this.TableCreateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableCreateGroupBox.Location = new System.Drawing.Point(0, 0);
            this.TableCreateGroupBox.Name = "TableCreateGroupBox";
            this.TableCreateGroupBox.Size = new System.Drawing.Size(309, 384);
            this.TableCreateGroupBox.TabIndex = 0;
            this.TableCreateGroupBox.TabStop = false;
            this.TableCreateGroupBox.Text = "Tables";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.AddNewTableButton);
            this.flowLayoutPanel1.Controls.Add(this.renameTableButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteTableButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddNewTableButton
            // 
            this.AddNewTableButton.Location = new System.Drawing.Point(3, 3);
            this.AddNewTableButton.Name = "AddNewTableButton";
            this.AddNewTableButton.Size = new System.Drawing.Size(69, 30);
            this.AddNewTableButton.TabIndex = 0;
            this.AddNewTableButton.Text = "Add";
            this.AddNewTableButton.UseVisualStyleBackColor = true;
            this.AddNewTableButton.Click += new System.EventHandler(this.AddNewTableButton_Click);
            // 
            // renameTableButton
            // 
            this.renameTableButton.Location = new System.Drawing.Point(78, 3);
            this.renameTableButton.Name = "renameTableButton";
            this.renameTableButton.Size = new System.Drawing.Size(69, 30);
            this.renameTableButton.TabIndex = 2;
            this.renameTableButton.Text = "Edit";
            this.renameTableButton.UseVisualStyleBackColor = true;
            this.renameTableButton.Click += new System.EventHandler(this.renameTableButton_Click);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Location = new System.Drawing.Point(153, 3);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(69, 30);
            this.DeleteTableButton.TabIndex = 0;
            this.DeleteTableButton.Text = "Delete";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
            // 
            // TableCreatePanelListBox
            // 
            this.TableCreatePanelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCreatePanelListBox.FormattingEnabled = true;
            this.TableCreatePanelListBox.ItemHeight = 18;
            this.TableCreatePanelListBox.Location = new System.Drawing.Point(2, 16);
            this.TableCreatePanelListBox.Name = "TableCreatePanelListBox";
            this.TableCreatePanelListBox.Size = new System.Drawing.Size(305, 328);
            this.TableCreatePanelListBox.TabIndex = 1;
            this.TableCreatePanelListBox.SelectedIndexChanged += new System.EventHandler(this.TableCreatePanelListBox_SelectedValueChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.upTableCreateButton);
            this.flowLayoutPanel4.Controls.Add(this.downTableCreateButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(242, 350);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(64, 32);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // upTableCreateButton
            // 
            this.upTableCreateButton.AutoSize = true;
            this.upTableCreateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upTableCreateButton.BackgroundImage")));
            this.upTableCreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upTableCreateButton.Location = new System.Drawing.Point(3, 3);
            this.upTableCreateButton.Name = "upTableCreateButton";
            this.upTableCreateButton.Size = new System.Drawing.Size(26, 26);
            this.upTableCreateButton.TabIndex = 0;
            this.upTableCreateButton.UseVisualStyleBackColor = true;
            this.upTableCreateButton.Click += new System.EventHandler(this.upTableCreateButton_Click);
            // 
            // downTableCreateButton
            // 
            this.downTableCreateButton.AutoSize = true;
            this.downTableCreateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downTableCreateButton.BackgroundImage")));
            this.downTableCreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downTableCreateButton.Location = new System.Drawing.Point(35, 3);
            this.downTableCreateButton.Name = "downTableCreateButton";
            this.downTableCreateButton.Size = new System.Drawing.Size(26, 26);
            this.downTableCreateButton.TabIndex = 1;
            this.downTableCreateButton.UseVisualStyleBackColor = true;
            this.downTableCreateButton.Click += new System.EventHandler(this.downTableCreateButton_Click);
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.IsSplitterFixed = true;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer8.Size = new System.Drawing.Size(608, 384);
            this.splitContainer8.SplitterDistance = 310;
            this.splitContainer8.SplitterWidth = 3;
            this.splitContainer8.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ColumnsCreatePanelListView);
            this.groupBox5.Controls.Add(this.flowLayoutPanel2);
            this.groupBox5.Controls.Add(this.flowLayoutPanel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 384);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Columns";
            // 
            // ColumnsCreatePanelListView
            // 
            this.ColumnsCreatePanelListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnsCreatePanelListView.FormattingEnabled = true;
            this.ColumnsCreatePanelListView.ItemHeight = 18;
            this.ColumnsCreatePanelListView.Location = new System.Drawing.Point(3, 16);
            this.ColumnsCreatePanelListView.Name = "ColumnsCreatePanelListView";
            this.ColumnsCreatePanelListView.Size = new System.Drawing.Size(306, 328);
            this.ColumnsCreatePanelListView.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.AddColumnButton);
            this.flowLayoutPanel2.Controls.Add(this.renameColumnButton);
            this.flowLayoutPanel2.Controls.Add(this.DeleteColumnButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 345);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(229, 37);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(3, 3);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(69, 30);
            this.AddColumnButton.TabIndex = 0;
            this.AddColumnButton.Text = "Add";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // renameColumnButton
            // 
            this.renameColumnButton.AutoSize = true;
            this.renameColumnButton.Location = new System.Drawing.Point(78, 3);
            this.renameColumnButton.Name = "renameColumnButton";
            this.renameColumnButton.Size = new System.Drawing.Size(69, 30);
            this.renameColumnButton.TabIndex = 3;
            this.renameColumnButton.Text = "Edit";
            this.renameColumnButton.UseVisualStyleBackColor = true;
            this.renameColumnButton.Click += new System.EventHandler(this.renameColumnButton_Click);
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.Location = new System.Drawing.Point(153, 3);
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.Size = new System.Drawing.Size(69, 30);
            this.DeleteColumnButton.TabIndex = 0;
            this.DeleteColumnButton.Text = "Delete";
            this.DeleteColumnButton.UseVisualStyleBackColor = true;
            this.DeleteColumnButton.Click += new System.EventHandler(this.DeleteColumnButton_Click_1);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.upColumnsCreateButton);
            this.flowLayoutPanel3.Controls.Add(this.downColumnsCreateButton);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Arial", 2F);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(243, 350);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(64, 32);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // upColumnsCreateButton
            // 
            this.upColumnsCreateButton.AutoSize = true;
            this.upColumnsCreateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upColumnsCreateButton.BackgroundImage")));
            this.upColumnsCreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upColumnsCreateButton.Location = new System.Drawing.Point(3, 3);
            this.upColumnsCreateButton.Name = "upColumnsCreateButton";
            this.upColumnsCreateButton.Size = new System.Drawing.Size(26, 26);
            this.upColumnsCreateButton.TabIndex = 0;
            this.upColumnsCreateButton.UseVisualStyleBackColor = true;
            this.upColumnsCreateButton.Click += new System.EventHandler(this.upColumnsCreateButton_Click);
            // 
            // downColumnsCreateButton
            // 
            this.downColumnsCreateButton.AutoSize = true;
            this.downColumnsCreateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downColumnsCreateButton.BackgroundImage")));
            this.downColumnsCreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downColumnsCreateButton.Location = new System.Drawing.Point(35, 3);
            this.downColumnsCreateButton.Name = "downColumnsCreateButton";
            this.downColumnsCreateButton.Size = new System.Drawing.Size(26, 26);
            this.downColumnsCreateButton.TabIndex = 1;
            this.downColumnsCreateButton.UseVisualStyleBackColor = true;
            this.downColumnsCreateButton.Click += new System.EventHandler(this.downColumnsCreateButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.CarrierRichTextBox);
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 380);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carrier Information";
            // 
            // CarrierRichTextBox
            // 
            this.CarrierRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarrierRichTextBox.Location = new System.Drawing.Point(3, 22);
            this.CarrierRichTextBox.Name = "CarrierRichTextBox";
            this.CarrierRichTextBox.Size = new System.Drawing.Size(291, 355);
            this.CarrierRichTextBox.TabIndex = 0;
            this.CarrierRichTextBox.Text = "";
            this.CarrierRichTextBox.Validated += new System.EventHandler(this.CarrierRichTextBox_Validated);
            // 
            // TableData
            // 
            this.TableData.BackColor = System.Drawing.Color.DarkGray;
            this.TableData.Controls.Add(this.splitContainer10);
            this.TableData.Location = new System.Drawing.Point(4, 39);
            this.TableData.Name = "TableData";
            this.TableData.Size = new System.Drawing.Size(926, 390);
            this.TableData.TabIndex = 5;
            this.TableData.Tag = "tableData";
            this.TableData.Text = "Table Data";
            // 
            // splitContainer10
            // 
            this.splitContainer10.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer10.IsSplitterFixed = true;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.flowLayoutPanel7);
            this.splitContainer10.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.TableDataGridView);
            this.splitContainer10.Size = new System.Drawing.Size(926, 390);
            this.splitContainer10.SplitterDistance = 58;
            this.splitContainer10.SplitterWidth = 3;
            this.splitContainer10.TabIndex = 0;
            this.splitContainer10.TabStop = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.RowMoveUpButton);
            this.flowLayoutPanel7.Controls.Add(this.RowMoveDownButton);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(824, 5);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(92, 46);
            this.flowLayoutPanel7.TabIndex = 2;
            // 
            // RowMoveUpButton
            // 
            this.RowMoveUpButton.AutoSize = true;
            this.RowMoveUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RowMoveUpButton.BackgroundImage")));
            this.RowMoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RowMoveUpButton.Location = new System.Drawing.Point(3, 3);
            this.RowMoveUpButton.Name = "RowMoveUpButton";
            this.RowMoveUpButton.Size = new System.Drawing.Size(40, 40);
            this.RowMoveUpButton.TabIndex = 0;
            this.RowMoveUpButton.UseVisualStyleBackColor = true;
            this.RowMoveUpButton.Click += new System.EventHandler(this.RowMoveUpButton_Click);
            // 
            // RowMoveDownButton
            // 
            this.RowMoveDownButton.AutoSize = true;
            this.RowMoveDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RowMoveDownButton.BackgroundImage")));
            this.RowMoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RowMoveDownButton.Location = new System.Drawing.Point(49, 3);
            this.RowMoveDownButton.Name = "RowMoveDownButton";
            this.RowMoveDownButton.Size = new System.Drawing.Size(40, 40);
            this.RowMoveDownButton.TabIndex = 1;
            this.RowMoveDownButton.UseVisualStyleBackColor = true;
            this.RowMoveDownButton.Click += new System.EventHandler(this.RowMoveDownButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.splitContainer11);
            this.panel4.Location = new System.Drawing.Point(234, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 57);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer11.IsSplitterFixed = true;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.TableDataViewSelectorBox);
            this.splitContainer11.Size = new System.Drawing.Size(419, 57);
            this.splitContainer11.SplitterDistance = 95;
            this.splitContainer11.SplitterWidth = 3;
            this.splitContainer11.TabIndex = 0;
            this.splitContainer11.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableDataViewSelectorBox
            // 
            this.TableDataViewSelectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDataViewSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableDataViewSelectorBox.FormattingEnabled = true;
            this.TableDataViewSelectorBox.Location = new System.Drawing.Point(2, 11);
            this.TableDataViewSelectorBox.Name = "TableDataViewSelectorBox";
            this.TableDataViewSelectorBox.Size = new System.Drawing.Size(316, 26);
            this.TableDataViewSelectorBox.TabIndex = 0;
            this.TableDataViewSelectorBox.SelectedIndexChanged += new System.EventHandler(this.TableDataViewSelectorBox_SelectedIndexChanged);
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.AllowDrop = true;
            this.TableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TableDataGridView.MultiSelect = false;
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.RowHeadersWidth = 51;
            this.TableDataGridView.RowTemplate.Height = 50;
            this.TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableDataGridView.Size = new System.Drawing.Size(926, 329);
            this.TableDataGridView.TabIndex = 1;
            this.TableDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDataGridView_CellEndEdit);
            // 
            // keyprovisions
            // 
            this.keyprovisions.Controls.Add(this.splitContainer3);
            this.keyprovisions.Location = new System.Drawing.Point(4, 39);
            this.keyprovisions.Name = "keyprovisions";
            this.keyprovisions.Size = new System.Drawing.Size(926, 390);
            this.keyprovisions.TabIndex = 6;
            this.keyprovisions.Tag = "keyProvisions";
            this.keyprovisions.Text = "Key Provisions";
            this.keyprovisions.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutPanel8);
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.KeyProvisionsDataView);
            this.splitContainer3.Size = new System.Drawing.Size(926, 390);
            this.splitContainer3.SplitterDistance = 58;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 1;
            this.splitContainer3.TabStop = false;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.KeyProvisionsDataViewUp);
            this.flowLayoutPanel8.Controls.Add(this.KeyProvisionsDataViewDown);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(824, 5);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(92, 46);
            this.flowLayoutPanel8.TabIndex = 2;
            // 
            // KeyProvisionsDataViewUp
            // 
            this.KeyProvisionsDataViewUp.AutoSize = true;
            this.KeyProvisionsDataViewUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KeyProvisionsDataViewUp.BackgroundImage")));
            this.KeyProvisionsDataViewUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KeyProvisionsDataViewUp.Location = new System.Drawing.Point(3, 3);
            this.KeyProvisionsDataViewUp.Name = "KeyProvisionsDataViewUp";
            this.KeyProvisionsDataViewUp.Size = new System.Drawing.Size(40, 40);
            this.KeyProvisionsDataViewUp.TabIndex = 0;
            this.KeyProvisionsDataViewUp.UseVisualStyleBackColor = true;
            this.KeyProvisionsDataViewUp.Click += new System.EventHandler(this.KeyProvisionsDataViewUp_Click);
            // 
            // KeyProvisionsDataViewDown
            // 
            this.KeyProvisionsDataViewDown.AutoSize = true;
            this.KeyProvisionsDataViewDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KeyProvisionsDataViewDown.BackgroundImage")));
            this.KeyProvisionsDataViewDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KeyProvisionsDataViewDown.Location = new System.Drawing.Point(49, 3);
            this.KeyProvisionsDataViewDown.Name = "KeyProvisionsDataViewDown";
            this.KeyProvisionsDataViewDown.Size = new System.Drawing.Size(40, 40);
            this.KeyProvisionsDataViewDown.TabIndex = 1;
            this.KeyProvisionsDataViewDown.UseVisualStyleBackColor = true;
            this.KeyProvisionsDataViewDown.Click += new System.EventHandler(this.KeyProvisionsDataViewDown_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer4);
            this.panel2.Location = new System.Drawing.Point(158, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 57);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.KeyProvisionsDataViewSelectorBox);
            this.splitContainer4.Size = new System.Drawing.Size(495, 57);
            this.splitContainer4.SplitterDistance = 171;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 57);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key Provision Table:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyProvisionsDataViewSelectorBox
            // 
            this.KeyProvisionsDataViewSelectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyProvisionsDataViewSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyProvisionsDataViewSelectorBox.FormattingEnabled = true;
            this.KeyProvisionsDataViewSelectorBox.Location = new System.Drawing.Point(2, 11);
            this.KeyProvisionsDataViewSelectorBox.Name = "KeyProvisionsDataViewSelectorBox";
            this.KeyProvisionsDataViewSelectorBox.Size = new System.Drawing.Size(316, 26);
            this.KeyProvisionsDataViewSelectorBox.TabIndex = 0;
            this.KeyProvisionsDataViewSelectorBox.SelectedIndexChanged += new System.EventHandler(this.KeyProvisionsDataViewSelectorBox_SelectedIndexChanged);
            // 
            // KeyProvisionsDataView
            // 
            this.KeyProvisionsDataView.AllowDrop = true;
            this.KeyProvisionsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.KeyProvisionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KeyProvisionsDataView.DefaultCellStyle = dataGridViewCellStyle4;
            this.KeyProvisionsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyProvisionsDataView.Location = new System.Drawing.Point(0, 0);
            this.KeyProvisionsDataView.MultiSelect = false;
            this.KeyProvisionsDataView.Name = "KeyProvisionsDataView";
            this.KeyProvisionsDataView.RowHeadersWidth = 51;
            this.KeyProvisionsDataView.RowTemplate.Height = 50;
            this.KeyProvisionsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.KeyProvisionsDataView.Size = new System.Drawing.Size(926, 329);
            this.KeyProvisionsDataView.TabIndex = 1;
            this.KeyProvisionsDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.KeyProvisionsDataView_CellEndEdit);
            // 
            // ExportTab
            // 
            this.ExportTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExportTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExportTab.Controls.Add(this.panel1);
            this.ExportTab.Location = new System.Drawing.Point(4, 39);
            this.ExportTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Size = new System.Drawing.Size(926, 390);
            this.ExportTab.TabIndex = 3;
            this.ExportTab.Tag = "";
            this.ExportTab.Text = "Appendicies";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 386);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.appendiciesLabelBox);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(257, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 378);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appendicies";
            // 
            // appendiciesLabelBox
            // 
            this.appendiciesLabelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appendiciesLabelBox.FormattingEnabled = true;
            this.appendiciesLabelBox.ItemHeight = 18;
            this.appendiciesLabelBox.Location = new System.Drawing.Point(3, 22);
            this.appendiciesLabelBox.Name = "appendiciesLabelBox";
            this.appendiciesLabelBox.Size = new System.Drawing.Size(408, 305);
            this.appendiciesLabelBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer5);
            this.panel5.Controls.Add(this.flowLayoutPanel5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 48);
            this.panel5.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 4);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.AppendiciesAddButton);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.AppendiciesDeleteButton);
            this.splitContainer5.Size = new System.Drawing.Size(317, 41);
            this.splitContainer5.SplitterDistance = 162;
            this.splitContainer5.TabIndex = 17;
            this.splitContainer5.TabStop = false;
            // 
            // AppendiciesAddButton
            // 
            this.AppendiciesAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppendiciesAddButton.Location = new System.Drawing.Point(0, 0);
            this.AppendiciesAddButton.Name = "AppendiciesAddButton";
            this.AppendiciesAddButton.Size = new System.Drawing.Size(162, 41);
            this.AppendiciesAddButton.TabIndex = 0;
            this.AppendiciesAddButton.Text = "Add";
            this.AppendiciesAddButton.UseVisualStyleBackColor = true;
            this.AppendiciesAddButton.Click += new System.EventHandler(this.AppendiciesAddButton_Click);
            // 
            // AppendiciesDeleteButton
            // 
            this.AppendiciesDeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppendiciesDeleteButton.Location = new System.Drawing.Point(0, 0);
            this.AppendiciesDeleteButton.Name = "AppendiciesDeleteButton";
            this.AppendiciesDeleteButton.Size = new System.Drawing.Size(151, 41);
            this.AppendiciesDeleteButton.TabIndex = 0;
            this.AppendiciesDeleteButton.Text = "Delete";
            this.AppendiciesDeleteButton.UseVisualStyleBackColor = true;
            this.AppendiciesDeleteButton.Click += new System.EventHandler(this.AppendiciesDeleteButton_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.AppendiciesUpButton);
            this.flowLayoutPanel5.Controls.Add(this.AppendiciesDownButton);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(323, 4);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(82, 41);
            this.flowLayoutPanel5.TabIndex = 16;
            // 
            // AppendiciesUpButton
            // 
            this.AppendiciesUpButton.AutoSize = true;
            this.AppendiciesUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppendiciesUpButton.BackgroundImage")));
            this.AppendiciesUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppendiciesUpButton.Location = new System.Drawing.Point(3, 3);
            this.AppendiciesUpButton.Name = "AppendiciesUpButton";
            this.AppendiciesUpButton.Size = new System.Drawing.Size(35, 35);
            this.AppendiciesUpButton.TabIndex = 0;
            this.AppendiciesUpButton.UseVisualStyleBackColor = true;
            this.AppendiciesUpButton.Click += new System.EventHandler(this.AppendiciesUpButton_Click);
            // 
            // AppendiciesDownButton
            // 
            this.AppendiciesDownButton.AutoSize = true;
            this.AppendiciesDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppendiciesDownButton.BackgroundImage")));
            this.AppendiciesDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppendiciesDownButton.Location = new System.Drawing.Point(44, 3);
            this.AppendiciesDownButton.Name = "AppendiciesDownButton";
            this.AppendiciesDownButton.Size = new System.Drawing.Size(35, 35);
            this.AppendiciesDownButton.TabIndex = 1;
            this.AppendiciesDownButton.UseVisualStyleBackColor = true;
            this.AppendiciesDownButton.Click += new System.EventHandler(this.AppendiciesDownButton_Click);
            // 
            // openWordDocumentFileDialog
            // 
            this.openWordDocumentFileDialog.Filter = "Word Documents|*.doc;*.docx";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.generateProposalToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileDialog_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // generateProposalToolStripMenuItem
            // 
            this.generateProposalToolStripMenuItem.Name = "generateProposalToolStripMenuItem";
            this.generateProposalToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.generateProposalToolStripMenuItem.Text = "Generate Proposal";
            this.generateProposalToolStripMenuItem.Click += new System.EventHandler(this.StartExportButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png;";
            // 
            // PolicyCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "PolicyCreator";
            this.Text = "Proposal Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PolicyCreator_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PolicyCreator_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.BuisnessInformationTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessPictureBox)).EndInit();
            this.Tables.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.TableCreateGroupBox.ResumeLayout(false);
            this.TableCreateGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.TableData.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel1.PerformLayout();
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.keyprovisions.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyProvisionsDataView)).EndInit();
            this.ExportTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage BuisnessInformationTab;
        private TabPage ExportTab;
        private SplitContainer splitContainer2;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox AgentPositionTextBox;
        private Label label7;
        private TextBox AgentNameTextBox;
        private TextBox AgentWebsiteTextBox;
        private Label label10;
        private TextBox AgentPhoneNumberTextBox;
        private Label label9;
        private TextBox AgentEmailTextBox;
        private Label label8;
        private DateTimePicker BusinessEndDate;
        private DateTimePicker BusinessStartDate;
        private Label label14;
        private Label label13;
        private TextBox BusinessLegalNameTextBox;
        private Label label12;
        private TextBox BuisnessNameTextBox;
        private Label label11;
        private Panel panel1;
        private OpenFileDialog openWordDocumentFileDialog;
        private TextBox AgentBusinessNameTextBox;
        private Label label16;
        private OpenFileDialog openMyFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private SaveFileDialog saveMyFileDialog;
        private ToolStripMenuItem newToolStripMenuItem;
        private TabPage Tables;
        private SplitContainer splitContainer6;
        private GroupBox TableCreateGroupBox;
        private CustomControls.CustomPanel TableCreatePanelListBox;
        private Button AddNewTableButton;
        private Button DeleteTableButton;
        private SplitContainer splitContainer8;
        private GroupBox groupBox5;
        private CustomControls.CustomPanel ColumnsCreatePanelListView;
        private Button AddColumnButton;
        private Button DeleteColumnButton;
        private GroupBox groupBox6;
        private RichTextBox CarrierRichTextBox;
        private TabPage TableData;
        private SplitContainer splitContainer10;
        private Panel panel4;
        private SplitContainer splitContainer11;
        private Label label2;
        private ComboBox TableDataViewSelectorBox;
        private DataGridView TableDataGridView;
        private GroupBox groupBox1;
        private CustomControls.CustomPanel appendiciesLabelBox;
        private Panel panel5;
        private Button AppendiciesAddButton;
        private Button AppendiciesDeleteButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button upTableCreateButton;
        private Button downTableCreateButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button upColumnsCreateButton;
        private Button downColumnsCreateButton;
        private Button renameTableButton;
        private Button renameColumnButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private ToolStripMenuItem generateProposalToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button AppendiciesUpButton;
        private Button AppendiciesDownButton;
        private OpenFileDialog openImageDialog;
        private PictureBox businessPictureBox;
        private Button BrowseImageLocation;
        private SplitContainer splitContainer1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button RowMoveUpButton;
        private Button RowMoveDownButton;
        private TabPage keyprovisions;
        private SplitContainer splitContainer3;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button KeyProvisionsDataViewUp;
        private Button KeyProvisionsDataViewDown;
        private Panel panel2;
        private SplitContainer splitContainer4;
        private Label label3;
        private ComboBox KeyProvisionsDataViewSelectorBox;
        private DataGridView KeyProvisionsDataView;
        private SplitContainer splitContainer5;
    }
}