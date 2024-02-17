using BusinessLayer.Abstract;
using OfficeOpenXml;


namespace BusinessLayer.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> list) where T : class
        {
            ExcelPackage excel = new ExcelPackage();
            var worksheet = excel.Workbook.Worksheets.Add("Sayfa1");
            worksheet.Cells["A1"].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Light10);

            return excel.GetAsByteArray();
        }
    }
}
