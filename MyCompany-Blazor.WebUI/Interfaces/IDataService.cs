using MyCompany_Blazor.Shared.Entitites;
using MyCompany_Blazor.Shared.Entitites.DisplayEntities;

namespace MyCompany_Blazor.WebUI.Interfaces
{
    /// <summary>
    /// Exposes the DataService methods
    /// </summary>
    public interface IDataService
    {
        Task<List<AggregateEmployeeData>> GetAggregateEmployeeData();

        Task<List<Employee>> GetEmployees();

        Task<List<Manager>> GetManagers();

        Task<List<Director>> GetDirectors();

        Task<List<Job>> GetJobs();
    }
}