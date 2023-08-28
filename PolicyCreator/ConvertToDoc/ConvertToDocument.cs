using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using InsuranceSummaryMaker.PolicyInformation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Break = DocumentFormat.OpenXml.Wordprocessing.Break;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using TableCell = DocumentFormat.OpenXml.Wordprocessing.TableCell;
using TableProperties = DocumentFormat.OpenXml.Wordprocessing.TableProperties;
using TableRow = DocumentFormat.OpenXml.Wordprocessing.TableRow;
using TableStyle = DocumentFormat.OpenXml.Wordprocessing.TableStyle;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace InsuranceSummaryMaker.ConvertToDoc
{
    /**
     * Main Purpose for this class is to take a bunch of fields and populate a Word Document Template
     * 
     * This Template needs to contain the tags listed as Readonly strings. 
     * (Note: the document does not need to contain all the tags only the ones that are needed. In addition, tags that are present in the document but not as a field will be represented by "")
     */
    internal class ConvertToDocument
    {

        private readonly static string startTables = "<<tables>>";


        private readonly static string startAdds = "<<addons>>";

        #region agent Information tags
        private readonly static string agentNameTag = "<<agentname>>";
        private readonly static string agentPositionTag = "<<agentposition>>";
        private readonly static string agentEmailTag = "<<agentemail>>";
        private readonly static string agentNumberTag = "<<agentnumber>>";
        private readonly static string agentWebsiteTag = "<<agentwebsite>>";
        private readonly static string agentBusinessTag = "<<agentbusiness>>";
        #endregion

        #region business Information tags
        private readonly static string businessNameTag = "<<businessname>>";
        private readonly static string businessLegalNameTag = "<<businesslegalname>>";
        private readonly static string businessStartDateTag = "<<businessstart>>";
        private readonly static string businessEndDateTag = "<<businessend>>";

        #endregion





        /**
         * Starts the exporting process to a word document
         * 
         */
        public static void StartExport(string templatePath, string exportPath, List<CoverageInformation> tablesToInsert, AgentInformation agent, BusinessInformation business, List<AppendFile> addons)
        {
            //check to make sure all file locations are valid
            // open the template
            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Cannot find the template.");
                return;
            }
            if (string.Equals(templatePath, exportPath, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("File already exist.");
                return;
            }
            using (WordprocessingDocument template = WordprocessingDocument.Open(templatePath, true))
            {
                using (WordprocessingDocument document = (WordprocessingDocument)template.Clone(exportPath))
                {
                    if (!CheckDocumentReady(document) && !CheckDocumentReady(template)) { return; }

                    // Insert Agent Info
                    InsertAgentInformation(agent, document);

                    // Insert the businessInformation
                    InsertBusinessInformation(business, document);

                    // insert the tables
                    InsertTables(tablesToInsert, document);

                    // insert any Appendacies
                    InsertAddons(addons, document);


                    //Export
                    Export(document);
                }

            }
            MessageBox.Show("File saved at: " + exportPath);



        }

        // Find and rplaces all tags with the given agent information
        private static void InsertAgentInformation(AgentInformation agent, WordprocessingDocument document)
        {
            ReplaceTag(agentNameTag, agent._agentName, document);
            ReplaceTag(agentPositionTag, agent._agentPosition, document);
            ReplaceTag(agentEmailTag, agent._agentEmail, document);
            ReplaceTag(agentNumberTag, agent._agentNumber, document);
            ReplaceTag(agentWebsiteTag, agent._agentWebsite, document);
            ReplaceTag(agentBusinessTag, agent._agentBusiness, document);

        }




        // finds and replaces all tags with the given business information
        private static void InsertBusinessInformation(BusinessInformation business, WordprocessingDocument document)
        {
            ReplaceTag(businessNameTag, business._name, document);
            ReplaceTag(businessLegalNameTag, business._legalName, document);
            ReplaceTag(businessStartDateTag, business.getFormattedStartDate(), document);
            ReplaceTag(businessEndDateTag, business.getFormattedStartDate().ToString(), document);
        }


        // finds and replaces the tables tag with bunch of pages of tables
        private static void InsertTables(List<CoverageInformation> tableList, WordprocessingDocument document)
        {

            MainDocumentPart mainPart = document.MainDocumentPart;


            Paragraph paragraph = FindTag(mainPart, startTables);
            if (paragraph == null)
            {
                return;
            }
            CreateAllTables(tableList, paragraph);

        }



        #region export
        // saves the current document
        private static void Export(WordprocessingDocument document)
        {
            document.Save();
        }

        #endregion

        #region table Creation
        // creates and inserts the table page informmation
        private static void CreateAllTables(List<CoverageInformation> tableList, Paragraph para)
        {


            for (int index = tableList.Count - 1; index >= 0; index--)
            {
                CoverageInformation currentTable = tableList[index];

                List<DataGridViewColumn> columns = currentTable._columns;
                List<DataGridViewRow> rows = currentTable._rows;

                if ((columns == null || rows == null) || columns.Count <= 0 || rows.Count <= 0)
                {
                    continue;
                }
                Paragraph title = CreateParagraph(currentTable._tableName);
                Paragraph carriers = CreateTextBox(currentTable._carrierInformation);
                Paragraph table = CreateTable(columns, rows);

                //Paragraph x = new Paragraph(new Run(table));

                para.InsertAfterSelf(table);
                para.InsertAfterSelf(carriers);
                para.InsertAfterSelf(title);

                if (index > 0)
                {
                    Paragraph pageBreak = CreatePageBreak();
                    para.InsertAfterSelf(pageBreak);
                }


            }
        }


        // method to create a table
        private static Paragraph CreateTable(List<DataGridViewColumn> column, List<DataGridViewRow> row)
        {
            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "70%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow headerRow = CreateRow(column);
            table.Append(headerRow);


            foreach (DataGridViewRow x in row)
            {
                table.Append(CreateRow(x));
            }

            Paragraph paragraph = new Paragraph(new ParagraphProperties(new Justification { Val = JustificationValues.Center }));
            Run run = new Run(table);
            paragraph.Append(run);

            return paragraph;

        }

        // method to create a row in word for the column headers
        private static TableRow CreateRow(List<DataGridViewColumn> input)
        {
            TableRow row = new TableRow();
            foreach (DataGridViewColumn column in input)
            {
                string columnName = column.Name;
                row.Append(CreateCell(columnName));
            }

            return row;
        }


        // creates a word table row for a given row in the dataset
        private static TableRow CreateRow(DataGridViewRow input)
        {
            TableRow row = new TableRow();
            foreach (DataGridViewCell cell in input.Cells)
            {

                string cellValue = "";

                if (cell.Value != null)
                {
                    cellValue = cell.Value.ToString() ?? "";
                }




                row.Append(CreateCell(cellValue));
            }

            return row;
        }


        // method to create a cell in a table
        private static TableCell CreateCell(string text)
        {
            TableCell cell = new TableCell();
            Paragraph p = new Paragraph();


            string[] split = text.Split('\n');
            for (int index = 0; index < split.Length; index++)
            {
                string current = split[index];
                Run run = new Run(new Text(current));




                if (index < split.Length - 1)
                {
                    run.AppendChild(new Break());
                }

                p.Append(run);
            }

            cell.Append(p);

            return cell;
            //return new TableCell(new Paragraph(new Run(new Text(text))));
        }
        #endregion

        #region tag replacement
        // metthod to find a tag present in a document
        // method will return the paragraph or null if it could not find it.
        private static Paragraph FindTag(MainDocumentPart doc, string tag)
        {
            foreach (Paragraph paragraphs in doc.Document.Descendants<Paragraph>())
            {
                foreach (Text text in paragraphs.Descendants<Text>())
                {
                    if (text.Text.Contains(tag))
                    {
                        text.Text = text.Text.Replace(tag, "");
                        return paragraphs;
                    }
                }
            }

            return null;
        }

        // finds and replaces a tag within a word document
        private static void ReplaceTag(string tag, string item, WordprocessingDocument document)
        {

            MainDocumentPart mainPart = document.MainDocumentPart;

            foreach (Paragraph paragraph in mainPart.Document.Body.Descendants<Paragraph>())
            {
                Run runToReplace = FindRunWithTag(tag, paragraph);


                if (runToReplace != null)
                {
                    // found the run that we need
                    ReplaceRunWithText(tag, item, runToReplace);
                }

            }
        }

        // method to find a run given a specific tag within a document
        private static Run FindRunWithTag(string tag, Paragraph paragraph)
        {
            foreach (Run run in paragraph.Descendants<Run>())
            {
                if (run.InnerText.Contains(tag))
                {
                    return run;
                }
            }

            return null;
        }


        // create and replace a tag with a run
        private static void ReplaceRunWithText(string tag, string replacementText, Run run)
        {
            foreach (Paragraph paragraph in run.Descendants<Paragraph>())
            {
                if (paragraph.InnerText.Contains(tag))
                {

                    string text = "";
                    foreach (Run r in paragraph.Descendants<Run>())
                    {
                        foreach (Text t in r.Descendants<Text>())
                        {
                            text += t.Text.ToString();

                        }
                    }

                    Run first = paragraph.GetFirstChild<Run>() ?? new Run();
                    Text firstText = first.GetFirstChild<Text>() ?? new Text();

                    firstText.Text = text.Replace(tag, replacementText);

                    paragraph.RemoveAllChildren<Run>();
                    paragraph.Append(first);

                }
            }
        }

        // method to create a page break paragraph
        private static Paragraph CreatePageBreak()
        {
            return new Paragraph(new Run(new Break() { Type = BreakValues.Page }));
        }


        // creates a paragraph
        private static Paragraph CreateParagraph(string text)
        {

            Paragraph paragraph = new Paragraph(new Run(new Text(text)));
            ParagraphProperties paragraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = "Title" });
            paragraph.ParagraphProperties = paragraphProperties;

            return paragraph;
        }
        #endregion

        #region textBox creation
        private static Paragraph CreateTextBox(string text)
        {


            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "50%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow row = new TableRow();
            row.Append(CreateCell(text));

            table.Append(row);

            Paragraph paragraph = new Paragraph(new ParagraphProperties(new Justification { Val = JustificationValues.Center }));

            Run run = new Run(table);

            paragraph.Append(run);



            return paragraph;
        }

        #endregion

        #region addons

        private static void InsertAddons(List<AppendFile> addons, WordprocessingDocument document)
        {
            // find the paragraph with the addons text
            MainDocumentPart mainPart = document.MainDocumentPart;

            Paragraph paragraph = FindTag(mainPart, startAdds);
            if (paragraph == null)
            {
                return;
            }


            for (int index = 0; index < addons.Count; index++)
            {

                AppendFile currentFile = addons[index];

                List<Paragraph> content = SetupAddonPage(currentFile.document);
                if (content == null)
                {
                    continue;
                }

                for (int counter = content.Count - 1; counter >= 0; counter--)
                {
                    Paragraph currentParagraph = content[counter];
                    paragraph.InsertAfterSelf(currentParagraph);
                }
                if (index < addons.Count - 1)
                {
                    Paragraph pageBreak = CreatePageBreak();
                    paragraph.InsertAfterSelf(pageBreak);
                }


            }
        }

        private static List<Paragraph> SetupAddonPage(Body document)
        {

            List<Paragraph> pageParagraphs = new List<Paragraph>();
            foreach (Paragraph paragraph in document.Descendants<Paragraph>())
            {

                pageParagraphs.Add((Paragraph)paragraph.Clone());

            }

            return pageParagraphs;
        }

        #endregion

        #region helper functions

        private static bool CheckDocumentReady(WordprocessingDocument document)
        {
            if (document == null || document.MainDocumentPart == null || document.MainDocumentPart.Document == null || document.MainDocumentPart.Document.Body == null)
            {
                return false;
            }
            return true;
        }
        #endregion
    }

}
