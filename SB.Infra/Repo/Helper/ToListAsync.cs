
using Microsoft.EntityFrameworkCore;

namespace SB.Infra.Repo.Helper
{

public static class IQueryableExtensions
{
    public static async Task<PaginatedList<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int? pageIndex, int? pageSize)
    {
     int currentPageIndex = pageIndex ?? 1;
        int currentPageSize = pageSize ?? 10;
        var count = await source.CountAsync();
        var items = await source.Skip((currentPageIndex - 1) * currentPageSize).Take(currentPageSize).ToListAsync();
        return new PaginatedList<T>(items, count, currentPageIndex, currentPageSize);
    }
}

public class PaginatedList<T> : List<T>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        this.AddRange(items);
    }

    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;
}
}
