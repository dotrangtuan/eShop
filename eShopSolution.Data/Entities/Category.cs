using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; }

    public List<Product> Products { get; set; }
    
}