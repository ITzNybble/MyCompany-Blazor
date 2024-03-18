using MyCompany_Blazor.Server.Data;
using MyCompany_Blazor.Shared.Entitites;
using MyCompany_Blazor.Shared.Entitites.DisplayEntities;
using MyCompany_Blazor.WebUI.Interfaces;

namespace MyCompany_Blazor.WebUI.Services
{
    /// <summary>
    /// Handles the retrieval of data from the database utilizing dbContext
    /// </summary>
    /// <param name="dbContext">The database context to use</param>
    public class DataService(DataContext dbContext) : IDataService
    {
        public readonly DataContext _context = dbContext;

        public async Task<List<AggregateEmployeeData>> GetAggregateEmployeeData()
        {
            ParseEmployees(await GetEmployees(), await GetManagers(), await GetJobs(), await GetDirectors(), out List<AggregateEmployeeData> result);

            return result;
        }

        /// <summary>
        /// Gets a list of employee objects from the database context
        /// </summary>
        /// <returns>List of Employee objects</returns>
        public async Task<List<Employee>> GetEmployees()
        {
            return await Task.FromResult(_context.Employees.ToList());
        }

        /// <summary>
        /// Gets a list of manager objects from the database context
        /// </summary>
        /// <returns>List of Manager objects</returns>
        public async Task<List<Manager>> GetManagers()
        {
            return await Task.FromResult(_context.Managers.ToList());
        }

        /// <summary>
        /// Gets a list of director objects from the database context
        /// </summary>
        /// <returns>List of Director objects</returns>
        public async Task<List<Director>> GetDirectors()
        {
            return await Task.FromResult(_context.Directors.ToList());
        }

        /// <summary>
        /// Gets a list of job objects from the database context
        /// </summary>
        /// <returns>List of Job objects</returns>
        public async Task<List<Job>> GetJobs()
        {
            return await Task.FromResult(_context.Jobs.ToList());
        }

        /// <summary>
        /// Parses all employees and aggregates the employees with their mangager/Job/ and director data
        /// </summary>
        /// <param name="employees">List of employees</param>
        /// <param name="managers">List of managers</param>
        /// <param name="jobs">List of jobs</param>
        /// <param name="directors">List of directors</param>
        /// <param name="aggregateData">List of aggregated data</param>
        public void ParseEmployees (List<Employee> employees, List<Manager> managers, List<Job> jobs, List<Director> directors, out List<AggregateEmployeeData> aggregateData)
        {
            aggregateData = new List<AggregateEmployeeData>();

            foreach(Employee e in employees) 
            {
                Job employeeJob = jobs.FirstOrDefault(x => x.Id == e.JobId, new Job());
                Manager employeeManager = managers.FirstOrDefault(x => x.Id == e.ManagerId, new Manager());
                Director employeeDirector = directors.FirstOrDefault(x => x.Id == e.DirectorId, new Director());
                
                // Randomly assign a picture to the employee for demo purposes
                // Ideally we would store the picture in the database or retreive it from a service/api
                Random random = new Random();

                aggregateData.Add(new AggregateEmployeeData()
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Address = e.Address,
                    City = e.City,
                    State = e.State,
                    Country = e.Country,
                    Title = employeeJob.Title,
                    Department = employeeJob.Department,
                    ManagerFirstName = employeeManager.FirstName,
                    ManagerLastName = employeeManager.LastName,
                    DirectorId = employeeDirector.Id,
                    EmployeePictureId = random.Next(1, 21)
                });
            }
        }
    }
}