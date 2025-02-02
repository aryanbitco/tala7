using System.ComponentModel.DataAnnotations.Schema;

namespace Tala7_3.Model.Profile
{




    public class Applicant : Abstrackfields
    {

        public string Name { get; set; }
        public string Family { get; set; }
        public string Natainal_code { get; set; }
        public string Post_code { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }

        public string Email { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        [NotMapped]
        public virtual string Fullname { get; set; }

        public short Status { get; set; }

        public ApplicationUser ApplicationUser { get; set; }    

        public Applicant()
        {

        }


        public Applicant(string name, string family, string national_code, string post_code, string tel, string mobile, string address, string lat, string lon, string email, short status, int cityId)
        {
            Name = name;
            Family = family;
            Natainal_code = national_code;
            Post_code = post_code;
            Tel = tel;
            Mobile = mobile;
            Address = address;
            Lat = lat;
            Lon = lon;
            Email = email;
            Status = status;
            Fullname = name + " " + family;
            CityId = cityId;
        }

        //public Update Applicant(string name, string family, string national_code, string post_code, string tel, string mobile, string address, string lat, string lon, short status)
        //{
        //    Name = name;
        //    Family = family;
        //    Natainal_code = national_code;
        //    Post_code = post_code;
        //    Tel = tel;
        //    Mobile = mobile;
        //    Address = address;
        //    Lat = lat;
        //    Lon = lon;
        //    Status = status;
        //    Fullname = name + " " + family;
        //}

    }

}
