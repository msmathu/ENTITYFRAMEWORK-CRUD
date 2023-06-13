using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ENTITYFRAMEWORK_CRUD.DPCONTEXT
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
