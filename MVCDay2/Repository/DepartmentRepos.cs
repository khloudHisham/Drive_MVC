using MVCDay2.Models;

namespace MVCDay2.Repository
{
    public class DepartmentRepos : IDepartmentRepos
    {
        MyContext Context;
        public DepartmentRepos(MyContext context)
        {
            Context = context;
        }
        public List<Department> GetAll()
        {
            return Context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return Context.Departments.FirstOrDefault(d=>d.Id==id);
        }

        public void Insert(Department obj)
        {
            Context.Add(obj);
        }

        public void Edit(Department obj)
        {
            Context.Update(obj);
        }

        public void Delete(int id)
        {
            Context.Remove(id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }


    }
}
