namespace Tala7_3.Model
{

   

    public class TypeProduct_SubMaster:Abstrackfields
    {
        public string NameTypeProduct_SubMaster { get; set; }
        public int TypeProductCode_SubMaster { get; set; }
        public short Status { get; set; }

        public TypeProduct_SubMaster()
        {

        }


        public TypeProduct_SubMaster(string nameTypeProduct_SubMaster, int typeProductCode_SubMaster, short status)
        {
            NameTypeProduct_SubMaster = nameTypeProduct_SubMaster;
            TypeProductCode_SubMaster = typeProductCode_SubMaster;
            Status = status;



        }





    }
}
