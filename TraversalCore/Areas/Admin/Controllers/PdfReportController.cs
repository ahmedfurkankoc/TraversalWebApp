using Microsoft.AspNetCore.Mvc;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string fileName = "dosya1.pdf";
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "PdfReports"); // PdfReports klasörünün yolunu al
            string filePath = Path.Combine(folderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);

                document.Open();

                Paragraph paragraph = new Paragraph("Traversal Rezervasyon Raporu");
                document.Add(paragraph);

                document.Close();
            }

            var fileStream = new FileStream(filePath, FileMode.Open);
            return File(fileStream, "application/pdf", fileName);
        }

        public IActionResult StaticCustomerReport()
        {
            string fileName = "dosya2.pdf";
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "PdfReports"); // PdfReports klasörünün yolunu al
            string filePath = Path.Combine(folderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);

                document.Open();

                PdfPTable pdfPTable = new PdfPTable(3);
                pdfPTable.AddCell("Katılımcı Adı");
                pdfPTable.AddCell("Katılımcı Soyadı");
                pdfPTable.AddCell("Katılımcı TC");

                pdfPTable.AddCell("Eylül");
                pdfPTable.AddCell("Sezer");
                pdfPTable.AddCell("123456789001");

                pdfPTable.AddCell("Kemal");
                pdfPTable.AddCell("Yıldırım");
                pdfPTable.AddCell("22222222222");

                pdfPTable.AddCell("Mehmet");
                pdfPTable.AddCell("Asar");
                pdfPTable.AddCell("11111111111");

                document.Add(pdfPTable);

                document.Close();
            }

            var fileStream = new FileStream(filePath, FileMode.Open);
            return File(fileStream, "application/pdf", fileName);
        }

    }
}
