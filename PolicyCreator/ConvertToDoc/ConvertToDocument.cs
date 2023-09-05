using DocumentFormat.OpenXml;
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


using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using System.Drawing;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using System.Linq;
using System.Deployment.Application;
using DocumentFormat.OpenXml.Drawing;
using ParagraphProperties = DocumentFormat.OpenXml.Wordprocessing.ParagraphProperties;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using RunProperties = DocumentFormat.OpenXml.Wordprocessing.RunProperties;
using TableCellProperties = DocumentFormat.OpenXml.Wordprocessing.TableCellProperties;
using DocumentFormat.OpenXml.Math;
using Justification = DocumentFormat.OpenXml.Wordprocessing.Justification;
using JustificationValues = DocumentFormat.OpenXml.Wordprocessing.JustificationValues;

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
        private readonly static string businessPictureTag = "<<businesspicture>>";

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
                    InsertTables(tablesToInsert, document.MainDocumentPart);

                    // insert any Appendacies
                    InsertAddons(addons, document.MainDocumentPart);


                    //Export
                    Export(document);
                }

            }
            MessageBox.Show("File saved at: " + exportPath);
            System.Diagnostics.Process.Start(exportPath);




        }



        // Find and rplaces all tags with the given agent information
        private static void InsertAgentInformation(AgentInformation agent, WordprocessingDocument document)
        {
            replaceTagWithElement(agentNameTag, new Text(agent._agentName), document.MainDocumentPart);
            replaceTagWithElement(agentPositionTag, new Text(agent._agentPosition), document.MainDocumentPart);
            replaceTagWithElement(agentEmailTag, new Text(agent._agentEmail), document.MainDocumentPart);
            replaceTagWithElement(agentNumberTag, new Text(agent._agentNumber), document.MainDocumentPart);
            replaceTagWithElement(agentWebsiteTag, new Text(agent._agentWebsite), document.MainDocumentPart);
            replaceTagWithElement(agentBusinessTag, new Text(agent._agentBusiness), document.MainDocumentPart);

        }

        // finds and replaces all tags with the given business information
        private static void InsertBusinessInformation(BusinessInformation business, WordprocessingDocument document)
        {
            replaceTagWithElement(businessNameTag, new Text(business._name), document.MainDocumentPart);
            replaceTagWithElement(businessLegalNameTag, new Text(business._legalName), document.MainDocumentPart);
            replaceTagWithElement(businessStartDateTag, new Text(business.getFormattedStartDate()), document.MainDocumentPart);
            replaceTagWithElement(businessEndDateTag, new Text(business.getFormattedEndDate().ToString()), document.MainDocumentPart);


            Drawing image = createImageObject(document, business._image);

            if (image == null)
            {
                replaceTagWithElement(businessPictureTag, new Text(""), document.MainDocumentPart);
            }
            else
            {
                replaceTagWithElement(businessPictureTag, image, document.MainDocumentPart);

            }
        }

        private static void InsertTables(List<CoverageInformation> tableList, MainDocumentPart mainPart)
        {

            if (tableList == null || tableList.Count <= 0)
            {
                replaceTagWithElement(startTables, new Text(""), mainPart);
                return;
            }

            List<Paragraph> paragraphs = findLowestParagraphsWithTag(startTables, mainPart);

            foreach (Paragraph paragraph in paragraphs)
            {
                CreateAllTables(tableList, paragraph);
            }

        }

        private static void InsertAddons(List<AppendFile> addons, MainDocumentPart mainPart)
        {
            // find the paragraph with the addons text
            if (addons == null || addons.Count <= 0)
            {
                replaceTagWithElement(startAdds, new Text(""), mainPart);
                return;
            }

            List<Paragraph> paragraphs = findLowestParagraphsWithTag(startAdds, mainPart);


            foreach (Paragraph paragraph in paragraphs)
            {
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

        private static void Export(WordprocessingDocument document)
        {
            document.Save();
        }
        /*#region may delete

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
       
        #endregion


        public static void InsertPicture(string tag, byte[] image, float aspectRatio, imageTypes type, WordprocessingDocument document)
        {


            Drawing picture = createImageObject(document, image, type, aspectRatio);


            ReplaceTagWithImage(tag, picture, document);

        }



        


        

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
        #endregion*/


        #region find Tag Method
        private static List<Paragraph> findLowestParagraphsWithTag(string tag, MainDocumentPart mainPart)
        {
            string temp = "";
            List<Paragraph> listOfFoundParagraphs = new List<Paragraph>();
            foreach (Text p in mainPart.Document.Descendants<Text>())
            {
                temp += p.Text;
                if (temp.Contains(tag))
                {


                    Paragraph fullParahraph = (Paragraph)(p.Parent.Parent);
                    // may add some check to make sure this is a paragraph

                    listOfFoundParagraphs.Add(fullParahraph);

                    temp = "";

                }
            }

            return listOfFoundParagraphs;
        }

        private static void removeAllTextElementsFromParagraph(Paragraph p)
        {
            foreach (Text t in p.Descendants<Text>())
            {
                t.Remove();
            }
        }

        private static List<string> splitStringBasedOnTag(string innerText, string tag)
        {
            int start = innerText.IndexOf(tag);
            int end = start + tag.Length;

            List<string> list = new List<string>();
            list.Add(innerText.Substring(0, start));
            list.Add(innerText.Substring(start, tag.Length));
            list.Add(innerText.Substring(end));

            List<string> rList = new List<string>();
            foreach (string x in list)
            {
                if (!x.Equals(""))
                {
                    rList.Add(x);
                }
            }
            return rList;
        }


        private static void replaceTagWithElement(string tag, OpenXmlElement element, MainDocumentPart mainPart)
        {
            List<Paragraph> paragraphsWithTag = findLowestParagraphsWithTag(tag, mainPart);
            foreach (Paragraph p in paragraphsWithTag)
            {
                //MessageBox.Show("Replacing " + tag);
                string text = p.InnerText;
                removeAllTextElementsFromParagraph(p);
                List<string> splitParagraph = splitStringBasedOnTag(text, tag);
                foreach (string s in splitParagraph)
                {
                    Run insertRun = new Run();
                    RunProperties style = (RunProperties)p.Descendants<RunProperties>().FirstOrDefault();
                    if (style != null)
                    {
                        insertRun.Append(style.Clone() as RunProperties);
                    }
                    if (s.Equals(tag))
                    {
                        // replace tag with our element


                        insertRun.Append((OpenXmlElement)element.Clone());
                    }
                    else
                    {
                        Text t = new Text(s);
                        t.Space = SpaceProcessingModeValues.Preserve;
                        insertRun.Append(t);
                    }
                    p.Append(insertRun);
                }

            }
        }
        #endregion

        #region element Creation Functions
        private static Paragraph CreateTextBox(string text)
        {


            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "50%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow row = new TableRow();
            row.Append(CreateCell(text, 1, true, false));

            table.Append(row);

            Paragraph paragraph = new Paragraph(new ParagraphProperties(new Justification { Val = JustificationValues.Center }));

            Run run = new Run(table);

            paragraph.Append(run);



            return paragraph;
        }
        private static Paragraph CreatePageBreak()
        {
            return new Paragraph(new Run(new Break() { Type = BreakValues.Page }));
        }
        private static Paragraph CreateParagraph(string text)
        {

            Paragraph paragraph = new Paragraph(new Run(new Text(text)));
            ParagraphProperties paragraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = "Title" });
            paragraph.ParagraphProperties = paragraphProperties;

            return paragraph;
        }

        #region images
        private static Drawing createImageObject(WordprocessingDocument document, businessImage image)
        {
            if (image == null || image.isImageNull())
            {
                return null;
            }


            ImagePart imagePart;
            MainDocumentPart mainPart = document.MainDocumentPart;


            imagePart = mainPart.AddImagePart(image._imageType);




            using (MemoryStream stream = new MemoryStream(image._image))
            {
                imagePart.FeedData(stream);
            }


            uint max = GetMaxDocPropertyId(document); // gets the max id
            int maxWidth = 300;
            int maxHeight = 150;

            int height;
            int width;

            float aspectRatio = image._width / (float)image._height;

            // given the aspect ratio of the image calculate the size of the image that fits within the max sizes
            if ((int)(maxWidth * (1 / aspectRatio)) < maxHeight)//assume we are going to  use the width by default
            {
                width = maxWidth;
                height = (int)(maxWidth * (1 / aspectRatio));
            }
            else
            {
                height = maxHeight;
                width = (int)(maxHeight * aspectRatio);
            }

            //MessageBox.Show(width + " x " + height);
            Drawing picture = createImageElement(mainPart.GetIdOfPart(imagePart), max + 1, max + 2, width, height);
            return picture;
        }
        private static Drawing createImageElement(string relationshipId, uint guid1, uint guid2, int widthPx, int heightPx)
        {

            int conversionFactor = 9525;
            // Define the reference of the image.
            Drawing element =
                 new Drawing(
                     new DW.Inline(
                         new DW.Extent() { Cx = widthPx * conversionFactor, Cy = heightPx * conversionFactor },
                         new DW.EffectExtent()
                         {
                             LeftEdge = 0L,
                             TopEdge = 0L,
                             RightEdge = 0L,
                             BottomEdge = 0L
                         },
                         new DW.DocProperties()
                         {
                             Id = guid1,
                             Name = "Picture 1"
                         },
                         new DW.NonVisualGraphicFrameDrawingProperties(
                             new A.GraphicFrameLocks() { NoChangeAspect = true }),
                         new A.Graphic(
                             new A.GraphicData(
                                 new PIC.Picture(
                                     new PIC.NonVisualPictureProperties(
                                         new PIC.NonVisualDrawingProperties()
                                         {
                                             Id = guid2,
                                             Name = "New Bitmap Image.jpg"
                                         },
                                         new PIC.NonVisualPictureDrawingProperties()),
                                     new PIC.BlipFill(
                                         new A.Blip(
                                             new A.BlipExtensionList(
                                                 new A.BlipExtension()
                                                 {
                                                     Uri =
                                                        "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                                 })
                                         )
                                         {
                                             Embed = relationshipId,
                                             CompressionState =
                                             A.BlipCompressionValues.Print
                                         },
                                         new A.Stretch(
                                             new A.FillRectangle())),
                                     new PIC.ShapeProperties(
                                         new A.Transform2D(
                                             new A.Offset() { X = 0L, Y = 0L },
                                             new A.Extents() { Cx = widthPx * conversionFactor, Cy = heightPx * conversionFactor }),
                                         new A.PresetGeometry(
                                             new A.AdjustValueList()
                                         )
                                         { Preset = A.ShapeTypeValues.Rectangle }))
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                     )
                     {
                         DistanceFromTop = (UInt32Value)0U,
                         DistanceFromBottom = (UInt32Value)0U,
                         DistanceFromLeft = (UInt32Value)0U,
                         DistanceFromRight = (UInt32Value)0U,
                         EditId = "50D07946"
                     });

            // Append the reference to body, the element should be in a Run.
            //wordDoc.MainDocumentPart.Document.Body.AppendChild(new Paragraph(new Run(element)));
            return element;
        }
        #endregion

        #region tables
        private static void CreateAllTables(List<CoverageInformation> tableList, Paragraph para)
        {


            for (int index = tableList.Count - 1; index >= 0; index--)
            {
                CoverageInformation currentTable = tableList[index];

                List<DataGridViewColumn> columns = currentTable._columns;
                List<DataGridViewRow> rows = currentTable._rows;
                List<DataGridViewRow> keyProvisions = currentTable._keyProvisions;

                if ((columns == null || rows == null) || columns.Count <= 0 || rows.Count <= 0)
                {
                    continue;
                }
                Paragraph title = CreateParagraph(currentTable._tableName);
                Paragraph carriers = CreateTextBox(currentTable._carrierInformation);
                Paragraph table = CreateTable(columns, rows, keyProvisions);

                //Paragraph x = new Paragraph(new Run(table));

                para.InsertAfterSelf(table);
                if (currentTable._carrierInformation != null && !currentTable._carrierInformation.Equals(""))
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
        private static Paragraph CreateTable(List<DataGridViewColumn> column, List<DataGridViewRow> row, List<DataGridViewRow> keyProvisions)
        {
            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow headerRow = CreateRow(column);
            table.Append(headerRow);


            foreach (DataGridViewRow x in row)
            {
                table.Append(CreateRow(x));
            }

            if (keyProvisions.Count > 0)
            {
                // add the row that acts like a header but has only Key Properties on it
                table.Append(CreateMergeRow("Key Provisions:", keyProvisions[0].Cells.Count));

                // add each of the provisions
                foreach (DataGridViewRow x in keyProvisions)
                {
                    table.Append(CreateRow(x));
                }
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
                row.Append(CreateCell(columnName, 1, true, true));
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




                row.Append(CreateCell(cellValue, 1, false, false));
            }

            return row;
        }
        private static TableRow CreateMergeRow(string text, int columnWidth)
        {
            TableRow row = new TableRow();
            row.Append(CreateCell(text ?? "", columnWidth, true, true));


            return row;
        }


        // method to create a cell in a table
        private static TableCell CreateCell(string text, int columnWidth, bool wantSpacing, bool bold)
        {
            TableCell cell = new TableCell();
            Paragraph p = new Paragraph();
            ParagraphProperties pProps = new ParagraphProperties();
            if (wantSpacing)
            {
                pProps.Append(new Justification { Val = JustificationValues.Center });
            }


            p.Append(pProps);
            cell.Append(new GridSpan { Val = columnWidth });

            string[] split = text.Split('\n');
            for (int index = 0; index < split.Length; index++)
            {
                string current = split[index];

                Run run = new Run(new Text(current));
                if (bold)
                {
                    MessageBox.Show("BOLD");
                    RunProperties runProp = new RunProperties();
                    runProp.Append(new Bold());
                    run.RunProperties = runProp;
                }




                if (index < split.Length - 1)
                {
                    run.AppendChild(new Break());
                }

                p.Append(run);
            }

            cell.Append(p);

            return cell;
        }

        //meant for mergcells
/*        private static TableCell CreateCell(string text, int columnWidth)
        {
            TableCell cell = new TableCell();
            Paragraph p = new Paragraph();


            cell.Append(new GridSpan { Val = columnWidth });


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
        }*/
        #endregion
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

        private static uint GetMaxDocPropertyId(WordprocessingDocument doc)
        {
            return doc
               .MainDocumentPart
               .RootElement
               .Descendants<DocProperties>()
               .Max(x => (uint?)x.Id) ?? 0;
        }
        #endregion
    }

}
