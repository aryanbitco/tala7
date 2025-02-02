namespace Tala7_3.Model
{
    public class Base_GoldPrice:Abstrackfields
    {
        public string LastDatetime_GoldPrice;
        public string Gold_Price;
        public string Description;
        public short Status { get; set; }

        public Base_GoldPrice? base_GoldPrice { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Base_GoldPrice()
        {

        }

        public Base_GoldPrice(string lastDatetime_GoldPrice, string gold_Price, string description,short status)
        {
            LastDatetime_GoldPrice = lastDatetime_GoldPrice;
            Gold_Price = gold_Price;
            Description = description;
            Status=status;  

        }




    }
}
