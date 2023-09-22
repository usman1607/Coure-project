using Coure_Assessment_Question_2.Context;
using Coure_Assessment_Question_2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coure_Assessment_Question_2.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Country> GetAll()
        {
            return _context.Countries.Include(c => c.Details).ToList();
        }

        public Country? GetById(int id)
        {
            return _context.Countries.Include(c => c.Details).Where(c => c.Id == id).SingleOrDefault();
        }

        public Country? GetByCode(string code)
        {
            return _context.Countries.Include(c => c.Details).Where(c => c.CountryCode == code).SingleOrDefault();
        }
    }
}
