using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class CRSresult
    {
        
        public int Id { get; set; }
        public int CrsDegree { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        
        [ForeignKey("Trainee")]
        public int TRId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}
