using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany_Blazor.Shared.Entitites
{
    /// <summary>
    /// Describes the Employee entity
    /// </summary>
    public class Employee
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("first_name")]
        public required string FirstName { get; set; } = string.Empty;

        [Column("last_name")]
        public required string LastName { get; set; } = string.Empty;

        [Column("address")]
        public string Address { get; set; } = string.Empty;

        [Column("city")]
        public string City { get; set; } = string.Empty;

        [Column("state")]
        public string State { get; set; } = string.Empty;

        [Column("country")]
        public string Country { get; set; } = string.Empty;

        [Column("job_id")]
        public int JobId { get; set; }

        [Column("manager_id")]
        public int ManagerId { get; set; }

        [Column("director_id")]
        public int DirectorId { get; set; }
    }
}