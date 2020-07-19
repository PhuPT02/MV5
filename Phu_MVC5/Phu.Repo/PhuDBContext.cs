using Phu.Model.Models;
using System.Data.Entity;

namespace Phu.Data
{
    public class PhuDBContext : DbContext
    {
        public PhuDBContext() : base("name=PhuTest")
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}