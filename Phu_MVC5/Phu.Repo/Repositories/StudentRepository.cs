using Phu.Data.Base;
using Phu.Data.Interfaces;
using Phu.Model.Models;

namespace Phu.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}