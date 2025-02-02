namespace Tala7_3.Model
{
    public class News : Abstrackfields
    {
        public string Title { get; set; }
        public string Lead { get; set; }
        public string Content_news { get; set; }
        public string Date_publish { get; set; }
        public int Count_View { get; set; }
        public short Status { get; set; }





        public News()
        {

        }

        public News(string title, string lead, string content_news,  string date_publish,int count_View, short status)
        {
            Title = title;
            Lead = lead;
            Content_news = content_news;
            Date_publish = date_publish;
            Count_View = count_View;
            Status = status;


        }



    }
}
