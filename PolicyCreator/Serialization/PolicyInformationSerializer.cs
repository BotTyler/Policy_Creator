using InsuranceSummaryMaker.PolicyInformation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InsuranceSummaryMaker.Serialization
{
    internal class PolicyInformationSerializer
    {
        public static readonly string fileExtension = ".jjipc";
        private static readonly string versionNumber = "1.0.0";

        public static void StartExport(AgentInformation agent, BusinessInformation business, List<CoverageInformation> coverages, List<AppendFile> addons, string exportPath)
        {
            Dictionary<string, object> agentInformation = serializeAgent(agent);
            Dictionary<string, object> businessInformation = serializeBusiness(business);
            List<Dictionary<string, object>> coverageInformation = serializeCoverages(coverages);
            List<Dictionary<string, object>> addonInformation = serializeAddons(addons);



            string result = JsonConvert.SerializeObject(new
            {
                versionNumber = versionNumber,
                agentInformation = agentInformation,
                businessInformation = businessInformation,
                coverageInformation = coverageInformation,
                addonInformation = addonInformation
            }, Formatting.Indented);

            writeJsonOutput(exportPath, result);
            MessageBox.Show("Saved at path:\n\n" + exportPath);


        }

        private static Dictionary<string, object> serializeAgent(AgentInformation agent)
        {
            return agent.Serialize();
        }

        private static Dictionary<string, object> serializeBusiness(BusinessInformation business)
        {
            return business.Serialize();
        }

        private static List<Dictionary<string, object>> serializeCoverages(List<CoverageInformation> coverages)
        {
            List<Dictionary<string, object>> coveragesJsonList = new List<Dictionary<string, object>>();

            foreach (CoverageInformation coverage in coverages)
            {
                coveragesJsonList.Add(coverage.Serialize());
            }

            return coveragesJsonList;
        }

        private static List<Dictionary<string, object>> serializeAddons(List<AppendFile> addons)
        {
            List<Dictionary<string, object>> coveragesJsonList = new List<Dictionary<string, object>>();

            foreach (AppendFile addon in addons)
            {
                coveragesJsonList.Add(addon.Serialize());
            }

            return coveragesJsonList;
        }


        private static void writeJsonOutput(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }


        public static JObject openFile(string path)
        {
            string openFileJson = File.ReadAllText(path);
            JObject json = JObject.Parse(openFileJson);
            string versionNumber = json["versionNumber"].ToString();
            if (!checkVersionNumber(versionNumber))
            {
                json = convertDocument(json, versionNumber);
            }
            return json;
        }

        private static bool checkVersionNumber(string versionNumber)
        {
            if (PolicyInformationSerializer.versionNumber.Equals(versionNumber)) { return true; }
            return false;
        }

        private static JObject convertDocument(JObject json, string versionNumber)
        {
            switch (versionNumber)
            {
                case "1.0.0":
                    break;
                default:
                    MessageBox.Show("Could not convert Document");
                    Application.Exit();
                    Environment.Exit(1);
                    break;
            }

            return json;
        }
    }
}
