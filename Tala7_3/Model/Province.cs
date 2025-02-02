namespace Tala7_3.Model
{

    public class Province : Abstrackfields
    {
        public Province(string name, int? code, int countryId)
        {
            Name = name;
            Code = code;
            CountryId = countryId;
        }

        public string Name { get; protected set; }
        public int? Code { get; protected set; }

        public int CountryId { get; protected set; }
        public Country Country { get; protected set; }

        public ICollection<City> Cities { get; protected set; }
        

    }
}