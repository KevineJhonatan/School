using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Core.Entities;
using SchoolClass = School.Core.Entities.School;

namespace School.Infrastructure.Configurations
{
    public class SysParamConfiguration : IEntityTypeConfiguration<SysParam>
    {
        public void Configure(EntityTypeBuilder<SysParam> builder)
        {
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class SysParamValueConfiguration : IEntityTypeConfiguration<SysParamValue>
    {
        public void Configure(EntityTypeBuilder<SysParamValue> builder)
        {
            builder.HasOne(x => x.SysParam).WithMany().HasForeignKey(x => x.SysParamId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.SysParamId).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.ShortText1).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.LongText1).HasMaxLength(5000).IsRequired(false);
            builder.Property(x => x.DecimalValue1).HasPrecision(18, 2).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasOne(x => x.Class).WithMany().HasForeignKey(x => x.ClassId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class SchoolConfiguration : IEntityTypeConfiguration<SchoolClass>
    {
        public void Configure(EntityTypeBuilder<SchoolClass> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Lastname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DOB).HasColumnType("date").IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Login).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(70).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class SchoolAdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasOne(x => x.School).WithMany().HasForeignKey(x => x.SchoolId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.SchoolId).IsRequired();
            builder.Property(x => x.Firstname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Lastname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DOB).HasColumnType("date").IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Login).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(70).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsSuper).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class SchoolYearConfiguration : IEntityTypeConfiguration<SchoolYear>
    {
        public void Configure(EntityTypeBuilder<SchoolYear> builder)
        {
            builder.HasOne(x => x.School).WithMany().HasForeignKey(x => x.SchoolId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.StartDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.EndDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasOne(x => x.School).WithMany().HasForeignKey(x => x.SchoolId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Level).WithMany().HasForeignKey(x => x.Level_Id).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.Level_Id).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.Firstname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Lastname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DOB).HasColumnType("date").IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class TutorConfiguration : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            builder.HasOne(x => x.Student).WithMany().HasForeignKey(x => x.StudentId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Firstname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Lastname).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DOB).HasColumnType("date").IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.IsParent).IsRequired();
            builder.Property(x => x.Login).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(70).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class StudentHistoryConfiguration : IEntityTypeConfiguration<StudentHistory>
    {
        public void Configure(EntityTypeBuilder<StudentHistory> builder)
        {
            builder.HasOne(x => x.Class).WithMany().HasForeignKey(x => x.ClassId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Student).WithMany().HasForeignKey(x => x.StudentId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.SchoolYear).WithMany().HasForeignKey(x => x.SchoolYearId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class ClassCalendarConfiguration : IEntityTypeConfiguration<ClassCalendar>
    {
        public void Configure(EntityTypeBuilder<ClassCalendar> builder)
        {
            builder.HasOne(x => x.Class).WithMany().HasForeignKey(x => x.ClassId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Subject).WithMany().HasForeignKey(x => x.SubjectId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Teacher).WithMany().HasForeignKey(x => x.TeacherId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.SchoolYear).WithMany().HasForeignKey(x => x.SchoolYearId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.DayOfWeek).WithMany().HasForeignKey(x => x.DayOfWeek_Id).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.DayOfWeek_Id).IsRequired();
            builder.Property(x => x.StartTime).HasColumnType("time(0)").HasConversion<TimeOnlyConverter>().IsRequired();
            builder.Property(x => x.EndTime).HasColumnType("time(0)").HasConversion<TimeOnlyConverter>().IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }

    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasOne(x => x.Student).WithMany().HasForeignKey(x => x.StudentId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.ClassCalendar).WithMany().HasForeignKey(x => x.ClassCalendarId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Status).WithMany().HasForeignKey(x => x.Status_Id).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Status_Id).IsRequired();
            builder.Property(x => x.AttendanceDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("GETDATE()").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnType("datetime").IsRequired(false);
        }
    }
}