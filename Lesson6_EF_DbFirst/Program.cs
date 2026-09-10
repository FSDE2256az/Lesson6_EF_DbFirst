using Lesson6_EF_DbFirst.Contexts;

namespace Lesson6_EF_DbFirst;


public class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new AppDbContext();

        var products = context.Products.ToList();

        foreach(var item in products)
        {
            Console.WriteLine($"{item.Id} - {item.Name}");
        }
    }
}
