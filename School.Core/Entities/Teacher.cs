using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Teacher")]
    public class Teacher : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
