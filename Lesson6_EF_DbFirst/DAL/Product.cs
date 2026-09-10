namespace Lesson6_EF_DbFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int StockCount { get; set; }
    public decimal Price { get; set; }
}
