using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
//        static void Main(string[] args)
//        {
//            // args => expression
//            int factor = 5;
//
//            Func<int, int> square = number => number * number;
//            Func<int, int> multiple = number => factor * number;
//            square = Square;
//            Console.WriteLine(square(10));
//            Console.WriteLine(multiple(45));
//        }

        static void Main(String[] args)
        {
            var books = BookRepository.GetBooks();

//            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
//            var cheapBooks = books.FindAll(book => book.Price < 10);
//            foreach (var book in cheapBooks)
//            {
//                Console.WriteLine(book.Title + " " + book.Price);
//            }
            // linq expressions
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(book => book.Title)
                                .Select(book => book.Title);

            var cheapBooksOperator = from b in books
                where (b.Price < 10)
                orderby (b.Title)
                select (b.Title);

                                 var booksOrderedByTitle = books.OrderBy(book => book.Title);
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        static int Square(int number)
        {
            return number * number;
        }

        static void Apply(ref int x, Func<int, int> function)
        {
            function(x);
        }
    }
}
