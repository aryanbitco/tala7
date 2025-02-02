using Tala7_3.Model.Profile;

namespace Tala7_3.Model
{
    public class Doc_Store:Abstrackfields
    {
        public string RegisterDate { get; set; }
       
        public int Number_Exist { get; set; }
        public int Number_Store_Operate { get; set; }
        public short Status { get;set; }

        public short Type_Opearate { get; set; }

        public int StoreId { get; set; }       
        public ICollection<Store> Stores { get; set; }

        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }

        public Doc_Store()
        {

        }

        public Doc_Store(string registerDate, int number_Exist, int number_Store_Operate, short status,short type_Opearate,int storeId,int productId)
        {
            RegisterDate = registerDate;
            Number_Exist = number_Exist;
            Number_Store_Operate=number_Store_Operate;
            Status = status;
            Type_Opearate=type_Opearate;    
            StoreId = storeId;
            ProductId = productId;


        }


    }
}
