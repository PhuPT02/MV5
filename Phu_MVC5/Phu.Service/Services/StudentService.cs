using Phu.Data.Base;
using Phu.Data.Interfaces;
using Phu.Model.Models;
using Phu.Service.Interfaces;
using System.Collections.Generic;

namespace Phu.Service.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository;
        IUnitOfWork _unitOfWork;
        
        public StudentService(IStudentRepository studentRepository, UnitOfWork unitOfWork)
        {
            this._studentRepository = studentRepository;
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public void save()
        {
            _unitOfWork.Commit();
        }
    }
}