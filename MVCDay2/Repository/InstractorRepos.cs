using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.ViewModel;

namespace MVCDay2.Repository
{
    public class InstractorRepos : IInstractorRepos
    {
        MyContext Context;
        public InstractorRepos(MyContext _context)
        {
            this.Context = _context;
        }


        public List<Instractor> GetAll()
        {
            return Context.Instractors.ToList();
        }
        //public IQueryable<InsShowViewModel>GetAll()
        //{
        //    var instructorViewModels = (from instractor in Context.Instractors
        //                                join Course in Context.Courses on instractor.CourseId equals Course.Id into courseGroup
        //                                join Department in Context.Departments on instractor.DeptId equals Department.Id into departmentGroup
        //                                from course in courseGroup.DefaultIfEmpty()
        //                                from department in departmentGroup.DefaultIfEmpty()
        //                                select new InsShowViewModel
        //                                {
        //                                    Id = instractor.Id,
        //                                    Name = instractor.InsName,
        //                                    Salary = instractor.InsSalary,
        //                                    Address = instractor.InsAddress,
        //                                    Image = instractor.InsImage,
        //                                    Cours = 
        //                                     Dept = Department.DeptName
        //                                }).ToList();

        //    return instructorViewModels;
        //}

        public Instractor GetById(int id) 
        {
            return Context.Instractors.FirstOrDefault(i => i.Id==id);
        }

        public void Insert (Instractor inst) 
        {
            Context.Add(inst);
        }
        public void Edit(Instractor inst)
        {
            Context.Update(inst);
        }
        public void Delete(int id)
        {
            Context.Remove(GetById(id));
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
