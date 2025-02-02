using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{

    public class City : Abstrackfields
    {
        public City(string name, int? code, int provinceId)
        {
            Name = name;
            Code = code;
            ProvinceId = provinceId;
        }

        public string Name { get; set; }
        public int? Code { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        
        public ICollection<Applicant> Applicants { get; set; }
             

    }
}