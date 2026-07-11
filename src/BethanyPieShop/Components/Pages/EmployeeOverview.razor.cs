using BethanyPieShop.Services;
using BethanyPieShop.Shared;

namespace BethanyPieShop.Components.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var mockDataService = new MockDataService();
            Employees = await mockDataService.GetAllEmployees();
        }
    }
}