using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Instractor
    {
        public int Id { get; set; }
        public string InsName { get; set; }
        public string InsAddress { get; set; }
        public decimal InsSalary { get; set; }
        public string InsImage { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }

    }
}
