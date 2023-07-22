namespace AspNet.MVC.Models
{
    public class Book
    {
        public int BookNumber { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public List<Author> Authors { get; set; }


        public Book()
        {
            Authors = new List<Author>();
        }
        
    }
}
