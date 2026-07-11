using BethanyPieShop.Shared;

namespace BethanyPieShop.Services
{
    public class MockDataService
    {
        public Task<Employee[]> GetAllEmployees()
        {
            return Task.FromResult(new Employee[]
            {
                new() { Id = 1, FirstName = "Bob", LastName = "Smith", ImageUrl = "https://randomuser.me/api/portraits/men/32.jpg" },
                new() { Id = 2, FirstName = "Patrick", LastName = "Johnson", ImageUrl = "https://randomuser.me/api/portraits/men/75.jpg" },
                new() { Id = 3, FirstName = "Mary", LastName = "Williams", ImageUrl = "https://randomuser.me/api/portraits/women/44.jpg" },
                new() { Id = 4, FirstName = "John", LastName = "Brown", ImageUrl = "https://randomuser.me/api/portraits/men/46.jpg" },
                new() { Id = 5, FirstName = "Sara", LastName = "Davis", ImageUrl = "https://randomuser.me/api/portraits/women/65.jpg" }
            });
        }
    }
}
