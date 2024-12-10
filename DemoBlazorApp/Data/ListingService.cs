namespace DemoBlazorApp.Data
{
    public class ListingService
    {
        public Task<ListingDTO> GetListing(int pageNumber, int pageSize, int? status)
        {
            var filterList = ListingEntities.ToList();

            if (status != null)
            {
                filterList = ListingEntities
                    .Where(l => l.Status == status)
                    .ToList();
            }
            
            var result = new ListingDTO
            {
                TotalCount = filterList.Count,
                Listings = filterList
                    .Skip(pageSize * (pageNumber - 1))
                    .Take(pageSize)
            };
            
            return Task.FromResult(result);
        }

        private static readonly IEnumerable<ListingEntity> ListingEntities = new[]
        {
            new ListingEntity { Id = 1, Name = "One", Status = 0 },
            new ListingEntity { Id = 2, Name = "Two", Status = 0 },
            new ListingEntity { Id = 3, Name = "Three", Status = 0 },
            new ListingEntity { Id = 4, Name = "Four", Status = 0 },
            new ListingEntity { Id = 5, Name = "Five", Status = 0 },
            new ListingEntity { Id = 6, Name = "Six", Status = 0 },
            new ListingEntity { Id = 7, Name = "Seven", Status = 0 },
            new ListingEntity { Id = 8, Name = "Eight", Status = 0 },
            new ListingEntity { Id = 9, Name = "Nine", Status = 0 },
            new ListingEntity { Id = 10, Name = "Ten", Status = 0 },
            new ListingEntity { Id = 11, Name = "Eleven", Status = 1 },
            new ListingEntity { Id = 12, Name = "Twelve", Status = 1 },
            new ListingEntity { Id = 13, Name = "Thirteen", Status = 1 },
            new ListingEntity { Id = 14, Name = "Fourteen", Status = 1 },
            new ListingEntity { Id = 15, Name = "Fifteen", Status = 1 },
            new ListingEntity { Id = 16, Name = "Sixteen", Status = 1 },
            new ListingEntity { Id = 17, Name = "Seventeen", Status = 1 },
            new ListingEntity { Id = 18, Name = "Eighteen", Status = 1 },
            new ListingEntity { Id = 19, Name = "Nineteen", Status = 1 },
            new ListingEntity { Id = 20, Name = "Twenty", Status = 1 },
            new ListingEntity { Id = 21, Name = "Twenty One", Status = 2 },
            new ListingEntity { Id = 22, Name = "Twenty Two", Status = 2 },
            new ListingEntity { Id = 23, Name = "Twenty Three", Status = 2 },
            new ListingEntity { Id = 24, Name = "Twenty Four", Status = 2 },
            new ListingEntity { Id = 25, Name = "Twenty Five", Status = 2 },
            new ListingEntity { Id = 26, Name = "Twenty Six", Status = 2 },
            new ListingEntity { Id = 27, Name = "Twenty Seven", Status = 2 },
            new ListingEntity { Id = 28, Name = "Twenty Eight", Status = 2 },
            new ListingEntity { Id = 29, Name = "Twenty Nine", Status = 2 },
            new ListingEntity { Id = 30, Name = "Thirty", Status = 2 },
            new ListingEntity { Id = 31, Name = "Thirty One", Status = 3 },
            new ListingEntity { Id = 32, Name = "Thirty Two", Status = 3 },
            new ListingEntity { Id = 33, Name = "Thirty Three", Status = 3 },
            new ListingEntity { Id = 34, Name = "Thirty Four", Status = 3 },
            new ListingEntity { Id = 35, Name = "Thirty Five", Status = 3 },
            new ListingEntity { Id = 36, Name = "Thirty Six", Status = 3 },
            new ListingEntity { Id = 37, Name = "Thirty Seven", Status = 3 },
            new ListingEntity { Id = 38, Name = "Thirty Eight", Status = 3 },
            new ListingEntity { Id = 39, Name = "Thirty Nine", Status = 3 },
            new ListingEntity { Id = 40, Name = "Forty", Status = 3 },
        };
    }
}