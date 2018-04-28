using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hack_ME.Models;
using System.ComponentModel.DataAnnotations;

namespace Hack_ME.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Teacher> _teachers { get; set; }
        public DbSet<Student> _students { get; set; }
        public DbSet<Group> _groups { get; set; }
        public DbSet<Location> _locations { get; set; }
        public DbSet<TeacherGroup> teacherGroups { get; set; }
        public DbSet<StudentGroup> studentGroups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeacherGroup>()
                .HasKey(t => new { t.TeacherID, t.GroupID });

            builder.Entity<StudentGroup>()
                .HasKey(t => new { t.StudentID, t.GroupID });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }

    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }

        public ICollection<TeacherGroup> TeacherGroups { get; } = new List<TeacherGroup>();
    }

    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public int? LocationID { get; set; }
        public Location Location { get; set; }

        public ICollection<StudentGroup> studentGroups { get; } = new List<StudentGroup>();
    }

    public class Group
    {
        [Key]
        public int GroupID { get; set; }
        public string GroupName { get; set; }

        public ICollection<TeacherGroup> Teachers { get; } = new List<TeacherGroup>();

        public ICollection<StudentGroup> Students { get; } = new List<StudentGroup>();
    }

    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        
        public string LocationName { get; set; }
    }

    //Connection
    public class TeacherGroup
    {
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; }
    }

    public class StudentGroup
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; }
    }

}
