using BuilderChallenge.Product;

namespace BuilderChallenge.Builder;

public interface ISalesReportBuilder
{
    #region Obrigatórios
    ISalesReportBuilder WithTitle(string title);
	ISalesReportBuilder WithFormat(string format);
	ISalesReportBuilder WithStartDate(DateTime startDate);
	ISalesReportBuilder WithEndDate(DateTime startDate);
	ISalesReportBuilder WithColumns(List<string> columns);
    #endregion

    #region Não obrigatórios
	ISalesReportBuilder WithHeader(bool includeHeader, string headerText);
    ISalesReportBuilder WithFooter(bool includeFooter, string footerText);
	ISalesReportBuilder WithCharts(bool includeCharts, string chartType);
	ISalesReportBuilder WithSummary(bool includeSummary);
	ISalesReportBuilder WithFilters(List<string> filters);
	ISalesReportBuilder WithSortBy(string sortBy);
	ISalesReportBuilder WithGroupBy(string groupBy);
	ISalesReportBuilder WithTotals(bool includeTotals);
	ISalesReportBuilder WithOrientation(string orientation);
	ISalesReportBuilder WithPageSize(string pageSize);
	ISalesReportBuilder WithPageNumbers(bool includePageNumbers);
	ISalesReportBuilder WithCompanyLogo(string companyLogo);
    ISalesReportBuilder WithWaterMark(string waterMark);
    #endregion

    SalesReport Gerar();
}