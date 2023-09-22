using Coure_Assessment_Question_2.Models.Entities;

namespace Coure_Assessment_Question_2.Repositories
{
    public interface ICountryRepository
    {
        public List<Country> GetAll();
        public Country? GetById(int id);
        public Country? GetByCode(string code);
    }
}
