using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Student")]
    public class Student : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public string Description { get; set; }
    }
}