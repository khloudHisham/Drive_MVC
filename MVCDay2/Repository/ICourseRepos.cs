using MVCDay2.Models;
using MVCDay2.ViewModel;

namespace MVCDay2.Repository
{
    public interface ICourseRepos
    {
        IEnumerable<Course> GetByDepartmentId(int departId);
        public List<Course> GetAll();
        public List<Instractor> GetInsShows();

        public Course GetById(int id);

        public void Insert(Course crs);

        public void Edit(Course crs);

        public void Delete(int id);

        public void Save();
    }
}
