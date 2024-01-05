namespace eShopSolution.Data.Entities;

public class Product
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public int Stock { set; get; }
    public int ViewCount { get; set; }
    public DateTime DateCreated { get; set; }
    public String? SeoAlias { get; set; }
    
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

}