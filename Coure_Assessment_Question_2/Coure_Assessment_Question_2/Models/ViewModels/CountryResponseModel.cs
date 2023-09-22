using Coure_Assessment_Question_2.Models.Entities;

namespace Coure_Assessment_Question_2.Models.ViewModels
{
    public class ResponseVM
    {
        public string? Message { get; set; }
        public CountryResponseModel? Output { get; set; }
    }

    public class CountryResponseModel
    {
        public string Number { get; set; }
        public CountryVM Country { get; set; }
    }

    public class CountryVM
    {        
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailsVM> CountryDetails { get; set; } = new List<CountryDetailsVM>();
    }

    public class CountryDetailsVM
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
