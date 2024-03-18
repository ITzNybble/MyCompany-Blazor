using System.ComponentModel.DataAnnotations.Schema;

namespace MyCompany_Blazor.Shared.Entitites
{
    /// <summary>
    /// Describes the Job entity
    /// </summary>
    public class Job
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; } = "Title Unavailable";

        [Column("department")]
        public string Department { get; set; } = "Department Unavailable";
    }
}