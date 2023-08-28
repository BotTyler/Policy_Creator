using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace InsuranceSummaryMaker.PolicyInformation
{
    internal class AgentInformation
    {
        public string _agentName { get; }
        public string _agentPosition { get; }
        public string _agentEmail { get; }
        public string _agentNumber { get; }
        public string _agentWebsite { get; }
        public string _agentBusiness { get; }

        public AgentInformation(string name, string position, string email, string number, string website, string business)
        {
            this._agentName = name;
            this._agentPosition = position;
            this._agentEmail = email;
            this._agentNumber = number;
            this._agentWebsite = website;
            this._agentBusiness = business;
        }

        public AgentInformation(JToken json)
        {
            this._agentName = json["_agentName"] + "";
            this._agentPosition = json["_agentPosition"] + "";
            this._agentEmail = json["_agentEmail"] + "";
            this._agentNumber = json["_agentNumber"] + "";
            this._agentWebsite = json["_agentWebsite"] + "";
            this._agentBusiness = json["_agentBusiness"] + "";

        }

        public override string ToString()
        {
            return string.Format("Name:\n{0}\n\nPosition:\n{1}\n\nEmail:\n{2}\n\nNumber:\n{3}\n\nWebsitte:\n{4}\n\nBusiness:\n{5}", this._agentName, this._agentPosition, this._agentEmail, this._agentNumber, this._agentWebsite, this._agentBusiness);
        }

        public Dictionary<string, object> Serialize()
        {

            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("_agentName", _agentName);
            dict.Add("_agentPosition", _agentPosition);
            dict.Add("_agentEmail", _agentEmail);
            dict.Add("_agentNumber", _agentNumber);
            dict.Add("_agentWebsite", _agentWebsite);
            dict.Add("_agentBusiness", _agentBusiness);
            return dict;
        }
    }
}
