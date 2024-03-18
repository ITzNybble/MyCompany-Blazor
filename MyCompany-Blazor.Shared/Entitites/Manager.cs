using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany_Blazor.Shared.Entitites
{
    /// <summary>
    /// Describes the Manager entity
    /// </summary>
    public class Manager
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } = "First Name unavailable";

        [Column("last_name")]
        public string LastName { get; set; } = "Last Name unavailable";
    }
}