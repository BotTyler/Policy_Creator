using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace InsuranceSummaryMaker.PolicyInformation
{
    internal class AppendFile
    {
        //public string path { get; }
        public string fileName { get; }

        public Body document { get; }
        public AppendFile(string path, string fileName)
        {
            this.fileName = fileName;

            using (WordprocessingDocument doc = WordprocessingDocument.Open(path, false))
            {
                if (doc.MainDocumentPart == null || doc.MainDocumentPart.Document == null || doc.MainDocumentPart.Document.Body == null)
                {
                    this.document = new Body();
                }
                else
                {
                    this.document = (Body)doc.MainDocumentPart.Document.Body.Clone();

                }
            }


        }

        public AppendFile(JToken json)
        {
            this.fileName = json["fileName"] + "";
            string outerXML = json["document"] + "";
            this.document = new Body(outerXML);
        }



        public Dictionary<string, object> Serialize()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("fileName", fileName);
            dict.Add("document", this.document.OuterXml);
            return dict;
        }

    }
}
