using DocumentFormat.OpenXml.Packaging;
using InsuranceSummaryMaker.ConvertToDoc;
using InsuranceSummaryMaker.CustomControls.CustomMessageBox;
using InsuranceSummaryMaker.PolicyInformation;
using InsuranceSummaryMaker.Serialization;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private businessImage img = null;

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
            this.KeyProvisionsDataView.RowTemplate.MinimumHeight = 75;

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
                    return;
                }


                if (this.tabControl1.SelectedTab.Tag.Equals("keyProvisions"))
                {
                    refreshKeyProvisions();
                    return;
                }


            }



        }


        // FIX THIS TO ADD KEY PROVISIONS
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
                    BusinessInformation business = getBusinessInformation();

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
            if (currentIndex >= 0 && currentIndex < this.addons.Count)
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
                //MessageBox.Show("Please select an appendicy.");
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
            // conver to business image
            businessImage image = this.img;


            return new BusinessInformation(businessName, businessLegalName, businessStart, businessEnd, img);
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
            this.businessPictureBox.Image = business._image.getImageFromBytes();
            this.img = business._image;

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
            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
            {
                // there is a selected index
                if (!yesNoMessageBoxConfirmation("Are you sure you want to delete table: " + this.tableInformationList[currentIndex]._tableName)) { return; }
                removeTable(currentIndex);
                clearCarrierInformation();
                clearColumnsListBox();
            }
            else
            {
                //MessageBox.Show("There is no table selected.");
            }
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
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
                //MessageBox.Show("No table is selected.");
            }
        }

        private void DeleteColumnButton_Click_1(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int columnIndex = this.ColumnsCreatePanelListView.SelectedIndex;


            if (tableIndex >= 0 && tableIndex < this.tableInformationList.Count && columnIndex >= 0 && columnIndex < this.tableInformationList[tableIndex]._columns.Count)
            {


                if (!yesNoMessageBoxConfirmation("Are you sure you want to delete column: " + this.tableInformationList[tableIndex].getColumnNameAtIndex(columnIndex))) { return; }


                removeColumn(tableIndex, columnIndex);



            }
            else
            {
                //MessageBox.Show("No column is selected.");
            }
        }

        private void TableCreatePanelListBox_SelectedValueChanged(object sender, EventArgs e)
        {


            int changeIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (changeIndex >= 0 && changeIndex < this.tableInformationList.Count)
            {
                populateColumnsListBox(this.tableInformationList[changeIndex].getDataGridColumns());
                refreshCarrierInformation(this.tableInformationList[changeIndex]._carrierInformation);
            }
        }

        private void CarrierRichTextBox_Validated(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            if (tableIndex >= 0 && tableIndex < this.tableInformationList.Count)
            {
                this.tableInformationList[tableIndex]._carrierInformation = this.CarrierRichTextBox.Text;
            }
        }

        // test
        private void TableDataViewSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
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

            // swap on the data grid view combo box
            comboItem = this.KeyProvisionsDataViewSelectorBox.Items[toTableIndex];
            this.KeyProvisionsDataViewSelectorBox.Items.RemoveAt(toTableIndex);
            this.KeyProvisionsDataViewSelectorBox.Items.Insert(fromTableIndex, item);
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
            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;

            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
            {

                this.tableInformationList[currentIndex].setNewTable(this.TableDataGridView);
            }
        }

        private void startProvisionSave()
        {
            int currentIndex = this.KeyProvisionsDataViewSelectorBox.SelectedIndex;

            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
            {
                this.tableInformationList[currentIndex].setNewProvisions(this.KeyProvisionsDataView);
            }
        }

        private void endTableEditMode()
        {

            if (this.TableDataGridView.IsCurrentCellInEditMode)
            {

                this.TableDataGridView.EndEdit();

            }

            if (this.KeyProvisionsDataView.IsCurrentCellInEditMode)
            {
                this.KeyProvisionsDataView.EndEdit();
            }
        }


        private bool checkRowEmpty(DataGridViewRow row)
        {
            bool isRowEmpty = true;

            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell == null || cell.Value == null)
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    isRowEmpty = false;
                    break;
                }
            }

            return isRowEmpty;
        }
        private void TableDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= this.TableDataGridView.Rows.Count - 1) return;
            bool isEmpty = checkRowEmpty(this.TableDataGridView.Rows[rowIndex]);
            if (isEmpty)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.TableDataGridView.Rows.RemoveAt(rowIndex);
                    startSave();

                }));

            }
            else
            {
                startSave();
            }
        }
        private void KeyProvisionsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            startProvisionSave();

            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= this.KeyProvisionsDataView.Rows.Count - 1) return;
            bool isEmpty = checkRowEmpty(this.KeyProvisionsDataView.Rows[rowIndex]);
            if (isEmpty)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.KeyProvisionsDataView.Rows.RemoveAt(rowIndex);
                    startProvisionSave();

                }));

            }
            else
            {
                startProvisionSave();
            }
        }

        private void renameTableButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableCreatePanelListBox.SelectedIndex;


            if (currentIndex < 0 || currentIndex >= this.tableInformationList.Count)
            {
                //MessageBox.Show("Please select a table.");
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
                    this.KeyProvisionsDataViewSelectorBox.Items[currentIndex] = message.renameValue;
                }
            }
        }

        private void renameColumnButton_Click(object sender, EventArgs e)
        {
            int tableIndex = this.TableCreatePanelListBox.SelectedIndex;
            int columnIndex = this.ColumnsCreatePanelListView.SelectedIndex;

            if (tableIndex < 0 || tableIndex >= this.tableInformationList.Count)
            {
                //MessageBox.Show("Please select a table.");
                return;
            }

            if (columnIndex < 0 || columnIndex >= this.tableInformationList[tableIndex]._columns.Count)
            {
                //MessageBox.Show("Please select a column");
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
        #region helper functions
        private void setDataGridColumns(List<DataGridViewColumn> columns)
        {
            foreach (DataGridViewColumn column in columns)
            {
                this.TableDataGridView.Columns.Add(column);
            }
        }

        private void setDataGridRows(List<DataGridViewRow> rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                this.TableDataGridView.Rows.Add(row);
            }
        }


        private void setKeyProvisionsColumns(List<DataGridViewColumn> columns)
        {
            foreach (DataGridViewColumn column in columns)
            {
                this.KeyProvisionsDataView.Columns.Add(column);
            }
        }

        private void setKeyProvisionRows(List<DataGridViewRow> rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                this.KeyProvisionsDataView.Rows.Add(row);
            }
        }




        private void refreshTable()
        {
            this.TableDataGridView.Rows.Clear();
            this.TableDataGridView.Columns.Clear();

            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;
            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
            {
                setDataGridColumns(this.tableInformationList[currentIndex].getDataGridColumns());
                setDataGridRows(this.tableInformationList[currentIndex].getDataGridRows());
            }

        }

        private void refreshKeyProvisions()
        {
            this.KeyProvisionsDataView.Rows.Clear();
            this.KeyProvisionsDataView.Columns.Clear();

            int currentIndex = this.KeyProvisionsDataViewSelectorBox.SelectedIndex;
            if (currentIndex >= 0 && currentIndex < this.tableInformationList.Count)
            {

                setKeyProvisionsColumns(this.tableInformationList[currentIndex].getDataGridColumns());
                setKeyProvisionRows(this.tableInformationList[currentIndex].getDataGridViewKeyProvisions());
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

        private void swapRows(int tableIndex, int fromRow, int toRow, bool keyProvisions)
        {
            if (tableIndex < 0 || tableIndex >= this.tableInformationList.Count) { return; }
            if (keyProvisions)
            {
                if (fromRow < 0 || fromRow >= this.tableInformationList[tableIndex]._keyProvisions.Count) { return; }
                if (toRow < 0 || toRow >= this.tableInformationList[tableIndex]._keyProvisions.Count) { return; }
            }
            else
            {
                if (fromRow < 0 || fromRow >= this.tableInformationList[tableIndex]._rows.Count) { return; }
                if (toRow < 0 || toRow >= this.tableInformationList[tableIndex]._rows.Count) { return; }
            }

            if (keyProvisions)
            {
                this.tableInformationList[tableIndex].swapKeyProvisionRow(fromRow, toRow);

                int column = this.KeyProvisionsDataView.CurrentCell.ColumnIndex;
                for(int index = 0; index < this.KeyProvisionsDataView.Rows[fromRow].Cells.Count; index++)
                {
                    string value = "";
                    if(this.KeyProvisionsDataView.Rows[fromRow].Cells[index].Value != null)
                    {
                        value = this.KeyProvisionsDataView.Rows[fromRow].Cells[index].Value.ToString();
                    }

                    this.KeyProvisionsDataView.Rows[fromRow].Cells[index].Value = this.KeyProvisionsDataView.Rows[toRow].Cells[index].Value;
                    this.KeyProvisionsDataView.Rows[toRow].Cells[index].Value = value;


                }
                this.KeyProvisionsDataView.CurrentCell = this.KeyProvisionsDataView[column, toRow];
            }
            else
            {
                this.tableInformationList[tableIndex].swapRow(fromRow, toRow);

                int column = this.TableDataGridView.CurrentCell.ColumnIndex;

                for (int index = 0; index < this.TableDataGridView.Rows[fromRow].Cells.Count; index++)
                {
                    string value = "";
                    if (this.TableDataGridView.Rows[fromRow].Cells[index].Value != null)
                    {
                        value = this.TableDataGridView.Rows[fromRow].Cells[index].Value.ToString();
                    }

                    this.TableDataGridView.Rows[fromRow].Cells[index].Value = this.TableDataGridView.Rows[toRow].Cells[index].Value;
                    this.TableDataGridView.Rows[toRow].Cells[index].Value = value;


                }
                this.TableDataGridView.CurrentCell = this.TableDataGridView[column, toRow];
            }


        }
        #endregion

        #region keyProvisions
        private void KeyProvisionsDataViewSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshKeyProvisions();
        }

        private void KeyProvisionsDataViewUp_Click(object sender, EventArgs e)
        {
            int currentIndex = this.KeyProvisionsDataViewSelectorBox.SelectedIndex;
            if (currentIndex < 0 || currentIndex >= this.tableInformationList.Count)
            {
                return;
            }
            if (this.KeyProvisionsDataView.SelectedCells.Count <= 0) { return; }

            int fromRow = this.KeyProvisionsDataView.SelectedCells[0].RowIndex;
            int toRow = fromRow - 1;
            swapRows(currentIndex, fromRow, toRow, true);
        }

        private void KeyProvisionsDataViewDown_Click(object sender, EventArgs e)
        {
            int currentIndex = this.KeyProvisionsDataViewSelectorBox.SelectedIndex;
            if (currentIndex < 0 || currentIndex >= this.tableInformationList.Count)
            {
                return;
            }
            if(this.KeyProvisionsDataView.SelectedCells.Count <= 0) { return; }
            int fromRow = this.KeyProvisionsDataView.SelectedCells[0].RowIndex;
            int toRow = fromRow + 1;
            swapRows(currentIndex, fromRow, toRow, true);
        }
        #endregion

        #region addons
        private void AppendiciesUpButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.appendiciesLabelBox.SelectedIndex;
            int toIndex = selectedIndex - 1;
            swapAppendicies(selectedIndex, toIndex);
        }

        private void AppendiciesDownButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.appendiciesLabelBox.SelectedIndex;
            int toIndex = selectedIndex + 1;
            swapAppendicies(selectedIndex, toIndex);
        }
        #endregion

        #region table Data

        private void RowMoveUpButton_Click(object sender, EventArgs e)
        {
            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;
            if (currentIndex < 0 || currentIndex >= this.tableInformationList.Count)
            {
                return;
            }
            if (this.TableDataGridView.SelectedCells.Count <= 0) { return; }

            int fromRow = this.TableDataGridView.SelectedCells[0].RowIndex;
            int toRow = fromRow - 1;
            swapRows(currentIndex, fromRow, toRow, false);
        }

        private void RowMoveDownButton_Click(object sender, EventArgs e)
        {

            int currentIndex = this.TableDataViewSelectorBox.SelectedIndex;
            if (currentIndex < 0 || currentIndex >= this.tableInformationList.Count)
            {
                return;
            }
            if (this.TableDataGridView.SelectedCells.Count <= 0) { return; }

            int fromRow = this.TableDataGridView.SelectedCells[0].RowIndex;
            int toRow = fromRow + 1;
            swapRows(currentIndex, fromRow, toRow, false);
        }
        #endregion
        #endregion



        #region UIUpdates
        private void addToTableListBox(CoverageInformation coverageToAdd)
        {
            this.TableCreatePanelListBox.Items.Add(coverageToAdd);
            this.TableDataViewSelectorBox.Items.Add(coverageToAdd);
            this.KeyProvisionsDataViewSelectorBox.Items.Add(coverageToAdd);

        }
        private void deleteTableFromTableListBox(int index)
        {
            this.TableCreatePanelListBox.Items.RemoveAt(index);
            this.TableDataViewSelectorBox.Items.RemoveAt(index);
            this.KeyProvisionsDataViewSelectorBox.Items.RemoveAt(index);

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

        private void swapAppendicies(int fromAppendiciesIndex, int toAppendiciesIndex)
        {
            if (fromAppendiciesIndex < 0 || fromAppendiciesIndex >= this.addons.Count) { return; }
            if (toAppendiciesIndex < 0 || toAppendiciesIndex >= this.addons.Count) { return; }

            //swap the addons in the list

            AppendFile tempTable = this.addons[fromAppendiciesIndex];
            this.addons[fromAppendiciesIndex] = this.addons[toAppendiciesIndex];
            this.addons[toAppendiciesIndex] = tempTable;

            //swap in the list View
            var item = this.appendiciesLabelBox.Items[toAppendiciesIndex];
            this.appendiciesLabelBox.Items.RemoveAt(toAppendiciesIndex);
            this.appendiciesLabelBox.Items.Insert(fromAppendiciesIndex, item);
        }
        #endregion




        private bool yesNoMessageBoxConfirmation(string message)
        {
            return MessageBox.Show(message, "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void PolicyCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mb = MessageBox.Show("Do you want to save?", "Save?", MessageBoxButtons.YesNoCancel);
            if (mb == DialogResult.Yes)
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
            else if (mb == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void PolicyCreator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }





        private void BrowseImageLocation_Click(object sender, EventArgs e)
        {
            if (this.openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = this.openImageDialog.FileName;
                ImagePartType type = businessImage.getPathImageType(imagePath);

                Image importImage = Image.FromFile(imagePath);
                this.businessPictureBox.Image = importImage;

                // convert to byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    importImage.Save(ms, importImage.RawFormat);
                    imageBytes = ms.ToArray();
                }
                this.img = new businessImage(imageBytes, importImage.Width, importImage.Height, type);

            }
        }

        private void BusinessStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = this.BusinessStartDate.Value;
            start = start.AddYears(1);

            this.BusinessEndDate.Value = start;
        }
    }


}
