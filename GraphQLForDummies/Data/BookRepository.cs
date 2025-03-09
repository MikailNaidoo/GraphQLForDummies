using GraphQLForDummies.Models;

namespace GraphQLForDummies.Data
{
    public class BookRepository
    {
        private readonly List<Book> _books = new()
    {
        new Book { Id = 1, Title = "1984", Author = "George Orwell" },
        new Book { Id = 2, Title = "Brave New World", Author = "Aldous Huxley" },
        new Book { Id = 3, Title = "Fahrenheit 451", Author = "Ray Bradbury" }
    };

        public List<Book> GetBooks() => _books;
    }
}
