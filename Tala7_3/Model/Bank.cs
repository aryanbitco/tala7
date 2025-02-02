namespace Tala7_3.Model
{
    public class Bank:Abstrackfields
    {
        public string Bank_Name { get; set; }
        public string Bank_Description { get; set; }
        public int Bank_Code { get; set; }
        public short Status { get; set; }





        public Bank()
        {

        }

        public Bank(string bank_Name, string bank_Description, int bank_Code, short status)
        {
            Bank_Name = bank_Name;
            Bank_Description = bank_Description;
            Bank_Code = bank_Code;
            Status = status;


        }
    }
}
