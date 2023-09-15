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

        public List<string> _columns { get; private set; }
        public List<List<string>> _rows { get; private set; }
        public List<List<string>> _keyProvisions { get; private set; }


        public CoverageInformation(string tableName)
        {

            this._columns = new List<string>();
            this._rows = new List<List<string>>();
            this._keyProvisions = new List<List<string>>();

            this._tableName = tableName;
            this._carrierInformation = "";
        }

        public CoverageInformation(JToken json)
        {

            this._tableName = json["_tableName"] + "";
            this._carrierInformation = json["_carrierInformation"] + "";

            this._rows = new List<List<string>>();
            this._columns = new List<string>();
            this._keyProvisions = new List<List<string>>();

            // sort out the jarray column names
            extractColumnNamesFromJson((JArray)json["_columns"]);

            // sort out the jarray rows
            extractRowNamesFromJson((JArray)json["_rows"], (JArray)json["_keyProvisions"]);

        }

        public void swapColumn(int index1, int index2)
        {
            if (index1 < 0 || index2 < 0 || index1 >= _columns.Count || index2 >= _columns.Count)
                return;

            string column1 = this._columns[index1];

            // put column2 in the index1 place
            this._columns[index1] = this._columns[index2];

            // put column1 in the index2 place
            this._columns[index2] = column1;




            foreach (List<string> row in this._rows)
            {
                //swap the rows data
                string cell1 = row[index1];


                row[index1] = row[index2];
                row[index2] = cell1;

            }

            foreach (List<string> row in this._keyProvisions)
            {
                //swap the rows data
                string cell1 = row[index1];


                row[index1] = row[index2];
                row[index2] = cell1;
            }
        }


        public void swapRow(int from, int to)
        {
            if (from < 0 || from >= _rows.Count) return;
            if (to < 0 || to >= _rows.Count) return;

            for (int fromCounter = 0; fromCounter < _rows[from].Count(); fromCounter++)
            {
                string temp = _rows[from][fromCounter];

                _rows[from][fromCounter] = _rows[to][fromCounter];
                _rows[to][fromCounter] = temp;
            }

        }
        
        public void swapKeyProvisionRow(int from, int to)
        {
            if (from < 0 || from >= _keyProvisions.Count) return;
            if (to < 0 || to >= _keyProvisions.Count) return;

            for (int fromCounter = 0; fromCounter < _keyProvisions[from].Count(); fromCounter++)
            {
                string temp = _keyProvisions[from][fromCounter];

                _keyProvisions[from][fromCounter] = _keyProvisions[to][fromCounter];
                _keyProvisions[to][fromCounter] = temp;
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
                List<string> createdRow = new List<string>();
                foreach (string value in row)
                {
                    createdRow.Add(value ?? "");
                }

                this._rows.Add(createdRow);
            }

            foreach (JArray row in keyProvisions)
            {
                List<string> createdRow = new List<string>();
                foreach (string value in row)
                {
                    createdRow.Add(value ?? "");
                }

                this._keyProvisions.Add(createdRow);
            }
        }


        public void setNewTable(DataGridView table)
        {
            this._rows.Clear();

            for (int counter = 0; counter < table.Rows.Count - 1; counter++)
            {
                List<string> nRow = new List<string>();
                foreach (DataGridViewCell cells in table.Rows[counter].Cells)
                {
                    string value = "";
                    if(cells != null && cells.Value != null)
                    {
                        value = cells.Value.ToString();
                    }
                    nRow.Add(value);
                }
                this._rows.Add(nRow);
            }

        }



        public void setNewProvisions(DataGridView provisions)
        {

            this._keyProvisions.Clear();
            for (int counter = 0; counter < provisions.Rows.Count - 1; counter++)
            {
                List<string> nRow = new List<string>();
                foreach (DataGridViewCell cells in provisions.Rows[counter].Cells)
                {
                    string value = "";
                    if (cells != null && cells.Value != null)
                    {
                        value = cells.Value.ToString();
                    }
                    nRow.Add(value);
                }
                this._keyProvisions.Add(nRow);
            }
        }

        public void addColumn(string columnHeader)
        {


            this._columns.Add(columnHeader);



            foreach(List<string> row in this._rows)
            {
                row.Add("");
            }
            foreach (List<string> row in this._keyProvisions)
            {
                row.Add("");
            }
        }

        public void removeColumn(int index)
        {
            this._columns.RemoveAt(index);
            //remove all the column data from the rows
            for (int counter = this._rows.Count-1; counter >= 0; counter--)
            {
                this._rows[counter].RemoveAt(index);
                if (this._rows[counter].Count <= 0)
                {
                    this._rows.RemoveAt(counter);
                }
            }

            // remove cells in key provisions
            for (int counter = this._keyProvisions.Count - 1; counter >= 0; counter--)
            {
                this._keyProvisions[counter].RemoveAt(index);
                if (this._keyProvisions[counter].Count <= 0)
                {
                    this._keyProvisions.RemoveAt(counter);
                }
            }
        }


        public List<DataGridViewRow> getDataGridRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();


            foreach(List<string> rowsList in this._rows)
            {
                DataGridViewRow row = new DataGridViewRow();

                foreach(string value in rowsList)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = value;
                    row.Cells.Add(cell);
                    
                }
                row.MinimumHeight = 75;
                rows.Add(row);
            }


            return rows;
        }


        public List<DataGridViewRow> getDataGridViewKeyProvisions()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();


            foreach (List<string> rowsList in this._keyProvisions)
            {
                DataGridViewRow row = new DataGridViewRow();

                foreach (string value in rowsList)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = value;
                    row.Cells.Add(cell);

                }
                row.MinimumHeight = 75;
                rows.Add(row);
            }


            return rows;
        }

        public List<DataGridViewColumn> getDataGridColumns()
        {
            List<DataGridViewColumn> columns = new List<DataGridViewColumn>();

            foreach(string name in this._columns)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.Name = name;
                column.HeaderText = name;
                column.MinimumWidth = 200;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.Add(column);
            }

            return columns;
        }


        

        public void renameColumn(int index, string name)
        {
            this._columns[index] = name;
        }

        public string getColumnNameAtIndex(int index)
        {
            return this._columns[index];
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
            dict.Add("_columns", this._columns);
            dict.Add("_rows", this._rows);
            dict.Add("_keyProvisions", this._keyProvisions);
            return dict;
        }


       
    }
}
