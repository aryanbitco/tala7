namespace Tala7_3.Model
{
    public class Store:Abstrackfields
    {
        public string Store_Name { get; set; }
        public string Store_Description { get; set; }
        public int Store_Code { get; set; }
        public short Status { get; set; }
      
       



        public Store()
        {

        }

        public Store(string store_Name, string store_Description, int store_Code, short status)
        {
            Store_Name = store_Name;
            Store_Description = store_Description;
            Store_Code = store_Code;
            Status = status;
           

        }


    }
}
