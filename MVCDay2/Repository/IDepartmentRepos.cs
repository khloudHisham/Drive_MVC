using MVCDay2.Models;

namespace MVCDay2.Repository
{
    public interface IDepartmentRepos
    {
        public List<Department> GetAll();

        public Department GetById(int id);

        public void Insert(Department obj);

        public void Edit(Department obj);

        public void Delete(int id);

        public void Save();

    }
}
