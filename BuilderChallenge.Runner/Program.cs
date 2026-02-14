using BuilderChallenge.ConcreteBuilder;
using BuilderChallenge.Director;

namespace BuilderChallenge;
public class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Relatórios ===");

        var builderPdfReport1 = new SalesReportBuilder();
        var director = new SalesReportDirector();

        var pdfReport1 = director.BuildPdfReport(builderPdfReport1)
            .WithTitle("Vendas mensais")
            .WithFormat("PDF")
            .WithStartDate(new DateTime(2024, 1, 1))
            .WithEndDate(new DateTime(2024, 1, 31))
            .WithHeader(true, "Relatório de Vendas")
            .WithFooter(true, "Confidencial")
            .WithCharts(true, "Bar")
            .WithSummary(true)
            .WithColumns(["Produto", "Quantidade", "Valor"])
            .WithFilters(["Status=Ativo"])
            .WithSortBy("Produto")
            .WithGroupBy("Categoria")
            .WithTotals(true)
            .WithOrientation("Portrait")
            .WithPageSize("A4")
            .WithPageNumbers(true)
            .WithCompanyLogo("logo.png")
            .WithWaterMark("Confidencial");

        try
        {
            pdfReport1.Gerar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao gerar o relatório {nameof(pdfReport1)}: {ex.Message}");
        }

        var pdfReport2 = pdfReport1
            .WithEndDate(new DateTime(2024, 12, 31))
            .WithCharts(true, "Pie")
            .WithHeader(true, "Relatório de Vendas Anuais")
            .WithSummary(false)
            .WithFilters([])
            .WithSortBy("")
            .WithGroupBy("")
            .WithOrientation("Landscape")
            .WithPageNumbers(false)
            .WithWaterMark("");

        try
        {
            pdfReport2.Gerar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao gerar o relatório {nameof(pdfReport2)}: {ex.Message}");
        }

        var builderhtmlReport1 = new SalesReportBuilder();
        var htmlReport1 = director.BuildHtmlReport(builderhtmlReport1);

        try
        {
            // Esperado estourar exceção, pois não passou informações obrigatórias como título, formato, datas e colunas
            htmlReport1.Gerar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao gerar o relatório {nameof(htmlReport1)}: {ex.Message}");
        }
    }
}
