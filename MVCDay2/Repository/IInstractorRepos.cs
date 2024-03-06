using MVCDay2.Models;

namespace MVCDay2.Repository
{
    public interface IInstractorRepos
    {
        public List<Instractor> GetAll();

        public Instractor GetById(int id);

        public void Insert(Instractor inst);

        public void Edit(Instractor inst);

        public void Delete(int id);

        public void Save();
    }
}
