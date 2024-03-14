using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("Attendance")]
    public class Attendance : EntityBase
    {
        public DateTime AttendanceDate { get; set; }

        public int Status_Id { get; set; }
        public virtual SysParamValue? Status { get; set; }

        public virtual int StudentId { get; set; }
        public virtual Student? Student { get; set; }

        public virtual int ClassCalendarId { get; set; }
        public virtual ClassCalendar? ClassCalendar { get; set; }
    }
}
