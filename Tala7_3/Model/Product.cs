namespace Tala7_3.Model
{
    public class Product:Abstrackfields
    {


        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Product_Code { get; set; }
        public short Status { get; set; }
        public string Counting_Unit { get; set; }  
        public short Price_Calculation_Method { get; set; }
        public short Type_sell { get; set; }
        public decimal Gold_wieght { get; set; }    
        public decimal Stone_Price { get; set; }
        public decimal Stone_Ghirat { get; set; }
        public int Stone_Number { get; set; }
        public decimal Provider_Share_Wage_Percent { get; set; }
        public decimal Provider_Share_Profit_Percent { get; set; }
        public decimal Provider_Share_Stone_Price { get; set; }
        public Product()
        {

        }

        public Product(string product_Name, string product_Description, int product_Code, short status, string counting_Unit, short price_Calculation_Method,short type_sell)
        {
            Product_Name = product_Name;
            Product_Description = product_Description;
            Product_Code = product_Code;
            Status = status;
            Counting_Unit = counting_Unit;
            Price_Calculation_Method = price_Calculation_Method;
            Type_sell = type_sell;


        }




    }
}
