using System;
using OfficeOpenXml;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
namespace WebApplication1.Helper
{
    public class GetExcel
    {
        public GetExcel()
        {

        }
        public string GetValue()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var filePath = "C:\\Users\\wenbin\\Documents\\批量准考证\\第二考场\\source.xlsx";
            //Console.WriteLine("Reading column 2 of {0}", filePath);
            

            FileInfo existingFile = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //Get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                return worksheet.Cells[1, 1].Value.ToString();
            }
        }
    }
}
