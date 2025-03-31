public class Product
{
    public string Name {get;set;}
    public decimal UnitPrice{get;set;}
    public bool IsFeatured {get;set;}

    public DiscountedProduct ApplyDiscountFor(IUserContext user)
    {
        bool preferred = user.IsInRole(Role.PreferredCustomer);
        decimal discount = preferred ? 0.95m : 1.00m;

        return new DiscountedProduct(this.Name, this.UnitPrice * discount);
    }
}