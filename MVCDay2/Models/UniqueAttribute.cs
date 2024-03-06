using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MVCDay2.Models
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            MyContext Context = new MyContext();
            //Course Crs = Context.Courses.FirstOrDefault(c => c.CourseName == value.ToString());
            //if (Crs == null)
            //{
            //    return ValidationResult.Success;
            //}
            //return new ValidationResult("Name Already Exist");



            var Course = validationContext.ObjectInstance as Course;
            var DeptId = Course.DeptId;

            var existingCourses = Context.Courses
           .Where(c => c.DeptId == DeptId)
           .Where(c => c.CourseName == value)
           .ToList();

            if (existingCourses.Count() == 0)
            {
                 return ValidationResult.Success;
            }
            return new ValidationResult("The course name must be unique within the department.");
          
        }
    }

}
