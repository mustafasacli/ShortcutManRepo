using KisayolYoneticisi.Source.BO;
using KisayolYoneticisi.Source.Util;
using System;
using System.Collections.Generic;
using System.IO;

namespace KisayolYoneticisi.Source.OpManager
{
    internal class ExportManager
    {
        internal static bool ExportToFile(List<Kisayol> list, string saveFile)
        {
            bool result = false;

            try
            {
                //KisayolAdi
                //Yol
                using (StreamWriter sWriter = new StreamWriter(new FileStream(saveFile, FileMode.OpenOrCreate)) { AutoFlush = true })
                {
                    // sWriter.AutoFlush = true;
                    sWriter.Write("{0}\t", "KisayolAdi");
                    sWriter.Write("{0}\t", "Yol");
                    sWriter.Write("\n");

                    foreach (Kisayol k in list)
                    {
                        sWriter.Write("{0}\t", ObjectUtility.ToStr(k.KisayolAdi).Replace("\n", " "));
                        sWriter.Write("{0}\t", ObjectUtility.ToStr(k.Yol).Replace("\n", " "));
                        sWriter.Write("\n");
                    }
                }
                result = true;
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        internal static bool ExportToExcel(List<Kisayol> list, string fileName)
        {
            bool result = false;
            try
            {
                using (System.IO.StreamWriter excelDoc = new System.IO.StreamWriter(fileName))
                {
                    List<string> cols = new List<string>() { "KisayolAdi", "Yol" };
                    const string startExcelXML = "<xml version>\r\n<Workbook " +
                          "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                          " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                          "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                          "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                          "office:spreadsheet\">\r\n <Styles>\r\n " +
                          "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                          "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                          "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                          "\r\n <Protection/>\r\n </Style>\r\n " +
                          "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                          "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                          "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                          " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                          "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                          "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                          "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                          "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                          "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                          "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                          "</Styles>\r\n ";
                    const string endExcelXML = "</Workbook>";

                    int rowCount = 0;
                    int sheetCount = 1;
                    excelDoc.Write(startExcelXML);
                    excelDoc.Write("<Worksheet ss:Name=\"Shortcut" + sheetCount + "\">");
                    excelDoc.Write("<Table>");
                    excelDoc.Write("<Row>");
                    for (int x = 0; x < cols.Count; x++)
                    {
                        excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                        excelDoc.Write(cols[x]);
                        excelDoc.Write("</Data></Cell>");
                    }
                    excelDoc.Write("</Row>");
                    string XMLstring;
                    foreach (Kisayol x in list)
                    {
                        rowCount++;
                        //if the number of rows is > 64000 create a new page to continue output
                        if (rowCount == 64000)
                        {
                            rowCount = 0;
                            sheetCount++;
                            excelDoc.Write("</Table>");
                            excelDoc.Write(" </Worksheet>");
                            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                            excelDoc.Write("<Table>");
                        }
                        excelDoc.Write("<Row>"); //ID=" + rowCount + "

                        XMLstring = string.Empty;
                        XMLstring = x.KisayolAdi;
                        XMLstring = XMLstring.Trim();
                        XMLstring = XMLstring.Replace("&", "&");
                        XMLstring = XMLstring.Replace(">", ">");
                        XMLstring = XMLstring.Replace("<", "<");
                        excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                       "<Data ss:Type=\"String\">");
                        excelDoc.Write(XMLstring);
                        excelDoc.Write("</Data></Cell>");

                        XMLstring = string.Empty;
                        XMLstring = x.Yol;
                        XMLstring = XMLstring.Trim();
                        XMLstring = XMLstring.Replace("&", "&");
                        XMLstring = XMLstring.Replace(">", ">");
                        XMLstring = XMLstring.Replace("<", "<");
                        excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                       "<Data ss:Type=\"String\">");
                        excelDoc.Write(XMLstring);
                        excelDoc.Write("</Data></Cell>");

                        excelDoc.Write("</Row>");
                    }

                    excelDoc.Write("</Table>");
                    excelDoc.Write(" </Worksheet>");
                    excelDoc.Write(endExcelXML);
                    excelDoc.Close();
                }
                result = true;
            }
            catch (Exception)
            {
                result = false;
                throw;
            }

            return result;
        }
    }
}