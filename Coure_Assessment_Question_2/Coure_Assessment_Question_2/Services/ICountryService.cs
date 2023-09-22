using Coure_Assessment_Question_2.Models.ViewModels;

namespace Coure_Assessment_Question_2.Services
{
    public interface ICountryService
    {
        public ResponseVM GetCountryByNumber(string number);
    }
}
