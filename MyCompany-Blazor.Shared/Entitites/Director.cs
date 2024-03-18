using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany_Blazor.Shared.Entitites
{
    /// <summary>
    /// Descrives the Director entity
    /// </summary>
    public class Director
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; } = "First Name unavailable";

        [Column("last_name")]
        public string LastName { get; set; } = "Last Name unavailable";
    }
}