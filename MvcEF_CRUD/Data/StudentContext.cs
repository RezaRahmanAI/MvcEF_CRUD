using MvcEF_CRUD.Models;
using System.Data.Entity;

namespace MvcEF_CRUD.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}