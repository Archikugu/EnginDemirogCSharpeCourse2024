using Entities.Abstracts;

namespace Entities.Concretes
{
    public class Instructor : IEntity
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<Course> Courses { get; set; }
    }
}
