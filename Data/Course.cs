namespace efcoreApp.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public ICollection<CourseRegister> CourseRegisters { get; set; } = new List<CourseRegister>();

    }
}
