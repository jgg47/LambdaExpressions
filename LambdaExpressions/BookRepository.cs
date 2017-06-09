using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Price = 10,
                    Title = "Clean Code"
                },
                new Book
                {
                    Price = 15,
                    Title = "Not Clean Code"
                },
                new Book
                {
                    Price = 4,
                    Title = "Cheat Codes"
                }
            };
        }
    }
}