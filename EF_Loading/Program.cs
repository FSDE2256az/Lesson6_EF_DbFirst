using EF_Loading.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Loading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // var libraryContext = new LibraryContext();
            // 
            // var authors = libraryContext.Authors;
            // 
            // foreach (var item in authors.TagWith("Program.cs"))
            // {
            //     Console.WriteLine($"Name: {item.FirstName}");
            // }

            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // // Loading => Class daxilinde olan Navigation Property-lere uygun olaraq datalari elde edilmesidir

            // // 1. Eager Loading
            // // 2. Explicit Loading
            // // 3. Lazy Loading

            // // 1. Eager Loading  => Evvelden hansi np-leri getirmek isteyirsense, onlar goturur

            // var libraryContext = new LibraryContext();
            // 
            // var authors = libraryContext.Authors
            //                       .Include(x => x.Books)
            //                            .ThenInclude(x => x.SCards)
            //                                 .ThenInclude(x => x.IdLibNavigation)
            // 
            //                       .Include(x => x.Books)
            //                             .ThenInclude(x => x.IdCategoryNavigation)
            //     ;
            // 
            // 
            // foreach (var author in authors.TagWith("Program.cs"))
            // {
            //     Console.WriteLine($"Author: {author.FirstName} {author.LastName}");
            // 
            //     Console.WriteLine("Books:");
            //     foreach (var book in author.Books)
            //     {
            //         Console.WriteLine($"\tBook: {book.Name} \tCategoryName: {book.IdCategoryNavigation.Name}");
            //     }
            //     Console.WriteLine("\n");
            // }

            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // // 2. Explicit Loading => aninda sene hansi lazimdirsa, aninda goturursen

            // var dbContext = new LibraryContext();
            // 
            // var author = dbContext.Authors.FirstOrDefault();
            // 
            // Console.WriteLine(author.Books.Count());
            // 
            // dbContext.Entry(author).Collection(x=> x.Books).Load();
            // 
            // 
            // foreach (var book in author.Books)
            // {
            //     Console.WriteLine(book);
            // 
            //     dbContext.Entry(book).Reference(x => x.IdCategoryNavigation).Load();
            // 
            //     Console.WriteLine(book.IdCategoryNavigation.Name);
            // }

            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // // 3. Lazy Loading => Hamsini evvelceden kecirik

            // 1. Proxies 
            // 2. Navigation Property-lere virtual
            // 3. OnConfiguring => UseLazyLoadingProxies()


            var dbContext = new LibraryContext();

            var authors = dbContext.Authors;

            // Lazy Loading => n + 1 problemi

            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName);

                //foreach (var book in author.Books)
                //{
                //    Console.WriteLine(book.Name);
                //}
            }

            Console.WriteLine("\nBooks");

            var books = authors.Select(x => x.Books).FirstOrDefault();
            foreach (var book in books)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
