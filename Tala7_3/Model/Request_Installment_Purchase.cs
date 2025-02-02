using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class Request_Installment_Purchase
    {
        public string Date_register { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }    
        public string Bank_Branch { get; set; }
        public string Bank_Branch_Code { get; set; }
        public string Number_Account_Bank { get; set; }
        public string Reagent { get; set; }
        public string Type_Job { get; set; }
        public string Type_Sub_Job { get; set; }
        public string Job_Title { get; set; }
        public string Requested_Amount { get; set; }//مبلغ درخواستی
        public short Status_Recive_Gold { get; set; }
        public short Month_Installment_Purchase { get; set; }
        public int ApplicantId { get; set; }


        public Applicant Applicant { get; set; }

        public Request_Installment_Purchase()
        {

        }

        public Request_Installment_Purchase(string date_register, int bankId,  string bank_Branch, string bank_Branch_Code, string  number_Account_Bank,string reagent,string type_Job, string type_Sub_Job, string job_Title,string requested_Amount,short status_Recive_Gold,short month_Installment_Purchase,int applicantId)
        {
            Date_register = date_register;
            BankId = bankId;
        
            Bank_Branch = bank_Branch;
            Bank_Branch_Code = bank_Branch_Code;
            Number_Account_Bank = number_Account_Bank;
            Reagent = reagent;
            Type_Job = type_Job;
            Type_Sub_Job = type_Sub_Job;
            Job_Title = job_Title;
            Requested_Amount = requested_Amount;
            Status_Recive_Gold = status_Recive_Gold;
            Month_Installment_Purchase = month_Installment_Purchase;
            ApplicantId = applicantId;
           


        }
    
    }
}
