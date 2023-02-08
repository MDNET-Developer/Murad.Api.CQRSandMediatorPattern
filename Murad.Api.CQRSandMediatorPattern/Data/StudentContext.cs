using Microsoft.EntityFrameworkCore;

namespace Murad.Api.CQRSandMediatorPattern.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new(){Id=1,Name="Murad",Surname="Aliyev",Age=21,Group="M652A2"},
                new(){Id=2,Name="Parviz",Surname="Yunisli",Age=21,Group="N674"},
                new(){Id=3,Name="Khuraman",Surname="Taghizadeh",Age=21,Group="M455"},
                new(){Id=4,Name="Elshad",Surname="Babayev",Age=21,Group="mM652A2"},
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
