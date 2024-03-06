using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop.Infrastructure;

namespace MVCDay2.Models
{
    public class MyContext : DbContext

    {
        public MyContext() : base()
        {}

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Integrated Security=false; Database=DESKTOP-JS0ECST;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instractor> Instractors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<CRSresult> CRSresults { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(new Course { Id = 1, CourseName = "DB", CourseDegree = 170, CourseMinDegree = 100, DeptId = 2 });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 2, CourseName = "csharp", CourseDegree = 150, CourseMinDegree = 80, DeptId = 1 });
            modelBuilder.Entity<Course>().HasData(new Course { Id = 3, CourseName = "Js", CourseDegree = 280, CourseMinDegree = 180, DeptId = 3 });
           
            modelBuilder.Entity<Department>().HasData(new Department { Id = 1, DeptName = "webdept", DeptManager="Amr" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 2, DeptName = "mobiledept", DeptManager = "Amira" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 3, DeptName = "flutterdept", DeptManager = "Ahmed" });
           
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 1, TrName = "nouh", TrAddress = "cairo"  , TrGrade=50 ,DeptId=1, TrImage="mal.jpeg"});
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 2, TrName = "nour", TrAddress = "alex", TrGrade=90 ,DeptId=2 ,TrImage ="fem.jpeg" });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 3, TrName = "Ezz", TrAddress = "cairo", TrGrade = 20, DeptId = 3, TrImage = "mal.jpeg" });
            modelBuilder.Entity<Trainee>().HasData(new Trainee { Id = 4, TrName = "laila", TrAddress = "alex", TrGrade = 170, DeptId = 2, TrImage = "fem.jpeg" });

            modelBuilder.Entity<CRSresult>().HasData(new CRSresult {Id=1,CrsDegree=100, CourseId=1, TRId=1 });
            modelBuilder.Entity<CRSresult>().HasData(new CRSresult { Id = 2,CrsDegree= 200,CourseId=2 ,TRId=2 });
            modelBuilder.Entity<CRSresult>().HasData(new CRSresult { Id = 3, CrsDegree = 40, CourseId =2, TRId =3});
            modelBuilder.Entity<CRSresult>().HasData(new CRSresult { Id = 4, CrsDegree = 10, CourseId =2, TRId =4 });
            modelBuilder.Entity<CRSresult>().HasData(new CRSresult { Id = 5, CrsDegree = 30, CourseId =3, TRId =4 });


            modelBuilder.Entity<Instractor>().HasData(new Instractor {Id=1,InsName="sara" ,InsAddress="cairo",InsSalary=5000,InsImage="mal.jpeg",DeptId=1,CourseId=3});
            modelBuilder.Entity<Instractor>().HasData(new Instractor { Id = 2, InsName = "ali", InsAddress = "cairo", InsSalary = 9000, InsImage ="mal.jpeg", DeptId = 2, CourseId = 2 });
            modelBuilder.Entity<Instractor>().HasData(new Instractor { Id = 3, InsName = "crestin", InsAddress = "asuit", InsSalary = 6000, InsImage = "fem.jpeg", DeptId = 3, CourseId = 1 });



         base.OnModelCreating(modelBuilder);
        }
    }


}
