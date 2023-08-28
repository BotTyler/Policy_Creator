﻿using InsuranceSummaryMaker.ConvertToDoc;
using InsuranceSummaryMaker.CustomControls.CustomMessageBox;
using InsuranceSummaryMaker.PolicyInformation;
using InsuranceSummaryMaker.Serialization;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace InsuranceSummaryMaker
{
    internal partial class PolicyCreator : Form
    {
        private List<CoverageInformation> tableInformationList;


        private List<AppendFile> addons;

        private string openedPath = null;
        private string openedPathFileName = null;


        public PolicyCreator()
        {


            this.tableInformationList = new List<CoverageInformation>();
            this.addons = new List<AppendFile>();


            InitializeComponent();
            setFilters();



        }

        public PolicyCreator(string openedPath, string fileName)
        {
            InitializeComponent();
            setFilters();
            this.Text = fileName;
            this.tableInformationList = new List<CoverageInformation>();
            this.addons = new List<AppendFile>();

            /**************************************************************/
            // grab json From file
            JObject json = PolicyInformationSerializer.openFile(openedPath);

            // populate each object
            AgentInformation agent = new AgentInformation(json["agentInformation"]);
            BusinessInformation business = new BusinessInformation(json["businessInformation"]);

            // coverage information parse
            foreach (JToken token in (JArray)json["coverageInformation"])
            {
                this.tableInformationList.Add(new CoverageInformation(token));
            }

            // append files parse
            foreach (JToken token in (JArray)json["addonInformation"])
            {
                this.addons.Add(new AppendFile(token));
            }
            /***************************************************************/

            this.openedPath = openedPath; //
            this.openedPathFileName = fileName;
            populateAllFields(agent, business, this.tableInformationList, this.addons);

        }

        public void setFilters()
        {
            this.TableDataGridView.RowTemplate.MinimumHeight = 75;
            string filter = "JJInsurance Policy Creator (*" + PolicyInformationSerializer.fileExtension + ")|*" + PolicyInformationSerializer.fileExtension;
            this.openMyFileDialog.Filter = filter;
            this.saveMyFileDialog.Filter = filter;
        }




        #region tab menu Events
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                if (this.tabControl1.SelectedTab.Tag.Equals("tableData"))
                {

                    refreshTable();

                }

            }
            else
            {
                this.TableDataGridView.Rows.Clear();
                this.TableDataGridView.Columns.Clear();
            }
        }

        private void StartExportButton_Click(object sender, EventArgs e)
        {
            endTableEditMode();
            using (ExportMessageBox message = new ExportMessageBox())
            {
                if (message.ShowDialog() == DialogResult.OK)
                {
                    string filePath = message.documentpath;
                    string templatePath = message.templatePath;

                    AgentInformation agent = getAgentInformation();
                    BusinessInformation business = getBusinessInformation(); ;

                    ConvertToDocument.StartExport(templatePath, filePath, this.tableInformationList, agent, business, this.addons);


                }

            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open new window need new constructor TODO
            Thread thread = new Thread(() => Application.Run(new PolicyCreator()))
            {
                IsBackground = false
            };

            thread.SetApartmentState(ApartmentState.STA);

            thread.Start();
        }




        private void openFileDialog_Click(object sender, EventArgs e)
        {
            if (this.openMyFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openPath = this.openMyFileDialog.FileName;
                string fileName = this.openMyFileDialog.SafeFileName;


                // open new window need new constructor TODO
                Thread thread = new Thread(() => Application.Run(new PolicyCreator(openPath, fileName)))
                {
                    IsBackground = false
                };

                thread.SetApartmentState(ApartmentState.STA);

                thread.Start();

            }
        }

        #endregion

        #region addons modifications
        private void AppendiciesAddButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openWordDocumentFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = this.openWordDocumentFileDialog.FileName;
                string fileName = this.openWordDocumentFileDialog.SafeFileName;
                AppendFile x = new AppendFile(filePath, fileName);

                this.addons.Add(x);

                refreshAppendicies();
            }
        }

        private void AppendiciesDeleteButton_Click(object sender, EventArgs e)
        {

            int currentIndex = this.appendiciesLabelBox.SelectedIndex;
            if (currentIndex >= 0)
            {
                if (!yesNoMessageBoxConfirmation("Are you sure you want to delete Appendicy: " + this.addons[currentIndex].fileName))
                {
                    return;
                }
                deleteAppendicy(currentIndex);
                refreshAppendicies();
            }
            else
            {
                MessageBox.Show("Please select an appendicy.");
            }
        }



        private void refreshAppendicies()
        {
            this.appendiciesLabelBox.Items.Clear();
            foreach (AppendFile x in this.addons)
            {
                this.appendiciesLabelBox.Items.Add(x.fileName);
            }
        }

        private void deleteAppendicy(int index)
        {
            this.addons.RemoveAt(index);
        }


        #endregion

        #region agent and business information
        private AgentInformation getAgentInformation()
        {
            string agentName = this.AgentNameTextBox.Text;
            string agentPosition = this.AgentPositionTextBox.Text;
            string agentEmail = this.AgentEmailTextBox.Text;
            string agentPhone = this.AgentPhoneNumberTextBox.Text;
            string agentWebsite = this.AgentWebsiteTextBox.Text;
            string agentBusinessName = this.AgentBusinessNameTextBox.Text;

            return new AgentInformation(agentName, agentPosition, agentEmail, agentPhone, agentWebsite, agentBusinessName);
        }


        private BusinessInformation getBusinessInformation()
        {
            string businessName = this.BuisnessNameTextBox.Text;
            string businessLegalName = this.BusinessLegalNameTextBox.Text;
            DateTime businessStart = this.BusinessStartDate.Value;
            DateTime businessEnd = this.BusinessEndDate.Value;

            return new BusinessInformation(businessName, businessLegalName, businessStart, businessEnd);
        }
        #endregion

        #region new window

        #region populating
        private void populateAllFields(AgentInformation agent, BusinessInformation business, List<CoverageInformation> coverages, List<AppendFile> addons)
        {
            populateAgentTextBoxes(agent);
            populateBusinessTextBoxes(business);
            populateCoveragePage(coverages);
            populateAddons(addons);
        }

        private void populateAgentTextBoxes(AgentInformation agent)
        {
            this.AgentNameTextBox.Text = agent._agentName;
            this.AgentPositionTextBox.Text = agent._agentPosition;
            this.AgentEmailTextBox.Text = agent._agentEmail;
            this.AgentPhoneNumberTextBox.Text = agent._agentNumber;
            this.AgentWebsiteTextBox.Text = agent._agentWebsite;
            this.AgentBusinessNameTextBox.Text = agent._agentBusiness;
        }

        private void populateBusinessTextBoxes(BusinessInformation business)
        {
            this.BuisnessNameTextBox.Text = business._name;
            this.BusinessLegalNameTextBox.Text = business._legalName;
            this.BusinessStartDate.Value = business._start;
            this.BusinessEndDate.Value = business._end;
        }

        private void populateCoveragePage(List<CoverageInformation> coverages)
        {
            foreach (CoverageInformation coverage in coverages)
            {
                addExistingTable(coverage);
            }
        }

        private void populateAddons(List<AppendFile> adds)
        {
            refreshAppendicies();
        }


        #endregion

        #endregion

        #region saving
        private void save(string path, string fileName)
        {
            endTableEditMode();
            this.Text = fileName;
            this.openedPath = path;
            this.openedPathFileName = fileName;
            AgentInformation agent = getAgentInformation();
            BusinessInformation business = getBusinessInformation();

            PolicyInformationSerializer.StartExport(agent, business, this.tableInformationList, this.addons, path);
        }

        private bool checkIfFileCanBeSavedTo(string path)
        {
            return path != null && File.Exists(path);
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveMyFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = this.saveMyFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                save(filePath, fileName);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // we know the file we are saving to and do not need to ask for a file
            if (checkIfFileCanBeSavedTo(this.openedPath))
            {
                save(this.openedPath, this.openedPathFileName);
            }
            else
            {
                // We can't find a file to save to run the saveAs();
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        #endregion


        #region table Modification

        private void AddNewTableButton_Click(object sender, EventArgs e)
        {
            using (AddCancelMessageBox messageBox = new AddCancelMessageBox("Enter Name of the Table: "))
            {
                if (messageBox.ShowDialog() == DialogResult.OK)
                {
                    // get the table name input and add it to the tables list
                    string tableName = messageBox.text;

                    addTable(tableName);

                }


            }
        }

        private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (currentIndex >= 0)
            {
                // there is a selected index
                if (!yesNoMessageBoxConfirmation("Are you sure you want to delete table: " + this.tableInformationList[currentIndex]._tableName)) { return; }
                removeTable(currentIndex);
                clearCarrierInformation();
                clearColumnsListBox();
            }
            else
            {
                MessageBox.Show("There is no table selected.");
            }
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (currentIndex >= 0)
            {

                using (AddCancelMessageBox messageBox = new AddCancelMessageBox("Enter Name of the Column: "))
                {
                    if (messageBox.ShowDialog() == DialogResult.OK)
                    {
                        // get the table name input and add it to the tables list
                        string columnName = messageBox.text;

                        addColumnToCurrentTable(currentIndex, columnName);
                    }


                }

            }
            else
            {
                // display that you should select a table
                MessageBox.Show("No table is selected.");
            }
        }

        private void DeleteColumnButton_Click_1(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int columnIndex = this.ColumnsCreatePanelListView.SelectedIndex;
            if (columnIndex >= 0)
            {
                if (!yesNoMessageBoxConfirmation("Are you sure you want to delete column: " + this.tableInformationList[tableIndex].getColumnNameAtIndex(columnIndex))) { return; }
                // the next 3 lines are to remove the Lists from the datagridview


                removeColumn(tableIndex, columnIndex);



            }
            else
            {
                MessageBox.Show("No column is selected.");
            }
        }

        private void TableCreatePanelListBox_SelectedValueChanged(object sender, EventArgs e)
        {


            int changeIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (changeIndex >= 0)
            {
                populateColumnsListBox(this.tableInformationList[changeIndex]._columns);
                refreshCarrierInformation(this.tableInformationList[changeIndex]._carrierInformation);
            }
        }

        private void CarrierRichTextBox_Validated(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (tableIndex >= 0)
            {
                this.tableInformationList[tableIndex]._carrierInformation = this.CarrierRichTextBox.Text;
            }
        }

        private void TableDataViewSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add all the columns and rowws to the data view
            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;
            if (currentIndex >= 0)
            {
                CoverageInformation currentTable = this.tableInformationList[currentIndex];
                setDataGridColumns(currentTable._columns);
                setDataGridRows(currentTable._rows);
            }
        }

        private void swapColumns(int tableIndex, int swapSelected, int swapTo)
        {
            if (tableIndex < 0 || tableIndex >= this.tableInformationList.Count) { return; }
            if (swapSelected < 0 || swapSelected >= this.tableInformationList[tableIndex]._columns.Count) { return; }
            if (swapTo < 0 || swapTo >= this.tableInformationList[tableIndex]._columns.Count) { return; }

            // swap the columns in the object
            this.tableInformationList[tableIndex].swapColumn(swapSelected, swapTo);


            // swap in the panel list view
            var item = this.ColumnsCreatePanelListView.Items[swapTo];
            this.ColumnsCreatePanelListView.Items.RemoveAt(swapTo);
            this.ColumnsCreatePanelListView.Items.Insert(swapSelected, item);

        }

        private void swapTables(int fromTableIndex, int toTableIndex)
        {
            if (fromTableIndex < 0 || fromTableIndex >= this.tableInformationList.Count) { return; }
            if (toTableIndex < 0 || toTableIndex >= this.tableInformationList.Count) { return; }

            //swap the tables in the list

            CoverageInformation tempTable = this.tableInformationList[fromTableIndex];
            this.tableInformationList[fromTableIndex] = this.tableInformationList[toTableIndex];
            this.tableInformationList[toTableIndex] = tempTable;

            // swap in the panel list view
            var item = this.TableCreatePanelListBox.Items[toTableIndex];
            this.TableCreatePanelListBox.Items.RemoveAt(toTableIndex);
            this.TableCreatePanelListBox.Items.Insert(fromTableIndex, item);

            // swap on the data grid view combo box
            var comboItem = this.TableDataViewSelectorBox.Items[toTableIndex];
            this.TableDataViewSelectorBox.Items.RemoveAt(toTableIndex);
            this.TableDataViewSelectorBox.Items.Insert(fromTableIndex, item);
        }

        private void upTableCreateButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int newTableIndex = tableIndex - 1;
            swapTables(tableIndex, newTableIndex);
        }

        private void downTableCreateButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int newTableIndex = tableIndex + 1;
            swapTables(tableIndex, newTableIndex);
        }

        private void upColumnsCreateButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int index = this.ColumnsCreatePanelListView.SelectedIndex;
            int toIndex = index - 1;
            swapColumns(tableIndex, index, toIndex);
        }

        private void downColumnsCreateButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int index = this.ColumnsCreatePanelListView.SelectedIndex;
            int toIndex = index + 1;
            swapColumns(tableIndex, index, toIndex);
        }



        private void startSave()
        {
            //MessageBox.Show("Validated");
            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;

            if (currentIndex >= 0)
            {
                this.tableInformationList[currentIndex].setNewTable(this.TableDataGridView);
            }
        }

        private void endTableEditMode()
        {

            if (this.TableDataGridView.IsCurrentCellInEditMode)
            {

                this.TableDataGridView.EndEdit();

            }
        }

        private void TableDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            startSave();
        }

        private void renameTableButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableCreatePanelListBox.SelectedIndex;


            if (currentIndex < 0)
            {
                MessageBox.Show("Please select a table.");
                return;

            }
            string tableName = this.tableInformationList[currentIndex]._tableName;
            using (RenameMessageBox message = new RenameMessageBox("Rename table \"" + tableName + "\" to:", tableName))
            {
                if (message.ShowDialog() == DialogResult.OK)
                {
                    this.tableInformationList[currentIndex]._tableName = message.renameValue;
                    this.TableCreatePanelListBox.Items[currentIndex] = message.renameValue;
                    this.TableDataViewSelectorBox.Items[currentIndex] = message.renameValue;
                }
            }
        }

        private void renameColumnButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int columnIndex = this.ColumnsCreatePanelListView.SelectedIndex;

            if (tableIndex < 0)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            if (columnIndex < 0)
            {
                MessageBox.Show("Please select a column");
                return;
            }


            string columnName = this.tableInformationList[tableIndex].getColumnNameAtIndex(columnIndex);
            using (RenameMessageBox message = new RenameMessageBox("Rename column \"" + columnName + "\" to:", columnName))
            {
                if (message.ShowDialog() == DialogResult.OK)
                {

                    this.tableInformationList[tableIndex].renameColumn(columnIndex, message.renameValue);
                    this.ColumnsCreatePanelListView.Items[columnIndex] = message.renameValue;

                }
            }
        }

        private void setDataGridColumns(List<DataGridViewColumn> columns)
        {
            this.TableDataGridView.Columns.Clear();
            foreach (DataGridViewColumn column in columns)
            {
                this.TableDataGridView.Columns.Add(column);
            }
        }

        private void setDataGridRows(List<DataGridViewRow> rows)
        {
            this.TableDataGridView.Rows.Clear();
            foreach (DataGridViewRow row in rows)
            {
                this.TableDataGridView.Rows.Add(row);
            }
        }




        private void refreshTable()
        {
            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;
            if (currentIndex >= 0)
            {
                setDataGridColumns(this.tableInformationList[currentIndex]._columns);
                setDataGridRows(this.tableInformationList[currentIndex]._rows);
            }
            else
            {
                this.TableDataGridView.Rows.Clear();
                this.TableDataGridView.Columns.Clear();
            }
        }

        private void addTable(string tableName)
        {
            CoverageInformation table = new CoverageInformation(tableName);
            this.tableInformationList.Add(table);
            addExistingTable(table);
        }

        private void addExistingTable(CoverageInformation table)
        {
            addToTableListBox(table);
        }

        private void removeTable(int index)
        {
            this.tableInformationList.RemoveAt(index);
            deleteTableFromTableListBox(index);
        }



        private void addColumnToCurrentTable(int tableIndex, string columnName)
        {
            this.tableInformationList[tableIndex].addColumn(columnName);
            addToColumnsListBox(columnName);
        }

        private void removeColumn(int tableIndex, int columnIndex)
        {
            this.tableInformationList[tableIndex].removeColumn(columnIndex);
            deleteColumnFromTableListBox(columnIndex);
        }

        #endregion



        #region UIUpdates
        private void addToTableListBox(CoverageInformation coverageToAdd)
        {
            this.TableCreatePanelListBox.Items.Add(coverageToAdd);
            this.TableDataViewSelectorBox.Items.Add(coverageToAdd);
        }
        private void deleteTableFromTableListBox(int index)
        {
            this.TableCreatePanelListBox.Items.RemoveAt(index);
            this.TableDataViewSelectorBox.Items.RemoveAt(index);
        }


        private void clearColumnsListBox()
        {
            this.ColumnsCreatePanelListView.Items.Clear();
        }

        private void populateColumnsListBox(List<DataGridViewColumn> columns)
        {
            clearColumnsListBox();
            foreach (DataGridViewColumn column in columns)
            {
                this.ColumnsCreatePanelListView.Items.Add(column.Name);
            }

        }

        private void addToColumnsListBox(string coverageToAdd)
        {
            this.ColumnsCreatePanelListView.Items.Add(coverageToAdd);
        }
        private void deleteColumnFromTableListBox(int index)
        {
            this.ColumnsCreatePanelListView.Items.RemoveAt(index);
        }



        private void clearCarrierInformation()
        {
            this.CarrierRichTextBox.Text = "";

        }
        private void refreshCarrierInformation(string carrierInformation)
        {
            this.CarrierRichTextBox.Text = carrierInformation;
        }
        #endregion




        private bool yesNoMessageBoxConfirmation(string message)
        {
            return MessageBox.Show(message, "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void PolicyCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // we know the file we are saving to and do not need to ask for a file
                if (checkIfFileCanBeSavedTo(this.openedPath))
                {
                    save(this.openedPath, this.openedPathFileName);
                }
                else
                {
                    // We can't find a file to save to run the saveAs();
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
        }
    }


}