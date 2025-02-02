namespace Tala7_3.Model
{
    public class TypeProduct_Master : Abstrackfields
    {

        public string NameTypeProduct_Master { get; set; }
        public int TypeProductCode_Master { get; set; }
        public short Status { get; set; }




        public TypeProduct_Master()
        {

        }

        public TypeProduct_Master(string nameTypeProduct_Master, int typeProductCode_Master, short status)
        {
            NameTypeProduct_Master = nameTypeProduct_Master;
            TypeProductCode_Master = typeProductCode_Master;
            Status = status;
            


        }


    }
}
