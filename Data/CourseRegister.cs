using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class CourseRegister
    {
        [Key]
        public int RegisterId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}
