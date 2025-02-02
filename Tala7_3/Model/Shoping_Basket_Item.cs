namespace Tala7_3.Model
{
    public class Shoping_Basket_Item : Abstrackfields
    {

        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }
        public decimal Calculated_Price { get; set; }
        public int Number_Of_Order { get; set; } 
        public decimal Discount { get; set; }
        public decimal Discount_percent { get; set; }

        public decimal Wage_Percent { get; set; }
        public decimal Wage { get; set; }

        public decimal Profit_Percent { get; set; }
        public decimal Profit { get; set; }
        public decimal Last_Price_Dollar { get; set; }
        public decimal Last_Price_Gold { get; set; }
        public decimal Discount_copon { get; set; }




    }
}
