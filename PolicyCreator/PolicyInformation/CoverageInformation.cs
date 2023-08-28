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

        public CoverageInformation(string tableName)
        {
            this._columns = new List<DataGridViewColumn>();
            this._rows = new List<DataGridViewRow>();
            this._tableName = tableName;
            this._carrierInformation = "";
        }

        public CoverageInformation(JToken json)
        {

            this._tableName = json["_tableName"] + "";
            this._carrierInformation = json["_carrierInformation"] + "";
            this._columns = new List<DataGridViewColumn>();
            this._rows = new List<DataGridViewRow>();

            // sort out the jarray column names
            extractColumnNamesFromJson((JArray)json["_columns"]);

            // sort out the jarray rows
            extractRowNamesFromJson((JArray)json["_rows"]);

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


            foreach (DataGridViewRow row in this._rows)
            {
                //swap the rows data
                string temp = row.Cells[index1].Value + "";
                row.Cells[index1].Value = row.Cells[index2].Value;
                row.Cells[index2].Value = temp;

            }

        }


        private void extractColumnNamesFromJson(JArray columns)
        {
            foreach (string name in columns)
            {
                addColumn(name ?? "");
            }
        }

        private void extractRowNamesFromJson(JArray rows)
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
        }


        public void setNewTable(DataGridView table)
        {
            this._rows.Clear();

            for (int counter = 0; counter < table.Rows.Count - 1; counter++)
            {
                this._rows.Add(table.Rows[counter]);

            }



        }

        public void addColumn(string columnHeader)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = columnHeader;
            column.HeaderText = columnHeader;
            column.MinimumWidth = 200;
            this._columns.Add(column);
        }

        public void removeColumn(int index)
        {
            this._columns.RemoveAt(index);
            //remove all the column data from the rows
            for (int counter = 0; counter < this._rows.Count; counter++)
            {
                this._rows[counter].Cells.RemoveAt(index);
            }
        }

        public void renameColumn(int index, string name)
        {
            this._columns[index].Name = name;
            this._columns[index].HeaderText = name;
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
    }
}
