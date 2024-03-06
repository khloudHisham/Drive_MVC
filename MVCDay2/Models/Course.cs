using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay2.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Name Must BE More Than 2 Char")]
        [MaxLength(10, ErrorMessage = "Name Must Be Less Than 10 Char")]
        [Unique]
        public string CourseName { get; set; }

        [Range(50, 100, ErrorMessage = "Course Degree Must be with in range 50 to 100")]
        public int CourseDegree { get; set; }

        [Remote(action:"CheckMinDegree",controller:"CourseNew",AdditionalFields = "CourseDegree", ErrorMessage = "Min Degree must be less than Course Degree ")]
        public int CourseMinDegree { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public int DeptId { get; set; }
        public virtual Department? Department { get; set; }
        public virtual List<Instractor>? Instractors { get; set; }
        
        public virtual List<CRSresult>? CRSresults { get; set; }


    }
}
