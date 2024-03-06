using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string TrName { get; set; }
        public string TrAddress { get; set; }
        public int TrGrade { get; set; }
        public string TrImage { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<CRSresult> CRS { get; set; }
    }
}
