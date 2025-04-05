using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
class ExcelManager
{
    private Excel.Application app;
    private Excel.Workbook workbook;
    private Excel.Worksheet worksheet;


    public void CreateExcelDoc()
    {
        app = new Excel.Application();
        app.Visible = true;
        workbook = app.Workbooks.Add();
        worksheet = app.Sheets[1];
        var values = worksheet.Range[worksheet.Cells[10, 4], worksheet.Cells[18, 12]];
        var title = worksheet.Range[worksheet.Cells[9, 4], worksheet.Cells[9, 12]];
        worksheet.Name = "Умножение";
        title.Merge();
        title.Value = "Таблица умножения";
        title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        title.Font.Bold = true;
        title.Font.Italic = true;
        title.Font.Size = 20;
        values.Font.Size = 15;
        values.Interior.Color = Excel.XlRgbColor.rgbCoral;
        values.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        title.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        
        for (int i = 2; i <= 9; i++)
        {
            for (int j = 2; j <= 9; j++)
            {
                worksheet.Cells[10, j+3] = j;
                worksheet.Cells[i+9, 4] = i;
                worksheet.Cells[i+9, j+3] = i * j;
            }
        }
    }

}

