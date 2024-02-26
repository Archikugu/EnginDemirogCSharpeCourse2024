using Entities.Abstracts;

namespace Entities.Concretes
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
