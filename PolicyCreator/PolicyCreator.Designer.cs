﻿using InsuranceSummaryMaker.Serialization;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.upTableCreateButton = new System.Windows.Forms.Button();
            this.downTableCreateButton = new System.Windows.Forms.Button();
            this.TableCreatePanelListBox = new InsuranceSummaryMaker.CustomControls.CustomPanel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.TableDataViewSelectorBox = new System.Windows.Forms.ComboBox();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appendiciesLabelBox = new InsuranceSummaryMaker.CustomControls.CustomPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AppendiciesAddButton = new System.Windows.Forms.Button();
            this.AppendiciesDeleteButton = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.BuisnessInformationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.ExportTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BuisnessInformationTab);
            this.tabControl1.Controls.Add(this.Tables);
            this.tabControl1.Controls.Add(this.TableData);
            this.tabControl1.Controls.Add(this.ExportTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 533);
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
            this.BuisnessInformationTab.Size = new System.Drawing.Size(906, 490);
            this.BuisnessInformationTab.TabIndex = 1;
            this.BuisnessInformationTab.Text = "Buisness Information";
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
            this.splitContainer2.Panel2.Controls.Add(this.BusinessEndDate);
            this.splitContainer2.Panel2.Controls.Add(this.BusinessStartDate);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.label13);
            this.splitContainer2.Panel2.Controls.Add(this.BusinessLegalNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.BuisnessNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Size = new System.Drawing.Size(900, 484);
            this.splitContainer2.SplitterDistance = 428;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // AgentBusinessNameTextBox
            // 
            this.AgentBusinessNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentBusinessNameTextBox.Location = new System.Drawing.Point(105, 214);
            this.AgentBusinessNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgentBusinessNameTextBox.Name = "AgentBusinessNameTextBox";
            this.AgentBusinessNameTextBox.Size = new System.Drawing.Size(307, 26);
            this.AgentBusinessNameTextBox.TabIndex = 12;
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
            this.AgentWebsiteTextBox.Size = new System.Drawing.Size(307, 26);
            this.AgentWebsiteTextBox.TabIndex = 10;
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
            this.AgentPhoneNumberTextBox.Size = new System.Drawing.Size(307, 26);
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
            this.AgentEmailTextBox.Size = new System.Drawing.Size(307, 26);
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
            this.AgentPositionTextBox.Size = new System.Drawing.Size(307, 26);
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
            this.AgentNameTextBox.Size = new System.Drawing.Size(307, 26);
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
            // BusinessEndDate
            // 
            this.BusinessEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusinessEndDate.CustomFormat = "M / d / yyyy";
            this.BusinessEndDate.Location = new System.Drawing.Point(130, 143);
            this.BusinessEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusinessEndDate.Name = "BusinessEndDate";
            this.BusinessEndDate.Size = new System.Drawing.Size(326, 26);
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
            this.BusinessStartDate.Size = new System.Drawing.Size(326, 26);
            this.BusinessStartDate.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label14.Location = new System.Drawing.Point(19, 142);
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
            this.label13.Location = new System.Drawing.Point(19, 107);
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
            this.BusinessLegalNameTextBox.Size = new System.Drawing.Size(326, 26);
            this.BusinessLegalNameTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label12.Location = new System.Drawing.Point(19, 69);
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
            this.BuisnessNameTextBox.Size = new System.Drawing.Size(326, 26);
            this.BuisnessNameTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label11.Location = new System.Drawing.Point(19, 35);
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
            this.label5.Size = new System.Drawing.Size(469, 28);
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
            this.Tables.Size = new System.Drawing.Size(906, 490);
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
            this.splitContainer6.Size = new System.Drawing.Size(900, 484);
            this.splitContainer6.SplitterDistance = 309;
            this.splitContainer6.SplitterWidth = 3;
            this.splitContainer6.TabIndex = 0;
            // 
            // TableCreateGroupBox
            // 
            this.TableCreateGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.TableCreateGroupBox.Controls.Add(this.TableCreatePanelListBox);
            this.TableCreateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableCreateGroupBox.Location = new System.Drawing.Point(0, 0);
            this.TableCreateGroupBox.Name = "TableCreateGroupBox";
            this.TableCreateGroupBox.Size = new System.Drawing.Size(309, 484);
            this.TableCreateGroupBox.TabIndex = 0;
            this.TableCreateGroupBox.TabStop = false;
            this.TableCreateGroupBox.Text = "Table Create";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.AddNewTableButton);
            this.flowLayoutPanel1.Controls.Add(this.renameTableButton);
            this.flowLayoutPanel1.Controls.Add(this.DeleteTableButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 443);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 38);
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.upTableCreateButton);
            this.flowLayoutPanel4.Controls.Add(this.downTableCreateButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(228, 3);
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
            // TableCreatePanelListBox
            // 
            this.TableCreatePanelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCreatePanelListBox.FormattingEnabled = true;
            this.TableCreatePanelListBox.ItemHeight = 18;
            this.TableCreatePanelListBox.Location = new System.Drawing.Point(3, 21);
            this.TableCreatePanelListBox.Name = "TableCreatePanelListBox";
            this.TableCreatePanelListBox.Size = new System.Drawing.Size(303, 418);
            this.TableCreatePanelListBox.TabIndex = 1;
            this.TableCreatePanelListBox.SelectedIndexChanged += new System.EventHandler(this.TableCreatePanelListBox_SelectedValueChanged);
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
            this.splitContainer8.Size = new System.Drawing.Size(588, 484);
            this.splitContainer8.SplitterDistance = 307;
            this.splitContainer8.SplitterWidth = 3;
            this.splitContainer8.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ColumnsCreatePanelListView);
            this.groupBox5.Controls.Add(this.flowLayoutPanel2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 484);
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
            this.ColumnsCreatePanelListView.Location = new System.Drawing.Point(1, 21);
            this.ColumnsCreatePanelListView.Name = "ColumnsCreatePanelListView";
            this.ColumnsCreatePanelListView.Size = new System.Drawing.Size(303, 418);
            this.ColumnsCreatePanelListView.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.AddColumnButton);
            this.flowLayoutPanel2.Controls.Add(this.renameColumnButton);
            this.flowLayoutPanel2.Controls.Add(this.DeleteColumnButton);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 443);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(301, 38);
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
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.upColumnsCreateButton);
            this.flowLayoutPanel3.Controls.Add(this.downColumnsCreateButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(228, 3);
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
            this.groupBox6.Size = new System.Drawing.Size(279, 448);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carrier Information";
            // 
            // CarrierRichTextBox
            // 
            this.CarrierRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarrierRichTextBox.Location = new System.Drawing.Point(3, 22);
            this.CarrierRichTextBox.Name = "CarrierRichTextBox";
            this.CarrierRichTextBox.Size = new System.Drawing.Size(273, 423);
            this.CarrierRichTextBox.TabIndex = 0;
            this.CarrierRichTextBox.Text = "";
            // 
            // TableData
            // 
            this.TableData.BackColor = System.Drawing.Color.DarkGray;
            this.TableData.Controls.Add(this.splitContainer10);
            this.TableData.Location = new System.Drawing.Point(4, 39);
            this.TableData.Name = "TableData";
            this.TableData.Size = new System.Drawing.Size(906, 490);
            this.TableData.TabIndex = 5;
            this.TableData.Tag = "tableData";
            this.TableData.Text = "Table Data";
            // 
            // splitContainer10
            // 
            this.splitContainer10.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.TableDataGridView);
            this.splitContainer10.Size = new System.Drawing.Size(906, 490);
            this.splitContainer10.SplitterDistance = 58;
            this.splitContainer10.SplitterWidth = 3;
            this.splitContainer10.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.splitContainer11);
            this.panel4.Location = new System.Drawing.Point(234, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 57);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer11.Size = new System.Drawing.Size(398, 57);
            this.splitContainer11.SplitterDistance = 95;
            this.splitContainer11.SplitterWidth = 3;
            this.splitContainer11.TabIndex = 0;
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
            this.TableDataViewSelectorBox.FormattingEnabled = true;
            this.TableDataViewSelectorBox.Location = new System.Drawing.Point(2, 11);
            this.TableDataViewSelectorBox.Name = "TableDataViewSelectorBox";
            this.TableDataViewSelectorBox.Size = new System.Drawing.Size(296, 26);
            this.TableDataViewSelectorBox.TabIndex = 0;
            this.TableDataViewSelectorBox.SelectedIndexChanged += new System.EventHandler(this.TableDataViewSelectorBox_SelectedIndexChanged);
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.AllowDrop = true;
            this.TableDataGridView.AllowUserToOrderColumns = true;
            this.TableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TableDataGridView.MultiSelect = false;
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.RowHeadersWidth = 51;
            this.TableDataGridView.RowTemplate.Height = 50;
            this.TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableDataGridView.Size = new System.Drawing.Size(906, 429);
            this.TableDataGridView.TabIndex = 1;
            this.TableDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableDataGridView_CellEndEdit);
            // 
            // ExportTab
            // 
            this.ExportTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExportTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExportTab.Controls.Add(this.panel1);
            this.ExportTab.Location = new System.Drawing.Point(4, 39);
            this.ExportTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Size = new System.Drawing.Size(906, 490);
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
            this.panel1.Size = new System.Drawing.Size(902, 486);
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
            this.groupBox1.Size = new System.Drawing.Size(395, 478);
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
            this.appendiciesLabelBox.Size = new System.Drawing.Size(389, 399);
            this.appendiciesLabelBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 421);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 54);
            this.panel5.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AppendiciesAddButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AppendiciesDeleteButton);
            this.splitContainer1.Size = new System.Drawing.Size(389, 54);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // AppendiciesAddButton
            // 
            this.AppendiciesAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppendiciesAddButton.Location = new System.Drawing.Point(0, 0);
            this.AppendiciesAddButton.Name = "AppendiciesAddButton";
            this.AppendiciesAddButton.Size = new System.Drawing.Size(185, 54);
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
            this.AppendiciesDeleteButton.Size = new System.Drawing.Size(201, 54);
            this.AppendiciesDeleteButton.TabIndex = 0;
            this.AppendiciesDeleteButton.Text = "Delete";
            this.AppendiciesDeleteButton.UseVisualStyleBackColor = true;
            this.AppendiciesDeleteButton.Click += new System.EventHandler(this.AppendiciesDeleteButton_Click);
            // 
            // openWordDocumentFileDialog
            // 
            this.openWordDocumentFileDialog.FileName = "document.docx";
            this.openWordDocumentFileDialog.Filter = "Word Documents|*.doc;*.docx";
            // 
            // openMyFileDialog
            // 
            this.openMyFileDialog.FileName = "openFileDialog2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
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
            // PolicyCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(930, 500);
            this.Name = "PolicyCreator";
            this.Text = "Proposal Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PolicyCreator_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.BuisnessInformationTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Tables.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.TableCreateGroupBox.ResumeLayout(false);
            this.TableCreateGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ExportTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
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
    }
}