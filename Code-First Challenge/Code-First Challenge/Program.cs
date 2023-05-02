using Microsoft.EntityFrameworkCore;

namespace StudentDatabase
{
    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Major { get; set; }
        public double GPA { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDatabase;Trusted_Connection=True;");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                db.Database.EnsureCreated();

                var student = new Student
                {
                    Name = "John Smith",
                    Age = 22,
                    Major = "Computer Science",
                    GPA = 3.5
                };

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
