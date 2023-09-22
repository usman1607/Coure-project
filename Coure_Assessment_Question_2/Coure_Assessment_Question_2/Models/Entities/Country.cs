namespace Coure_Assessment_Question_2.Models.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetails> Details { get; set; } = new List<CountryDetails>();
    }
}
