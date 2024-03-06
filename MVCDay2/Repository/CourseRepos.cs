using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.ViewModel;

namespace MVCDay2.Repository
{
    public class CourseRepos : ICourseRepos
    {
        MyContext context;
        public CourseRepos(MyContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<Course> GetByDepartmentId(int departId)
        {
            return context.Courses.Where(c => c.DeptId == departId).ToList();
        }
        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }
        public List<Instractor> GetInsShows()
        {
            return context.Instractors
            .Include(i => i.Course)
            .Include(i => i.Department)
            .ToList();

          
        }

        public Course GetById(int id)
        {
            return context.Courses.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Course crs)
        {
            context.Add(crs);
        }

        public void Edit(Course crs)
        {
            context.Update(crs);
        }

        public void Delete(int id)
        {
            context.Remove(id);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
