namespace efcoreApp.Data
{
    public class Student
    {
        public int StudentId { get; set; }

        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string NameSurname
        {
            get
            {
                return this.StudentName + "" + this.StudentSurname;
            }
        }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<CourseRegister> CourseRegisters { get; set; } = new List<CourseRegister>();

    }
}
