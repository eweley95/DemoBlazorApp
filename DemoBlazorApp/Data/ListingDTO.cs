using DemoBlazorApp.Pages;

namespace DemoBlazorApp.Data
{
    public class ListingDTO
    {
        public int TotalCount { get; set; }
        public IEnumerable<ListingEntity> Listings { get; set; } = new List<ListingEntity>();
    }
}