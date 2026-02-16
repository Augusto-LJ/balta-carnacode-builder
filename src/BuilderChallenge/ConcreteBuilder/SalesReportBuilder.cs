using BuilderChallenge.Builder;
using BuilderChallenge.Product;

namespace BuilderChallenge.ConcreteBuilder;
public class SalesReportBuilder : ISalesReportBuilder
{
	private readonly SalesReport _report = new();

    public ISalesReportBuilder WithTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public ISalesReportBuilder WithFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    ISalesReportBuilder ISalesReportBuilder.WithStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }

    ISalesReportBuilder ISalesReportBuilder.WithEndDate(DateTime startDate)
    {
        _report.EndDate = startDate;
        return this;
    }

    public ISalesReportBuilder WithHeader(bool includeHeader, string headerText)
    {
        _report.IncludeHeader = includeHeader;
        _report.HeaderText = headerText;
        return this;
    }

    public ISalesReportBuilder WithFooter(bool includeFooter, string footerText)
    {
        _report.IncludeFooter = includeFooter;
        _report.FooterText = footerText;
        return this;
    }

    public ISalesReportBuilder WithCharts(bool includeCharts, string chartType)
    {
        _report.IncludeCharts = includeCharts;
        _report.ChartType = chartType;
        return this;
    }

    public ISalesReportBuilder WithSummary(bool includeSummary)
    {
        _report.IncludeSummary = includeSummary;
        return this;
    }

    public ISalesReportBuilder WithColumns(List<string> columns)
    {
        _report.Columns = columns;
        return this;
    }

    public ISalesReportBuilder WithFilters(List<string> filters)
    {
        _report.Filters = filters;
        return this;
    }

    public ISalesReportBuilder WithSorting(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public ISalesReportBuilder WithGrouping(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public ISalesReportBuilder WithTotals(bool includeTotals)
    {
        _report.IncludeTotals = includeTotals;
        return this;
    }

    public ISalesReportBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public ISalesReportBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public ISalesReportBuilder WithPageNumbers(bool includePageNumbers)
    {
        _report.IncludePageNumbers = includePageNumbers;
        return this;
    }

    public ISalesReportBuilder WithCompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }

    public ISalesReportBuilder WithWaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    } 

    public SalesReport Gerar()
    {
        _report.Gerar();
        return _report;
    }
}
