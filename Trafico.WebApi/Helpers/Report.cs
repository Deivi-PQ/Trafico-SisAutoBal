using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;

namespace Trafico.WebApi.Helpers
{
    public class Report
    {
        public JsonResult Procesar_Reporte_Json(Dictionary<string, DataTable> liDatos, string NombreReporte,
            Dictionary<string, string> parameters, String Tipo)
        {
            try
            {
                ExportFormat idTipo = GetFormato(Tipo);
                if (idTipo != ExportFormat.CSV)
                {
                    string mimeType = "";
                    int extension = 1;

                    // --- Ruta del reporte
                    string rutaReporte = Path.Combine(Directory.GetCurrentDirectory(), "Reports", NombreReporte);
                    // rutaReporte = rutaReporte.Replace("wwwroot\\", "");

                    // --- Para que permita caracteres especiales
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    LocalReport localRep = new LocalReport();

                    // --- Agregando parámetros
                    IList<ReportParameter> reportParameters = new List<ReportParameter>();
                    foreach (var param in parameters)
                    {
                        reportParameters.Add(new ReportParameter(param.Key, param.Value));
                    }

                    using var fs = new FileStream(rutaReporte, FileMode.Open, FileAccess.Read);

                    localRep.LoadReportDefinition(fs);

                    // --- Agregando datos
                    foreach (var oDatos in liDatos)
                    {
                        localRep.DataSources.Add(new ReportDataSource(oDatos.Key, oDatos.Value));
                    }

                    localRep.SetParameters(reportParameters);

                    //return File(pdf, "application/msexcel", "report." + ".xlsx");

                    if (idTipo == ExportFormat.PDF)
                    {
                        var file = localRep.Render("PDF");
                        return new JsonResult(new { file = Convert.ToBase64String(file) });
                    }
                    else if (idTipo == ExportFormat.PDFExport)
                    {
                        var file = localRep.Render("PDF");
                        return new JsonResult(new { file = Convert.ToBase64String(file) });
                    }
                    else if (idTipo == ExportFormat.Excel)
                    {
                        var file = localRep.Render("EXCELOPENXML");
                        return new JsonResult(new { file = Convert.ToBase64String(file) });
                    }
                    else if (idTipo == ExportFormat.Word)
                    {
                        var file = localRep.Render("WORDOPENXML");
                        return new JsonResult(new { file = Convert.ToBase64String(file) });
                    }
                }
                else // Formato CSV
                {
                    // --- Exportar a CSV
                    LibreriaBSNetCore.CExportaExcel oExporta = new LibreriaBSNetCore.CExportaExcel("Web");

                    DataTable dtDatos = liDatos.First().Value;

                    string Rpta = oExporta.ExportarDatos(dtDatos, LibreriaBSNetCore.CExportaExcel.ExportFormat.CSV, "");

                    return new JsonResult(new { file = Rpta });
                }

                return null;
                //return new JsonResult(new { file = "" });
            }
            catch (Exception ex)
            {
                LibreriaBSNetCore.Exceptions.Logger.Fatal(ex);
                // -- Retorna la misma vista
                throw ex;
                //return View();
            }
        }
        public enum ExportFormat : int { PDF = 1, Excel = 2, Word = 3, Image = 4, CSV = 5, PDFExport = 6 };

        public static ExportFormat GetFormato(string Tipo)
        {
            if (Tipo == null)
                Tipo = "PDF";

            if (Tipo.ToUpper() == "PDF")
                return ExportFormat.PDF;
            else if (Tipo.ToUpper() == "EXCEL")
                return ExportFormat.Excel;
            else if (Tipo.ToUpper() == "WORD")
                return ExportFormat.Word;
            else if (Tipo.ToUpper() == "IMAGE")
                return ExportFormat.Image;
            else if (Tipo.ToUpper() == "CSV")
                return ExportFormat.CSV;
            else if (Tipo.ToUpper() == "PDFEXPORT")
                return ExportFormat.PDFExport;
            else
                return ExportFormat.PDF;
        }
    }
}