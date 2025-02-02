using System.ComponentModel.DataAnnotations.Schema;

namespace Tala7_3.Model.Profile
{
    public class Seller : Abstrackfields
    {

        public string Name { get; set; }
        public string Family { get; set; }
        public string Natainal_code { get; set; }
        public int Seller_code { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Sahm_darsad_sood_tavagoghi { get; set; }
        public string Address { get; set; }

        [NotMapped]
        public virtual string Fullname { get; set; }

        public short Status { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Seller()
        {

        }

        public Seller(string name, string family, string natainal_code, int seller_code, string tel, string mobile, string sahm_darsad_sood_tavagoghi, string address, short status)
        {
            Name = name;
            Family = family;
            Natainal_code = natainal_code;
            Seller_code = seller_code;
            Tel = tel;
            Mobile = mobile;
            Sahm_darsad_sood_tavagoghi = sahm_darsad_sood_tavagoghi;
            Address = address;
            Status = status;
            Fullname = name + " " + family;
        }


    }

}
