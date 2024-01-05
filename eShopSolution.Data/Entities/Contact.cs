using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Entities;

public class Contact
{
    public Guid Id { set; get; }
    public string Name { set; get; }
    public string Email { set; get; }
    public string PhoneNumber { set; get; }
    public string Message { set; get; }
    public Status Status { set; get; }

}