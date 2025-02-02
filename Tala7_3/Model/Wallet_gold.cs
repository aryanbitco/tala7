using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class Wallet_gold : Abstrackfields
    {

        public string Date_register { get; set; }
        public string Wallet_number { get; set; }
        public string Exist_Gold { get; set; }
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public int? Old_Wallet_gold_Id { get; set; }
        public Wallet_gold? wallet_gold { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Wallet_gold()
        {

        }

        public Wallet_gold(string date_register, string wallet_number, string exist_Gold, int applicantId,  int old_Wallet_Id)
        {
            Date_register = date_register;
            Wallet_number = wallet_number;
            Exist_Gold = exist_Gold;
            ApplicantId = applicantId;
           
            Old_Wallet_gold_Id = old_Wallet_Id;


        }


    }
}
