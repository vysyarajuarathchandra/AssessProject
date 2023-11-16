using AssessProject.Entites;

namespace AssessProject.Services
{
    public interface IBookServices
    {
        void AddBook(Book book);
        List<Book> GetBooks();
        List<Book> GetBookByAuthor(string BookAuthor);
        List<Book> GetBookByLanguage(string BookLanguage);
        List<Book> GetBookByyear(DateTime ReleaseDate);
        void UpdateBook(Book book);

        void DeleteBook(int BookId);
    }
}
