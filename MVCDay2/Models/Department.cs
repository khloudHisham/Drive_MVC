namespace MVCDay2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string DeptManager { get; set;}

        public virtual List<Course> Courses { get; set; }
        public virtual List<Instractor> Instractors { get;}
        public virtual List<Trainee> Trainees { get; set; } 
    }
}
