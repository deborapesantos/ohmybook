namespace OMB.Core.Domain
{
    public class Book
    {
        public string Title {get; private set;}
        public string Autor {get; private set;}

        public Book()
        {

        }
        public Book(string title,string autor)
        {
            Title = title;
            Autor = autor;
        }
    }
}
 