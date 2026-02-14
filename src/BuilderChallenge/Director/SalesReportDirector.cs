using BuilderChallenge.Builder;
using BuilderChallenge.Product;

namespace BuilderChallenge.Director;
public class SalesReportDirector
{
    public ISalesReportBuilder BuildPdfReport(ISalesReportBuilder builder)
    {
        return builder.WithFormat("PDF");
    }

    public ISalesReportBuilder BuildExcelReport(ISalesReportBuilder builder)
    {
        return builder.WithFormat("Excel");
    }

    public ISalesReportBuilder BuildHtmlReport(ISalesReportBuilder builder)
    {
        return builder.WithFormat("HTML");
    }
}
