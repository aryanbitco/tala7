namespace Tala7_3.Model
{
    public class Base_ProductPrice:Abstrackfields
    {
        public string LastDatetime_ProductPrice;
        public string Product_Price;
        public string Description;

        public int ProductId_Fk { get; set; }
       
        public Product Product { get; set; }
        public short Status { get; set; }

        public Base_ProductPrice? base_ProductPrice { get; set; }//آبجکت ولت قبلی را در صورت وجود برای ما می آورد
        public Base_ProductPrice()
        {

        }

        public Base_ProductPrice(string lastDatetime_ProductPrice, string product_Price, string description,int productId_Fk, Product product, short status)
        {
            LastDatetime_ProductPrice = lastDatetime_ProductPrice;
            Product_Price = product_Price;
            Description = description;
            ProductId_Fk = productId_Fk;
            Product = product;
            Status = status;

        }

    }
}
