using Excel = Microsoft.Office.Interop.Excel;

CreateExcelDoc(@"D:\ПРОСТ СОХРАНЁНКИ", "Piski");

static void CreateExcelDoc(string path, string fileName)
{
    Excel.Application app = new();
    app.Visible = true;

    var template = @"C:/Users/PC/Desktop/Шаблон.xlsx";
    var doc = app.Workbooks.Add(template);
    var sheet1 = doc.Worksheets[1];
    var sheet2 = doc.Worksheets[2];
    var files = Directory.GetFiles(path);
    var directories = Directory.GetDirectories(path);
    FileInfo fileInfo;
    DirectoryInfo directoryInfo;

    for (int i = 0; i < files.Length; i++)
    {
        fileInfo = new(files[i]);
        sheet1.Cells[i + 2, 1] = i + 1;
        sheet1.Cells[i + 2, 2] = fileInfo.Name;
        sheet1.Cells[i + 2, 3] = fileInfo.Length;
    }

    for (int i = 0; i < directories.Length; i++)
    {
        directoryInfo = new(directories[i]);
        sheet2.Cells[i + 2, 1] = i + 1;
        sheet2.Cells[i + 2, 2] = directoryInfo.Name;
    }

    doc.SaveAs(Path.Combine(Environment.CurrentDirectory, fileName), Excel.XlFileFormat.xlWorkbookDefault);
} 


