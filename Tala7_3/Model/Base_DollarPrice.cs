namespace Tala7_3.Model
{
    public class Base_DollarPrice:Abstrackfields
    {
        public string LastDatetime_DollarPrice;

        public string Dollar_Price;

        public string Description;
        public short Status { get; set; }

        public Base_GoldPrice? base_GoldPrice { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Base_DollarPrice()
        {

        }

        public Base_DollarPrice(string lastDatetime_DollarPrice, string dollar_Price, string description,short status)
        {
            LastDatetime_DollarPrice = lastDatetime_DollarPrice;
            Dollar_Price = dollar_Price;
            Description = description;
            Status = status;
        }
    }
}
