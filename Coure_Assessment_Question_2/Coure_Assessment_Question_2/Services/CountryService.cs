using Coure_Assessment_Question_2.Models.ViewModels;
using Coure_Assessment_Question_2.Repositories;
using System.Text.RegularExpressions;

namespace Coure_Assessment_Question_2.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepo;

        public CountryService(ICountryRepository countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public ResponseVM GetCountryByNumber(string number)
        {
            var response = new ResponseVM();

            //Check if the input is null or empty.
            if (string.IsNullOrEmpty(number))
            {
                response.Message = "Number can not be empty.";
                return response;
            }

            /*Check for validity of the phone number.
             * 
             * For the purpose of this assessment, the validation is base on the following:
                * The phone number must be 13 digit
                * Must not contain any formating character but may have '+' sign at the beginning (not a must)
                * There should be no space in between.
            
            Further validation can still be done base on requirement using regular expresion by defining another pattern.*/

            if (!ValidatePhoneNumber(number))
            {
                response.Message = "Invalid phone number.";
                return response;
            }

            var code = number[0] == '+' ? number.Substring(1, 3) : number.Substring(0, 3);

            var country = _countryRepo.GetByCode(code);
            if(country == null)
            {
                response.Message = $"Country with the code {code} of the phone number not found";
                return response;
            }

            response.Message = "Success";
            response.Output = new CountryResponseModel
            {
                Number = number,
                Country = new CountryVM
                {
                    Name = country.Name,
                    CountryCode = country.CountryCode,
                    CountryIso = country.CountryIso,
                    CountryDetails = country.Details.Select(d => new CountryDetailsVM
                    {
                        Operator = d.Operator,
                        OperatorCode = d.OperatorCode
                    }).ToList()
                }
            };

            return response;
        }

        private bool ValidatePhoneNumber(string number)
        {
            // Define a regular expression pattern for a simple phone number format
            // In this project, I only assume a 13-digit number without any formatting characters but may start with '+'.
            // Without space.
            string pattern = @"^(\+\d{13}|\d{13})$";

            return Regex.IsMatch(number, pattern);
        }
    }
}
