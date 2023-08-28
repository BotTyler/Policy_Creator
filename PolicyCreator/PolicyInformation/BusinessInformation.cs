using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace InsuranceSummaryMaker.PolicyInformation
{
    internal class BusinessInformation
    {
        public string _name { get; }
        public string _legalName { get; }
        public DateTime _start { get; set; }
        public DateTime _end { get; set; }



        public BusinessInformation(string name, string legalName, DateTime start, DateTime end)
        {
            this._name = name;
            this._legalName = legalName;
            this._start = start;
            this._end = end;
        }

        public BusinessInformation(JToken json)
        {
            this._name = json["_name"] + "";
            this._legalName = json["_legalName"] + "";
            this._start = DateTime.Parse(json["_start"] + "");
            this._end = DateTime.Parse(json["_end"] + "");
        }

        public string getFormattedStartDate()
        {
            return _start.ToLongDateString();
        }

        public string getFormattedEndDate()
        {
            return _end.ToLongDateString();
        }

        public override string ToString()
        {
            return string.Format("Name:\n{0}\n\nLegal Name:\n{1}\n\nStart Date:\n{2}\n\nExpiration Date:\n{3}", this._name, this._legalName, getFormattedStartDate(), getFormattedEndDate());
        }

        public Dictionary<string, object> Serialize()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("_name", _name);
            dict.Add("_legalName", _legalName);
            dict.Add("_start", _start);
            dict.Add("_end", _end);
            return dict;
        }
    }
}
