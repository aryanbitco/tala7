using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class Shopping_Basket : Abstrackfields
    {
        public string Date_register { get; set; }


        public int ApplicantId { get; set; }

        public ICollection< Applicant> Applicants { get; set; }

        //public int ProductId { get; set; }

        //public ICollection<Product> Products { get; set; }
        public decimal Sum_Shopping_Basket { get; set; }

        public int Code_Shopping_Basket { get; set; }
        public short Status { get; set; }
       // public Shopping_Cart? shopping_Cart { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Shopping_Basket()
        {

        }

        public Shopping_Basket(string date_register, int applicantId,decimal sum_Shopping_Basket,int code_Shopping_Basket, short status)
        {
            Date_register = date_register;
            ApplicantId = applicantId;
            Sum_Shopping_Basket = sum_Shopping_Basket;
            Code_Shopping_Basket = code_Shopping_Basket;
            Status = status;


        }



    }
}
