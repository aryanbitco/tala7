using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class Wallet_Installment_Purchase : Abstrackfields
    {
        public string Date_register { get; set; }
        public string Wallet_number { get; set; }
        public string Exist_Installment_Purchase { get; set; }
        public int ApplicantId { get; set; }

        public Applicant Applicant { get; set; }

        public int? Old_Wallet_Installment_Purchase_Id { get; set; }
        public Wallet_gold? wallet_Installment_Purchase { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
       
        public Wallet_Installment_Purchase()
        {

        }

        public Wallet_Installment_Purchase(string date_register, string wallet_number, string exist_Installment_Purchase, int applicantId, Applicant applicant, int old_Wallet_Installment_Purchase_Id)
        {
            Date_register = date_register;
            Wallet_number = wallet_number;
            Exist_Installment_Purchase = exist_Installment_Purchase;
            ApplicantId = applicantId;
            Applicant = applicant;
            Old_Wallet_Installment_Purchase_Id = old_Wallet_Installment_Purchase_Id;


        }




    }
}
