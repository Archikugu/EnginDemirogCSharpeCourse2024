using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.EntityFramework
{
    public class EfInstructorDal : GenericRepository<Instructor>, IInstructorDal
    {
        public EfInstructorDal(Context context) : base(context)
        {
        }
    }
}
