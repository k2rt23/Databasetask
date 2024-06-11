using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<HealthExamination> HealthExamination { get; set; }
        public DbSet<LaenutavadAsjad> LaenutavadAsjad { get; set; }
        public DbSet<Laenutus> Laenutus { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<SickDays> Sickdaysss { get; set; }


    }
}
