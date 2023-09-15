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
using Style = DocumentFormat.OpenXml.Wordprocessing.Style;
using Color = System.Drawing.Color;

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
            //MessageBox.Show("File saved at: " + exportPath);
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
                CreateAllTables(tableList, paragraph, mainPart.StyleDefinitionsPart);
            }
            replaceTagWithElement(startTables, new Text(""), mainPart);



        }
        private static uint staticAddonId = 0;
        private static void InsertAddons(List<AppendFile> addons, MainDocumentPart mainPart)
        {
            ConvertToDocument.staticAddonId = GetMaxDocPropertyId(mainPart);
            // find the paragraph with the addons text
            if (addons == null || addons.Count <= 0)
            {
                replaceTagWithElement(startAdds, new Text(""), mainPart);
                return;
            }

            List<Paragraph> paragraphs = findLowestParagraphsWithTag(startAdds, mainPart);


            foreach (Paragraph paragraph in paragraphs)
            {
                for (int index = addons.Count -1; index >= 0; index--)
                {

                    AppendFile currentFile = addons[index];

                    List<OpenXmlElement> content = SetupAddonPage(currentFile.document);
                    if (content == null)
                    {
                        continue;
                    }

                    for (int counter = content.Count - 1; counter >= 0; counter--)
                    {
                        OpenXmlElement currentParagraph = content[counter];
                        changeAllElementID(currentParagraph);

                        //uint maxInt = GetMaxDocPropertyId(mainPart);

                        paragraph.InsertAfterSelf(currentParagraph);
                    }
                    if (index > 0)
                    {
                        Paragraph pageBreak = CreatePageBreak();
                        paragraph.InsertAfterSelf(pageBreak);
                    }


                }
            }

            replaceTagWithElement(startAdds, new Text(""), mainPart);


        }

        private static void changeAllElementID(OpenXmlElement paragraph)
        {

            foreach (OpenXmlAttribute attribute in paragraph.GetAttributes())
            {
                if (attribute.LocalName.ToLower().Equals("id"))
                {
                    if (!attribute.Value.Equals("0"))
                    {

                        var newAttribute = new OpenXmlAttribute(attribute.LocalName, attribute.NamespaceUri, ++ConvertToDocument.staticAddonId + "");
                        //element.RemoveAttribute(attribute.LocalName, attribute.NamespaceUri);
                        paragraph.SetAttribute(newAttribute);
                    }

                }
            }
            if (paragraph.HasChildren)
            {
                foreach (OpenXmlElement child in paragraph.Elements())
                {
                    changeAllElementID(child);
                }
            }


        }


        private static List<OpenXmlElement> SetupAddonPage(Body document)
        {

            List<OpenXmlElement> pageParagraphs = new List<OpenXmlElement>();
            foreach (OpenXmlElement paragraph in document.Elements())
            {

                if (paragraph.LocalName.ToLower().Equals("sectpr"))
                {
                    continue;
                }
                pageParagraphs.Add((OpenXmlElement)paragraph.Clone());

            }

            return pageParagraphs;
        }

        private static void Export(WordprocessingDocument document)
        {
            document.Save();
        }



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
        private static Paragraph CreateTextBox(string text, StyleDefinitionsPart stylePart)
        {


            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "50%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow row = new TableRow();
            row.Append(CreateCell(text, 1, true, false, true, stylePart));

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


            uint max = GetMaxDocPropertyId(document.MainDocumentPart); // gets the max id
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
        private static void CreateAllTables(List<CoverageInformation> tableList, Paragraph para, StyleDefinitionsPart stylePart)
        {
            Paragraph lastPageBreak = null;

            for (int index = tableList.Count - 1; index >= 0; index--)
            {
                CoverageInformation currentTable = tableList[index];

                List<string> columns = currentTable._columns;
                List<List<string>> rows = currentTable._rows;
                List<List<string>> keyProvisions = currentTable._keyProvisions;

                if (columns == null || rows == null || keyProvisions == null || (columns.Count <= 0 && rows.Count <= 0 && keyProvisions.Count <= 0))
                {
                    if (index == 0)
                    {
                        //we are at the last index
                        if (lastPageBreak != null)
                        {
                            lastPageBreak.Remove();
                        }
                    }
                    continue;
                }
                Paragraph title = CreateParagraph(currentTable._tableName);
                Paragraph carriers = CreateTextBox(currentTable._carrierInformation, stylePart);
                Paragraph table = CreateTable(columns, rows, keyProvisions, stylePart);

                //Paragraph x = new Paragraph(new Run(table));

                para.InsertAfterSelf(table);
                if (currentTable._carrierInformation != null && !currentTable._carrierInformation.Equals(""))
                    para.InsertAfterSelf(carriers);
                para.InsertAfterSelf(title);

                if (index > 0)
                {
                    Paragraph pageBreak = CreatePageBreak();
                    lastPageBreak = pageBreak;
                    para.InsertAfterSelf(pageBreak);
                }


            }
        }


        // method to create a table
        private static Paragraph CreateTable(List<string> column, List<List<string>> row, List<List<string>> keyProvisions, StyleDefinitionsPart stylePart)
        {
            TableProperties prop = new TableProperties();
            prop.TableStyle = new TableStyle() { Val = "TableGrid" };
            prop.TableWidth = new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct };
            prop.TableJustification = new TableJustification { Val = TableRowAlignmentValues.Center };
            prop.TableLayout = new TableLayout { Type = TableLayoutValues.Fixed };


            Table table = new Table(prop);


            TableRow headerRow = CreateColumnRow(column, stylePart);
            table.Append(headerRow);


            foreach (List<string> x in row)
            {
                table.Append(CreateRow(x, stylePart));
            }

            if (keyProvisions.Count > 0)
            {
                // add the row that acts like a header but has only Key Properties on it
                table.Append(CreateMergeRow("Key Provisions:", keyProvisions[0].Count, stylePart));

                // add each of the provisions
                foreach (List<string> x in keyProvisions)
                {
                    table.Append(CreateRow(x, stylePart));
                }
            }

            Paragraph paragraph = new Paragraph(new ParagraphProperties(new Justification { Val = JustificationValues.Center }));
            Run run = new Run(table);
            paragraph.Append(run);

            return paragraph;

        }

        // method to create a row in word for the column headers
        private static TableRow CreateColumnRow(List<string> input, StyleDefinitionsPart stylePart)
        {
            TableRow row = new TableRow();
            foreach (string column in input)
            {
                row.Append(CreateCell(column, 1, true, true, false, stylePart));
            }

            return row;
        }


        // creates a word table row for a given row in the dataset
        private static TableRow CreateRow(List<string> input, StyleDefinitionsPart stylePart)
        {
            TableRow row = new TableRow();
            foreach (string cell in input)
            {
                row.Append(CreateCell(cell, 1, false, false, false, stylePart));
            }

            return row;
        }
        private static TableRow CreateMergeRow(string text, int columnWidth, StyleDefinitionsPart stylePart)
        {
            TableRow row = new TableRow();
            row.Append(CreateCell(text ?? "", columnWidth, false, true, true, stylePart));


            return row;
        }

        private static Shading getTableFirstRowShading(string styleID, StyleDefinitionsPart stylePart, string opacity)
        {


            try
            {
                Style tableGridStyle = stylePart.Styles.Elements<Style>().FirstOrDefault(style => style.StyleId.Equals(styleID));
                foreach(TableStyleProperties prop in tableGridStyle.Descendants<TableStyleProperties>())
                {
                    if (prop.Type.InnerText.Equals("firstRow"))
                    {
                        TableStyleConditionalFormattingTableCellProperties cellProp = prop.Elements<TableStyleConditionalFormattingTableCellProperties>().FirstOrDefault();
                        Shading cellShading = (Shading)cellProp.Shading.Clone();

                        //cellShading.Fill = ConvertColorToLighterColor(cellShading.Fill, 0.2f);
                        
                        //cellShading.ThemeFillShade = "80";
                        cellShading.ThemeFillTint = opacity;
                        return cellShading;
                        
                    }
                }

                throw new Exception("NOT FOUND");

            }
            catch (Exception ex)
            {
                Shading defaultShading = new Shading()
                {
                    Val = ShadingPatternValues.Clear,
                    Color = "auto", // You can specify a color here, e.g., "auto", "FF0000" (hex color code), etc.
                    Fill = "lightgrey", // Use the color name or a known color value
                };
                return defaultShading;
            }
            





        }
        private static string ConvertColorToLighterColor(string hex, float lightenFactor)
        {
            Color color = ColorTranslator.FromHtml("#"+hex);
            
            // Adjust the color by the lightenFactor (e.g., 0.2 for 20% lighter).
            int r = (int)Math.Min(255, color.R + (255 - color.R) * lightenFactor);
            int g = (int)Math.Min(255, color.G + (255 - color.G) * lightenFactor);
            int b = (int)Math.Min(255, color.B + (255 - color.B) * lightenFactor);

            Color lightenedColor = Color.FromArgb(r, g, b);
            string lightenColor = ColorTranslator.ToHtml(lightenedColor);
            return lightenColor.Substring(1);
        }

        // method to create a cell in a table
        private static TableCell CreateCell(string text, int columnWidth, bool wantCenter, bool bold, bool isKeyProvision, StyleDefinitionsPart stylePart)
        {
            TableCell cell = new TableCell();
            TableCellProperties tcprop = new TableCellProperties();

            TableCellWidth cellWidth = new TableCellWidth() { Type = TableWidthUnitValues.Auto };
            tcprop.Append(cellWidth);
            if (isKeyProvision)
            {
                //TableCellProperties tcprop = new TableCellProperties();
                Shading shade = getTableFirstRowShading("TableGrid", stylePart, "40");


                TableCellMargin cellMargin = new TableCellMargin()
                {
                    TopMargin = new TopMargin() { Width = "100", Type = TableWidthUnitValues.Dxa },
                    BottomMargin = new BottomMargin() { Width = "100", Type = TableWidthUnitValues.Dxa },
                };
                tcprop.Shading = shade;
                tcprop.TableCellMargin = cellMargin;

                //tcprop.tablec
                //cell.Append(tcprop);
            }
            cell.Append(tcprop);

            Paragraph p = new Paragraph();
            ParagraphProperties pProps = new ParagraphProperties();
            if (wantCenter)
            {
                pProps.Append(new Justification { Val = JustificationValues.Center });
            }


            p.Append(pProps);
            cell.Append(new GridSpan { Val = columnWidth });

            string[] split = text.Split('\n');
            for (int index = 0; index < split.Length; index++)
            {
                string current = split[index];
                Run run = new Run();


                if (bold)
                {
                    RunProperties runProp = new RunProperties();
                    runProp.AppendChild(new Bold());
                    run.RunProperties = runProp;
                }

                Text insertText = new Text(current);
                run.AppendChild(insertText);


                if (index < split.Length - 1)
                {
                    run.AppendChild(new Break());
                }

                p.Append(run);
            }

            cell.Append(p);

            return cell;
        }

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

        private static uint GetMaxDocPropertyId(MainDocumentPart doc)
        {
            return doc
               .RootElement
               .Descendants<DocProperties>()
               .Max(x => (uint?)x.Id) ?? 0;
        }
        #endregion
    }

}
