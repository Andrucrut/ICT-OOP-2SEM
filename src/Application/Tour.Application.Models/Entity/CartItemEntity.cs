namespace Tour.Application.Models.Entity;

public class CartItemEntity
{
    public int Id { get; set; }
    public CartEntity Cart { get; set; }
    public TravelPackageEntity TravelPackage { get; set; }
    public int Amount { get; set; }
}