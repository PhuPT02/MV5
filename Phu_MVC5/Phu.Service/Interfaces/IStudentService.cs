using Phu.Model.Models;
using System.Collections.Generic;

namespace Phu.Service.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        void save();
    }
}