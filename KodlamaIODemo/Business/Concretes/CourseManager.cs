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
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void TAdd(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void TDelete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public List<Course> TGetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> TGetByFilter(Expression<Func<Course, bool>> filter)
        {
            return _courseDal.GetByFilter(filter);
        }

        public Course TGetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void TUpdate(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
