using DocumentFormat.OpenXml.Office2016.Excel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.PolicyInformation
{
    internal class CoverageInformation
    {
        public string _tableName { get; set; }

        public string _carrierInformation { get; set; }
        public List<DataGridViewColumn> _columns { get; }
        public List<DataGridViewRow> _rows { get; }

        public List<DataGridViewColumn> _keyProvisionColumns { get; }
        public List<DataGridViewRow> _keyProvisions { get; }

        public CoverageInformation(string tableName)
        {
            this._columns = new List<DataGridViewColumn>();
            this._rows = new List<DataGridViewRow>();

            this._keyProvisionColumns = new List<DataGridViewColumn>();
            this._keyProvisions = new List<DataGridViewRow>();

            this._tableName = tableName;
            this._carrierInformation = "";
        }

        public CoverageInformation(JToken json)
        {

            this._tableName = json["_tableName"] + "";
            this._carrierInformation = json["_carrierInformation"] + "";
            this._columns = new List<DataGridViewColumn>();


            this._rows = new List<DataGridViewRow>();
            this._columns = new List<DataGridViewColumn>();


            this._keyProvisionColumns = new List<DataGridViewColumn>();
            this._keyProvisions = new List<DataGridViewRow>();

            // sort out the jarray column names
            extractColumnNamesFromJson((JArray)json["_columns"]);

            // sort out the jarray rows
            extractRowNamesFromJson((JArray)json["_rows"], (JArray)json["_keyProvisions"]);

        }

        public void swapColumn(int index1, int index2)
        {
            if (index1 < 0 || index2 < 0 || index1 >= _columns.Count || index2 >= _columns.Count)
                return;

            string column1 = this._columns[index1].Name;

            string column2 = this._columns[index2].Name;


            // put column2 in the index1 place
            this._columns[index1].Name = column2;
            this._columns[index1].HeaderText = column2;

            // put column1 in the index2 place
            this._columns[index2].Name = column1;
            this._columns[index2].HeaderText = column1;


            // put column2 in the index1 place
            this._keyProvisionColumns[index1].Name = column2;
            this._keyProvisionColumns[index1].HeaderText = column2;

            // put column1 in the index2 place
            this._keyProvisionColumns[index2].Name = column1;
            this._keyProvisionColumns[index2].HeaderText = column1;


            foreach (DataGridViewRow row in this._rows)
            {
                //swap the rows data
                string cell1 = row.Cells[index1].Value + "";
                string cell2 = row.Cells[index2].Value + "";


                row.Cells[index1].Value = cell2;
                row.Cells[index2].Value = cell1;

            }
            foreach(DataGridViewRow row in this._keyProvisions)
            {
                //swap the rows data
                string cell1 = row.Cells[index1].Value + "";
                string cell2 = row.Cells[index2].Value + "";


                row.Cells[index1].Value = cell2;
                row.Cells[index2].Value = cell1;
            }
        }


        public void swapRow(int from, int to)
        {
            if (from < 0 || from >= _rows.Count) return;
            if (to < 0 || to >= _rows.Count) return;

            for (int fromCounter = 0; fromCounter < _rows[from].Cells.Count; fromCounter++)
            {
                string temp = (_rows[from].Cells[fromCounter].Value ?? "") + "";

                _rows[from].Cells[fromCounter].Value = (_rows[to].Cells[fromCounter].Value ?? "") + "";
                _rows[to].Cells[fromCounter].Value = temp;
            }

        }

        public void swapKeyProvisionRow(int from, int to)
        {
            if (from < 0 || from >= _keyProvisions.Count) return;
            if (to < 0 || to >= _keyProvisions.Count) return;

            for (int fromCounter = 0; fromCounter < _keyProvisions[from].Cells.Count; fromCounter++)
            {
                string temp = (_keyProvisions[from].Cells[fromCounter].Value ?? "") + "";

                _keyProvisions[from].Cells[fromCounter].Value = (_keyProvisions[to].Cells[fromCounter].Value ?? "") + "";
                _keyProvisions[to].Cells[fromCounter].Value = temp;
            }

        }

        private void extractColumnNamesFromJson(JArray columns)
        {
            foreach (string name in columns)
            {
                addColumn(name ?? "");
            }
        }

        private void extractRowNamesFromJson(JArray rows, JArray keyProvisions)
        {
            foreach (JArray row in rows)
            {
                DataGridViewRow createdRow = new DataGridViewRow();
                foreach (string value in row)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = value ?? "";
                    createdRow.Cells.Add(cell);
                }

                createdRow.MinimumHeight = 75;
                this._rows.Add(createdRow);
            }

            foreach (JArray row in keyProvisions)
            {
                DataGridViewRow createdRow = new DataGridViewRow();
                foreach (string value in row)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = value ?? "";
                    createdRow.Cells.Add(cell);
                }

                createdRow.MinimumHeight = 75;
                this._keyProvisions.Add(createdRow);
            }
        }


        public void setNewTable(DataGridView table)
        {
            this._rows.Clear();

            for (int counter = 0; counter < table.Rows.Count - 1; counter++)
            {
                this._rows.Add(table.Rows[counter]);

            }




        }

        public void setNewProvisions(DataGridView provisions)
        {

            this._keyProvisions.Clear();
            for (int counter = 0; counter < provisions.Rows.Count - 1; counter++)
            {
                this._keyProvisions.Add(provisions.Rows[counter]);

            }
        }

        public void addColumn(string columnHeader)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = columnHeader;
            column.HeaderText = columnHeader;
            column.MinimumWidth = 200;
            this._columns.Add((DataGridViewColumn)column.Clone());
            this._keyProvisionColumns.Add((DataGridViewColumn)column.Clone());
        }

        public void removeColumn(int index)
        {
            this._columns.RemoveAt(index);
            this._keyProvisionColumns.RemoveAt(index);
            //remove all the column data from the rows
            for (int counter = 0; counter < this._rows.Count; counter++)
            {
                this._rows[counter].Cells.RemoveAt(index);
            }

            // remove cells in key provisions
            for(int counter = 0; counter < this._keyProvisions.Count; counter++)
            {
                this._keyProvisions[counter].Cells.RemoveAt(index);
            }
        }

        public void renameColumn(int index, string name)
        {
            this._columns[index].Name = name;
            this._columns[index].HeaderText = name;

            this._keyProvisionColumns[index].Name = name;
            this._keyProvisionColumns[index].HeaderText = name;
        }

        public string getColumnNameAtIndex(int index)
        {
            return this._columns[index].Name;
        }


        public override string ToString()
        {
            return this._tableName;
        }


        public Dictionary<string, object> Serialize()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("_tableName", _tableName);
            dict.Add("_carrierInformation", _carrierInformation);
            dict.Add("_columns", getColumnArray());
            dict.Add("_rows", getRowArray());
            dict.Add("_keyProvisions", getKeyProvisionsArray());
            return dict;
        }


        private List<string> getColumnArray()
        {
            List<string> columns = new List<string>();

            foreach (DataGridViewColumn col in this._columns)
            {
                columns.Add(col.Name);
            }


            return columns;
        }

        private List<List<string>> getRowArray()
        {
            List<List<string>> rows = new List<List<string>>();

            foreach (DataGridViewRow row in this._rows)
            {
                List<string> currentRow = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string val = "";
                    if (cell.Value != null)
                    {
                        val = cell.Value.ToString() ?? "";
                    }

                    currentRow.Add(val);

                }
                rows.Add(currentRow);
            }


            return rows;
        }

        private List<List<string>> getKeyProvisionsArray()
        {
            List<List<string>> rows = new List<List<string>>();

            foreach (DataGridViewRow row in this._keyProvisions)
            {
                List<string> currentRow = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string val = "";
                    if (cell != null &&  cell.Value != null)
                    {
                        val = cell.Value.ToString() ?? "";
                    }

                    currentRow.Add(val);

                }
                rows.Add(currentRow);
            }


            return rows;
        }
    }
}
