using System.Net;
using System.Reflection;
using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{


    public class Wallet_toman:Abstrackfields
    {

        public string Date_register { get; set; }
        public string Wallet_number { get; set; }
        public string Exist_toman { get; set; }
        public int ApplicantId { get; set; }

        public  Applicant Applicant { get; set; }

        public int? Old_Wallet_toman_Id { get; set; }  
        public Wallet_toman? wallet_Toman { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Wallet_toman()
        {

        }

        public Wallet_toman(string date_register, string wallet_number, string exist_toman, int applicantId, Applicant applicant, int old_Wallet_Id)
        {
            Date_register = date_register;
            Wallet_number = wallet_number;  
            Exist_toman = exist_toman;
            ApplicantId = applicantId;
            Applicant = applicant;
            Old_Wallet_toman_Id = old_Wallet_Id;


        }

    }
}
