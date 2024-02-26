using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        public EfCourseDal(Context context) : base(context)
        {
        }
    }
}
