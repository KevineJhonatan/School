using Microsoft.EntityFrameworkCore;
using School.Core;
using School.Core.Entities;
using School.Core.Enums;
using School.Core.Helpers;
using School.Core.JsonResponse;
using School.Infrastructure.Configurations;
using System.Reflection.Metadata;
using Ecole = School.Core.Entities.School;

namespace School.Infrastructure
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<ClassCalendar> ClassCalendars { get; set; }

        public DbSet<Ecole> Schools { get; set; }

        public DbSet<SchoolYear> SchoolYears { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentHistory> StudentHistories { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SysParam> SysParams { get; set; }

        public DbSet<SysParamValue> SysParamValues { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Tutor> Tutors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SysParamConfiguration());
            modelBuilder.ApplyConfiguration(new SysParamValueConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolAdminConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolYearConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TutorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ClassCalendarConfiguration());
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());

            DateTime createdDate = new DateTime(2024, 2, 1);

            modelBuilder.Entity<Ecole>().HasData(
               new Ecole { Id = 1, Name = "AdminSchool", Description = "AdminSchool", IsActive = false, CreatedBy = 1, CreatedAt = createdDate }
            );

            modelBuilder.Entity<Admin>().HasData(
               new Admin
               {
                   Id = 1,
                   Firstname = "Admin",
                   Lastname = "Admin",
                   DOB = createdDate,
                   Gender = (char)Gender.Male,
                   Login = "Admin",
                   Password = "Admin".HashPassword(),
                   IsSuper = true,
                   SchoolId = 1,
                   CreatedBy = 1,
                   CreatedAt = createdDate
               }
            );

            modelBuilder.Entity<SysParam>().HasData(
                new SysParam { Id = 1, Code = "ATTENDANCE_STATUS", Title = "Présence", Description = "Présence", CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 1, Code = "PRESENT", ShortText1 = "Present", SysParamId = 1, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 2, Code = "ABSENT", ShortText1 = "Absent", SysParamId = 1, CreatedAt = createdDate, CreatedBy = 1 }
            );


            modelBuilder.Entity<SysParam>().HasData(
                new SysParam { Id = 2, Code = "CLASS_LEVEL", Title = "Niveau", Description = "Niveau", CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 3, Code = "CLASS_LEVEL_1", ShortText1 = "Petite section", IntValue1 = 1, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 4, Code = "CLASS_LEVEL_2", ShortText1 = "Moyenne section", IntValue1 = 2, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 5, Code = "CLASS_LEVEL_3", ShortText1 = "Grande section", IntValue1 = 3, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 6, Code = "CLASS_LEVEL_4", ShortText1 = "Maternelle", IntValue1 = 4, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 7, Code = "CLASS_LEVEL_5", ShortText1 = "12 ème", IntValue1 = 5, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 8, Code = "CLASS_LEVEL_6", ShortText1 = "11 ème", IntValue1 = 6, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 9, Code = "CLASS_LEVEL_7", ShortText1 = "10 ème", IntValue1 = 7, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 10, Code = "CLASS_LEVEL_8", ShortText1 = "0 ème", IntValue1 = 8, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 11, Code = "CLASS_LEVEL_9", ShortText1 = "8 ème", IntValue1 = 9, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
               new SysParamValue { Id = 12, Code = "CLASS_LEVEL_10", ShortText1 = "7 ème", IntValue1 = 10, SysParamId = 2, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParam>().HasData(
                new SysParam { Id = 3, Code = "DAY_OF_WEEK", Title = "Jours de la semaine", Description = "Jours de la semaine", CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 13, Code = "MONDAY", ShortText1 = "Lundi", IntValue1 = 1, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 14, Code = "TUESDAY", ShortText1 = "Mardi", IntValue1 = 2, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 15, Code = "WEDNESDAY", ShortText1 = "Mercredi", IntValue1 = 3, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 16, Code = "THURSDAY", ShortText1 = "Jeudi", IntValue1 = 4, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 17, Code = "FRIDAY", ShortText1 = "Vendredi", IntValue1 = 5, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 18, Code = "SATURDAY", ShortText1 = "Samedi", IntValue1 = 6, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
            );

            modelBuilder.Entity<SysParamValue>().HasData(
                new SysParamValue { Id = 19, Code = "SUNDAY", ShortText1 = "Dimanche", IntValue1 = 7, SysParamId = 3, CreatedAt = createdDate, CreatedBy = 1 }
           );

            /* LES DES EXCEPTIONS */

            modelBuilder.Entity<SysParam>().HasData(new SysParam { Id = 4, Code = "ERRORS", Title = "Errors", Description = "Errors", CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 20, Code = Error.SCHOOL_NAME_ERROR_CODE.ToString(), ShortText1 = "Name", LongText1 = "School name is mandatory", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 21, Code = Error.INVALID_USERID_ERROR_CODE.ToString(), ShortText1 = "UserId", LongText1 = "Invalid UserId while creating token", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 22, Code = Error.INVALID_USERROLE_ERROR_CODE.ToString(), ShortText1 = "UserRole", LongText1 = "Invalid UserRole while creating token", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 24, Code = Error.INVALID_LOGIN_PASSWORD_ERROR_CODE.ToString(), ShortText1 = "Credentials", LongText1 = "Invalid Login or Password", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 25, Code = Error.INVALID_ADMIN_FIRSTNAME_ERROR_CODE.ToString(), ShortText1 = "Firstname", LongText1 = "Invalid Firstname", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 26, Code = Error.INVALID_ADMIN_LASTNAME_ERROR_CODE.ToString(), ShortText1 = "Lastname", LongText1 = "Invalid Lastname", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 27, Code = Error.INVALID_ADMIN_DOB_ERROR_CODE.ToString(), ShortText1 = "Birthdate", LongText1 = "Invalid Birthdate", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 28, Code = Error.INVALID_ADMIN_DOB_FORMAT_ERROR_CODE.ToString(), ShortText1 = "Birthdate", LongText1 = "Invalid Birthdate format. The valid format is 'dd/MM/yyyy'", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 29, Code = Error.INVALID_ADMIN_GENDER_ERROR_CODE.ToString(), ShortText1 = "Gender", LongText1 = "Invalid Gender. The only valid gender is 'M' or 'F'", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 30, Code = Error.INVALID_ADMIN_LOGIN_ERROR_CODE.ToString(), ShortText1 = "Login", LongText1 = "Invalid Login for Admin", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 40, Code = Error.INVALID_ADMIN_PASSWORD_ERROR_CODE.ToString(), ShortText1 = "Password", LongText1 = "Invalid Password", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 41, Code = Error.INEXISTING_SCHOOL_ERROR_CODE.ToString(), ShortText1 = "SchoolID", LongText1 = "The specified school does not exist", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 42, Code = Error.EXISTING_ADMIN_LOGIN_ERROR_CODE.ToString(), ShortText1 = "Login", LongText1 = "The specified login already exist", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 43, Code = Error.INVALID_PASSWORD_LENGTH_ERROR_CODE.ToString(), ShortText1 = "Password", LongText1 = $"The password must contains at least {Constants.PASSWORD_LENGTH} characters", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });
            modelBuilder.Entity<SysParamValue>().HasData(new SysParamValue { Id = 44, Code = Error.INEXISTING_ADMIN_USER_ERROR_CODE.ToString(), ShortText1 = "User", LongText1 = $"The admin user does not exist", SysParamId = 4, CreatedAt = createdDate, CreatedBy = 1 });

            modelBuilder.Entity<Ecole>().HasData(
               new Ecole { Id = 2, Name = "Vitale", Description = "Vitale", CreatedBy = 1, CreatedAt = createdDate }
            );

            modelBuilder.Entity<Admin>().HasData(
               new Admin
               {
                   Id = 2,
                   Firstname = "Camil",
                   Lastname = "Vitale",
                   DOB = createdDate,
                   Gender = (char)Gender.Male,
                   Login = "vitale@gmail.com",
                   Password = "Vitale".HashPassword(),
                   IsSuper = false,
                   SchoolId = 2,
                   CreatedBy = 1,
                   CreatedAt = createdDate
               }
            );

            modelBuilder.Entity<SchoolYear>().HasData(
              new SchoolYear { Id = 1, SchoolId = 2, StartDate = new DateTime(2023, 9, 1), EndDate = new DateTime(2024, 7, 1), CreatedBy = 2, CreatedAt = createdDate }
           );

            modelBuilder.Entity<Class>().HasData(
              new Class { Id = 1, SchoolId = 2, Name = "Maternnel", Description = "", Level_Id = 6, CreatedBy = 2, CreatedAt = createdDate }
           );
            modelBuilder.Entity<Class>().HasData(
              new Class { Id = 2, SchoolId = 2, Name = "12 ème", Description = "", Level_Id = 7, CreatedBy = 2, CreatedAt = createdDate }
           );
            modelBuilder.Entity<Class>().HasData(
             new Class { Id = 3, SchoolId = 2, Name = "11 ème", Description = "", Level_Id = 8, CreatedBy = 2, CreatedAt = createdDate }
          );
            modelBuilder.Entity<Class>().HasData(
             new Class { Id = 4, SchoolId = 2, Name = "10 ème", Description = "", Level_Id = 9, CreatedBy = 2, CreatedAt = createdDate }
          );
            modelBuilder.Entity<Class>().HasData(
             new Class { Id = 5, SchoolId = 2, Name = "9 ème", Description = "", Level_Id = 10, CreatedBy = 2, CreatedAt = createdDate }
          );
            modelBuilder.Entity<Class>().HasData(
             new Class { Id = 6, SchoolId = 2, Name = "8 ème", Description = "", Level_Id = 11, CreatedBy = 2, CreatedAt = createdDate }
          );
            modelBuilder.Entity<Class>().HasData(
             new Class { Id = 7, SchoolId = 2, Name = "7 ème", Description = "", Level_Id = 12, CreatedBy = 2, CreatedAt = createdDate }
          );
        }
    }
}
