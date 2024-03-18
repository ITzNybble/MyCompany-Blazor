namespace MyCompany_Blazor.Shared.Entitites.DisplayEntities
{
    /// <summary>
    /// Describes the Employee object containing Job Title/Department and Manager First/Last Name
    /// </summary>
    public class AggregateEmployeeData
    {

        public required string FirstName { get; set; } = string.Empty;

        public required string LastName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public string ManagerFirstName { get; set; } = string.Empty;

        public string ManagerLastName { get; set; } = string.Empty;

        public int DirectorId { get; set; } = 0;

        public int EmployeePictureId { get; set; } = 1;
    }
}