using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void TAdd(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void TDelete(Instructor entity)
        {
            _instructorDal.Delete(entity);
        }

        public List<Instructor> TGetAll()
        {
            return _instructorDal.GetAll();
        }

        public List<Instructor> TGetByFilter(Expression<Func<Instructor, bool>> filter)
        {
            return _instructorDal.GetByFilter(filter);
        }

        public Instructor TGetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void TUpdate(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
