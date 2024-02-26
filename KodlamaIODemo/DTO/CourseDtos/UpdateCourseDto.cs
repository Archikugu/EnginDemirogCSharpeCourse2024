namespace DTO.CourseDtos
{
    public class UpdateCourseDto
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
