using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{
    [Table("ClassCalendar")]
    public class ClassCalendar : EntityBase
    {
        public int DayOfWeek_Id { get; set; }
        public virtual SysParamValue? DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
        public virtual int ClassId { get; set; }
        public virtual Class? Class { get; set; }

        public virtual int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }

        public virtual int TeacherId { get; set; }
        public virtual Teacher? Teacher { get; set; }

        public virtual int SchoolYearId { get; set; }
        public virtual SchoolYear? SchoolYear { get; set; }

    }
}
