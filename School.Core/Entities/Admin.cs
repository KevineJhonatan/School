using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Admin")]
    public class Admin : EntityBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public bool IsSuper { get; set; }
        public virtual int SchoolId { get; set; }
        public virtual School? School { get; set; }
    }
}