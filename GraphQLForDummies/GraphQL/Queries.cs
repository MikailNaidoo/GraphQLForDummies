using GraphQLForDummies.Data;
using GraphQLForDummies.Models;

namespace GraphQLForDummies.GraphQL
{
    public class Query
    {
        public List<Book> GetBooks([Service] BookRepository repository) => repository.GetBooks();
    }
}
