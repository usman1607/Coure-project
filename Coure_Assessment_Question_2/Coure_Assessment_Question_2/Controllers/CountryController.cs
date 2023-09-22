using Coure_Assessment_Question_2.Models.ViewModels;
using Coure_Assessment_Question_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Coure_Assessment_Question_2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public ResponseVM GetCountryByNumber([Required] string phoneNumber)
        {
            var res = _countryService.GetCountryByNumber(phoneNumber);

            return res;
        }
    }
}
