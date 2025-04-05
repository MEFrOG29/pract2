using Excel = Microsoft.Office.Interop.Excel;
namespace pr2t3
{
    public partial class CreateMultiplicationTableForm : Form
    {
        public CreateMultiplicationTableForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ExcelManager excelManager = new();
            excelManager.CreateExcelDoc();
        }
    }
}
