using ClosedXML.Excel;

namespace WorldCupSimulator.Util;
public static class EventsLogs
{
    public static List<DataLogs> Data { get; set; } = new();

    public static void Generate()
    {
        using(var workbook = new XLWorkbook())
        {
            string filePathName = System.IO.Directory.GetCurrentDirectory() + "\\" + "EventsLogs" + DateTime.Now;
            if (File.Exists(filePathName))
                File.Delete(filePathName);

            var planilha = workbook.Worksheets.Add($"Partida");

            int line = 1;
            GenerateHeader(planilha);

            line++;

            foreach (var item in Data)
            {
                planilha.Cell("A" + line).Value = item.TeamOne.Name;
                planilha.Cell("B" + line).Value = item.TeamTwo.Name;
                planilha.Cell("C" + line).Value = item.Winner.Name;
                planilha.Cell("D" + line).Value = item.Description;
                line++;
            }
            workbook.SaveAs(filePathName);
        }
    }

    private static void GenerateHeader(IXLWorksheet worksheet)
    {
        worksheet.Cell("A1").Value = "Código";
        worksheet.Cell("B1").Value = "Fornecedor";
        worksheet.Cell("C1").Value = "Valor R$";
        worksheet.Cell("D1").Value = "Vencimento";
        worksheet.Cell("E1").Value = "Pagamento";
        worksheet.Cell("F1").Value = "Valor Pago";
        worksheet.Cell("G1").Value = "Descrição";
    }
}
