namespace Tala7_3.Model
{
    public abstract class  Abstrackfields
    {
        public int Id {  get; set; }
        public int CreatedUserId {  get; set; }
        public DateTime CreatedAt {  get; set; }
        public int? UpdatedUserId {  get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

      
    }




}
