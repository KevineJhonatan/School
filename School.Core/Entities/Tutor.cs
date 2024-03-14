using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Tutor")]
    public class Tutor : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public bool IsParent { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        public virtual int StudentId { get; set; }
        public virtual Student? Student { get; set; }
    }
}
