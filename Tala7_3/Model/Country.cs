namespace Tala7_3.Model
{

    public class Country : Abstrackfields
    {
        public Country(string name, int? code)
        {
            Name = name;
            Code = code;
        }

        public string Name { get; protected set; }
        public int? Code { get; protected set; }

        public ICollection<Province> Provinces { get; set; }
    }
}